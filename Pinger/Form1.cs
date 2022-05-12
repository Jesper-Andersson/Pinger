using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;

namespace Pinger
{
	public partial class Pinger : Form
	{
		//Declarations
		private static bool Running = false;
		private static bool pingable = false;
		private static string ip;
		private static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
		private static int alarmCounter = 1;
		private static Ping isPing = new Ping();

		private bool hasValidIp = true;
		private bool hasValidDelay = true;

		public Pinger()
		{
			InitializeComponent();

			//event handlers
			myTimer.Tick += TimerEventProcessor;
		}

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
		{
			//reset tick
			myTimer.Stop();

			//continue again
			if (Running == true)
			{
				try
				{
					PingReply reply = isPing.Send(ip);
					pingable = reply.Status == IPStatus.Success;
					DelayBox.Text = reply.RoundtripTime.ToString();
				}
				catch (PingException)
				{
					// Discard PingExceptions and return false;
				}
				if (pingable == true)
				{
					respondingStatus.Image = Properties.Resources.IMGstatusOn;
				}
				else
				{
					respondingStatus.Image = Properties.Resources.IMGstatusOff;
				}

				// Restarts the timer and increments the counter.
				alarmCounter += 1;
				myTimer.Start();
			}
		}

		//StartButton
		private void button1_Click(object sender, EventArgs e)
		{
			//timer was not running
			if (!Running)
			{
				hasValidIp = TryGetIp(out ip);
				hasValidDelay = TryGetDelay(out int pingDelay);
				if (hasValidIp && hasValidDelay)
				{
					liveStatus.Image = Properties.Resources.IMGstatusOn;
					StartButton.Text = "Stop";

					myTimer.Interval = pingDelay * 1000;
					myTimer.Start();
					Running = true;
				}
			}
			else
			{
				respondingStatus.Image = Properties.Resources.IMGstatusNeutral;
				liveStatus.Image = Properties.Resources.IMGstatusOff;

				StartButton.Text = "Start";
				pingable = false;

				myTimer.Stop();
				Running = false;
			}

			Refresh();
		}

		//makes opening code easier
		private void Pinger_Load(object sender, EventArgs e)
		{}

		private bool TryGetIp(out string ip)
		{
			ip = _IPBox.Text;
			if (String.IsNullOrWhiteSpace(ip))
			{
				return false;
			}

			return IPAddress.TryParse(ip, out _);
		}

		private bool TryGetDelay(out int delay)
		{
			string input = _PingDelayBox.Text;
			if (!int.TryParse(input, out delay))
			{
				return false;
			}

			return delay > 0;
		}

		private void SetTextBoxStyle(PaintEventArgs e, TextBox tb, bool isValid)
		{
			if (isValid)
			{
				return;
			}

			Pen p = new Pen(Color.Red);
			Graphics g = e.Graphics;
			const int variance = 1;
			g.DrawRectangle(p, new Rectangle(tb.Location.X - variance, tb.Location.Y - variance, tb.Width + variance, tb.Height + variance));
		}

		private void Pinger_Paint(object sender, PaintEventArgs e)
		{
			SetTextBoxStyle(e, _IPBox, hasValidIp);
			SetTextBoxStyle(e, _PingDelayBox, hasValidDelay);
		}
	}
}