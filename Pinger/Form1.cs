using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            if (Running == true)
            {
                //isLive.Checked = true;
                liveStatus.Image = Properties.Resources.statuson;
                StartButton.Text = "Stop";
                Ping isPing = new Ping();
                if (ip != null)
                {
                    try
                    {
                        PingReply reply = isPing.Send(ip);
                        pingable = reply.Status == IPStatus.Success;
                    }
                    catch (PingException)
                    {
                        // Discard PingExceptions and return false;
                    }
                    //IsResponding.Checked = pingable;
                        if (pingable == true)
                        {
                            respondingStatus.Image = Properties.Resources.statuson;
                        }
                        else //if (pingable == false)
                        {
                            respondingStatus.Image = Properties.Resources.statusoff;
                        }
                }
            }
            else
            {
                respondingStatus.Image = Properties.Resources.statusneutral;
                liveStatus.Image = Properties.Resources.statusoff;
                //isLive.Checked = false;
                StartButton.Text = "Start";
                pingable = false;
                //IsResponding.Checked = pingable;
            }
        }
        private void Pinger_Load(object sender, EventArgs e)
        {

        }
    }
}
