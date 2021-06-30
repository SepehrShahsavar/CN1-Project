using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CN1_Prj
{
    public class Frame : EventArgs 
    {
        public int Data { get; set; }
        public int FrameNumber { get; set; }
    }

    public class Sender
    {
        public delegate void SenderSendingFrameEventHandler(object source , Frame window);

        public event SenderSendingFrameEventHandler SendingFrame;

        public Label sendingLbl;
        public RichTextBox sendTB;
        public RichTextBox logTB;

        private bool IsGBN;
        private int windowSize;
        private List<int> frames;
        private Queue<int > sendingWindow;
        private Queue<Frame > ackList;
        private int ack = Int32.MinValue;
        int start = 0;
        int next = 1;
        int prevStart;


        public Sender(int windowSize , Label sendingLbl , RichTextBox sendTB , RichTextBox logTB , bool IsGBN)
        {
            this.windowSize = windowSize;
            this.sendingLbl = sendingLbl;
            this.sendTB = sendTB;
            this.logTB = logTB;
            this.IsGBN = IsGBN;
            frames = new List<int>();
            sendingWindow = new Queue<int>();
            ackList = new Queue<Frame>();
            Random rnd = new Random();


            while(frames.Count != windowSize*4)
            {
                int tmp = rnd.Next(0 , windowSize*10);
                if (!frames.Contains(tmp))
                {
                    frames.Add(tmp);
                }
            }

            frames.Sort();

        }

        public void sendWindow()
        {
            
            Frame frame = new Frame();

            while (next != frames.Count+1)
            {

                if (sendingWindow.Count == 0 || ack > start)
                {
                    if(ack > start)
                    {
                        sendingLbl.Text = "Awaiting Acknowledgement";
                        CheckAck();
                    }

                    SetWindow(start, sendingWindow);
                }

                frame.Data = sendingWindow.Dequeue();
                for (int i = 0; i < windowSize*4; i++)
                {
                    if (frames[i] == frame.Data)
                    {
                        frame.FrameNumber = i;
                        break;
                    }
                }
                ackList.Enqueue(frame);
                sendingLbl.Text = "Sending Frame " + frame.FrameNumber;
                sendTB.Text += "Frame " + frame.FrameNumber + " sent" +"\n";
                next++;
                OnSendingFrame(frame);
            }



            if (next == frames.Count + 1)
            {
                logTB.Text += "Data Transmited\n";
                return;
            }
        }

        private void SetWindow(int start, Queue<int> window)
        {
            for (int i = 0; i < windowSize; i++)
            {
                if (i + start > frames.Count-1)
                {
                    break;
                }
                window.Enqueue(frames[i+start]);
            }
        }

        protected virtual void OnSendingFrame(Frame frame)
        {
            if (SendingFrame != null)
                SendingFrame(this , frame);
        }

        public void OnWindowReceived(object source , Acknowledge ack)
        {
            this.ack = ack.AckNum;
            CheckAck();

        }

        private void CheckAck()
        {
            if (ack >= 0)
            {
                if (ack + 1 < frames.Count-1)
                {
                    prevStart = start;
                    start = ack + 1;
                    if (ackList.Count > 0)
                    {
                        ackList.Dequeue();
                    }
                }
            }
            else if (ack < 0 && ack != Int32.MinValue)
            {
                if (!IsGBN)
                {
                    int resend = ack * -1;
                    sendingLbl.Text = "Resending frame " + resend;
                    sendTB.Text += "Resending frame " + resend + "\n";
                    OnSendingFrame(new Frame() { Data = frames[resend] , FrameNumber = resend });
                }
                else
                {
                    if (sendingWindow.Count > 0)
                    {
                        sendingWindow.Clear();
                        start = prevStart;
                        next = prevStart + 1;
                    }
                    sendTB.Text += "Resending window form frame " + prevStart + "\n";
                    SetWindow(start , sendingWindow);
                }
                
            }
        }
    }
}
