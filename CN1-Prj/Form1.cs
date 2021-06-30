using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CN1_Prj
{
    public partial class Form1 : Form
    {
        private int _ticks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void reset(object sender, EventArgs e)
        {
            sendingTB.Text = "";
            receivingTB.Text = "";
            Send_lbl.Text = "Sending";
            Receive_lbl.Text = "Sending";
            logTB.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void start(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            bool isGBN;
            if (selectiveRepeat.Checked)
            {
                isGBN = false;
            }
            else
            {
                isGBN = true;
            }
            Sender sender1 = new Sender(Int32.Parse(windowSizeTxt.Text) , Send_lbl , sendingTB ,logTB , isGBN);
            Receiver receiver1 = new Receiver(Int32.Parse(windowSizeTxt.Text), Receive_lbl , receivingTB , logTB , totalSuccessLbl , totalErrorLbl);
            sender1.SendingFrame += receiver1.OnFrameSent;
            receiver1.WindowReceived += sender1.OnWindowReceived;

            sender1.sendWindow();

            DateTime finish = DateTime.Now;

            TimeSpan ts = new TimeSpan(finish.Ticks - start.Ticks);
            timerLbl2.Text = ts.ToString();

        }

        
    }
}
