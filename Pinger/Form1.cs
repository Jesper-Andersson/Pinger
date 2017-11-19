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
        public Pinger()
        {
            InitializeComponent();
        }

		//Declarations
		public static bool Running = false;
        public static bool pingable = false;
        public static string ip;
		static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
		static int alarmCounter = 1;
		static bool exitFlag = false;

		private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
		{
			myTimer.Stop();

			// Displays a message box asking whether to continue running the timer.
			if (Running == true)
			{
				// Restarts the timer and increments the counter.
				alarmCounter += 1;
				myTimer.Enabled = true;
			}
			else
			{
				// Stops the timer.
				exitFlag = true;
			}
		}

		//IPBox
		private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //PingDelayBox(sec)
        private void AmountBox_TextChanged(object sender, EventArgs e)
        {
            int pingDelay = int.Parse(PingDelayBox.Text);
        }

        //StartButton
        private void button1_Click(object sender, EventArgs e)
        {
            ip = IPBox.Text;
            int PingDelay = int.Parse(PingDelayBox.Text);

            Running = !Running;
			myTimer.Tick += new EventHandler(TimerEventProcessor);

			myTimer.Interval = PingDelay * 1000;
			myTimer.Start();
			
			while (Running == true)
            {
				if (exitFlag == false)
				{
					liveStatus.Image = Properties.Resources.IMGstatusOn;
					StartButton.Text = "Stop";
					Ping isPing = new Ping();
					if (ip != null)
					{
						try
						{
							//PingReply reply = isPing.Send(ip);
							//pingable = reply.Status == IPStatus.Success;
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
					}
				}
            }
			respondingStatus.Image = Properties.Resources.IMGstatusNeutral;
			liveStatus.Image = Properties.Resources.IMGstatusOff;
			StartButton.Text = "Start";
			pingable = false;
        }
        private void Pinger_Load(object sender, EventArgs e)
        {

        }
    }
}
