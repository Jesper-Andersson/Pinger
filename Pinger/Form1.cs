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
			Running = !Running;

			//timer is turned on
			if (Running)
			{
				if (_IPBox.Text != null)
				{
					ip = _IPBox.Text;
					int PingDelay = int.Parse(_PingDelayBox.Text);

					liveStatus.Image = Properties.Resources.IMGstatusOn;
					StartButton.Text = "Stop";

					myTimer.Interval = PingDelay * 1000;
					myTimer.Start();
				}
			}
			else
			{
				respondingStatus.Image = Properties.Resources.IMGstatusNeutral;
				liveStatus.Image = Properties.Resources.IMGstatusOff;

				StartButton.Text = "Start";
				pingable = false;

				myTimer.Stop();
			}
		}

		//makes opening code easier
		private void Pinger_Load(object sender, EventArgs e)
		{}
	}
}
