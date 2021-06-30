using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CN1_Prj
{
    public class Acknowledge : EventArgs
    {
        public int AckNum { get; set; }
    }
    public class Receiver
    {
        public delegate void ReceiverReceivedWindowEventHandler(object source, Acknowledge ack);
        public event ReceiverReceivedWindowEventHandler WindowReceived;

        private Label totalSuccessfull;
        private Label totalError;
        private RichTextBox receiveTB;
        private RichTextBox logTB;
        private Label receivingLbl;

        private int windowSize;
        private List<int> frames;
        int index = 0;
        int counter = 0;
        Random rnd = new Random();

        public Receiver(int windowSize , Label receivingLbl , RichTextBox receiveTB , RichTextBox logTB , 
                        Label totalSuccessfull , Label totalError)
        {
            this.windowSize = windowSize;
            this.totalSuccessfull = totalSuccessfull;
            this.totalError = totalError;
            this.receivingLbl = receivingLbl;
            this.receiveTB = receiveTB;
            this.logTB = logTB;

            frames = new List<int>();

        }

        public void OnFrameSent(object source , Frame frame)
        {
            int decide = rnd.Next();
            if (counter == windowSize)
            {
                counter = 0;
            }
            
            if( decide % 4 != 0)
            {
                receivingLbl.Text = "Receiving Frame " + frame.FrameNumber;
                if (!frames.Contains(frame.Data))
                {
                    frames.Add(frame.Data);
                }
                else
                {
                    receiveTB.Text += "Frame " + frame.FrameNumber + " already received\n";
                    return;
                }
                receiveTB.Text += "Frame " + frame.FrameNumber + " received\n";
                logTB.Text += "Acknowledge " + frame.FrameNumber + " sent\n";
                counter++;
                OnFrameReceived(new Acknowledge() { AckNum = frame.FrameNumber });
            }
            else
            {
                logTB.Text += "Frame " + frame.FrameNumber + "not received\n";
                OnFrameReceived(new Acknowledge() { AckNum = frame.FrameNumber*-1 });
            }
        }

        protected virtual void OnFrameReceived(Acknowledge acknowledge)
        {
            if (WindowReceived != null)
            {
                WindowReceived(this , acknowledge );
            }
        }
    }
}
