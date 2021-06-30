namespace CN1_Prj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbn = new System.Windows.Forms.RadioButton();
            this.selectiveRepeat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.windowSizeTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Receive_lbl = new System.Windows.Forms.Label();
            this.receivingTB = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Send_lbl = new System.Windows.Forms.Label();
            this.sendingTB = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.logTB = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.timerLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalSuccessLbl = new System.Windows.Forms.Label();
            this.totalErrorLbl = new System.Windows.Forms.Label();
            this.totalSentLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.timerLbl2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbn);
            this.groupBox1.Controls.Add(this.selectiveRepeat);
            this.groupBox1.Location = new System.Drawing.Point(343, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flow Control Technique";
            // 
            // gbn
            // 
            this.gbn.AutoSize = true;
            this.gbn.Location = new System.Drawing.Point(159, 40);
            this.gbn.Name = "gbn";
            this.gbn.Size = new System.Drawing.Size(48, 17);
            this.gbn.TabIndex = 1;
            this.gbn.TabStop = true;
            this.gbn.Text = "GBN";
            this.gbn.UseVisualStyleBackColor = true;
            // 
            // selectiveRepeat
            // 
            this.selectiveRepeat.AutoSize = true;
            this.selectiveRepeat.Location = new System.Drawing.Point(7, 40);
            this.selectiveRepeat.Name = "selectiveRepeat";
            this.selectiveRepeat.Size = new System.Drawing.Size(107, 17);
            this.selectiveRepeat.TabIndex = 0;
            this.selectiveRepeat.TabStop = true;
            this.selectiveRepeat.Text = "Selective Repeat";
            this.selectiveRepeat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.windowSizeTxt);
            this.groupBox2.Location = new System.Drawing.Point(390, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window Size";
            // 
            // windowSizeTxt
            // 
            this.windowSizeTxt.Location = new System.Drawing.Point(33, 31);
            this.windowSizeTxt.Name = "windowSizeTxt";
            this.windowSizeTxt.Size = new System.Drawing.Size(52, 20);
            this.windowSizeTxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(176, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 246);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Receive_lbl);
            this.groupBox5.Controls.Add(this.receivingTB);
            this.groupBox5.Location = new System.Drawing.Point(294, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 221);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receiver";
            // 
            // Receive_lbl
            // 
            this.Receive_lbl.AutoSize = true;
            this.Receive_lbl.Location = new System.Drawing.Point(6, 16);
            this.Receive_lbl.Name = "Receive_lbl";
            this.Receive_lbl.Size = new System.Drawing.Size(58, 13);
            this.Receive_lbl.TabIndex = 3;
            this.Receive_lbl.Text = "Receiving ";
            // 
            // receivingTB
            // 
            this.receivingTB.Location = new System.Drawing.Point(0, 36);
            this.receivingTB.Name = "receivingTB";
            this.receivingTB.Size = new System.Drawing.Size(205, 179);
            this.receivingTB.TabIndex = 1;
            this.receivingTB.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Send_lbl);
            this.groupBox4.Controls.Add(this.sendingTB);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 221);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sender ";
            // 
            // Send_lbl
            // 
            this.Send_lbl.AutoSize = true;
            this.Send_lbl.Location = new System.Drawing.Point(6, 16);
            this.Send_lbl.Name = "Send_lbl";
            this.Send_lbl.Size = new System.Drawing.Size(49, 13);
            this.Send_lbl.TabIndex = 2;
            this.Send_lbl.Text = "Sending ";
            // 
            // sendingTB
            // 
            this.sendingTB.Location = new System.Drawing.Point(9, 36);
            this.sendingTB.Name = "sendingTB";
            this.sendingTB.Size = new System.Drawing.Size(185, 179);
            this.sendingTB.TabIndex = 0;
            this.sendingTB.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.logTB);
            this.groupBox6.Location = new System.Drawing.Point(23, 450);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 149);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Log";
            // 
            // logTB
            // 
            this.logTB.Location = new System.Drawing.Point(7, 20);
            this.logTB.Name = "logTB";
            this.logTB.Size = new System.Drawing.Size(187, 123);
            this.logTB.TabIndex = 0;
            this.logTB.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.timerLbl2);
            this.groupBox7.Controls.Add(this.timerLbl);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.totalSuccessLbl);
            this.groupBox7.Controls.Add(this.totalErrorLbl);
            this.groupBox7.Controls.Add(this.totalSentLbl);
            this.groupBox7.Location = new System.Drawing.Point(641, 459);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(240, 140);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Info";
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Location = new System.Drawing.Point(55, 103);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(0, 13);
            this.timerLbl.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(102, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(76, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(76, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Timer :";
            // 
            // totalSuccessLbl
            // 
            this.totalSuccessLbl.AutoSize = true;
            this.totalSuccessLbl.ForeColor = System.Drawing.Color.Green;
            this.totalSuccessLbl.Location = new System.Drawing.Point(7, 44);
            this.totalSuccessLbl.Name = "totalSuccessLbl";
            this.totalSuccessLbl.Size = new System.Drawing.Size(89, 13);
            this.totalSuccessLbl.TabIndex = 2;
            this.totalSuccessLbl.Text = "Total Succesfull :";
            // 
            // totalErrorLbl
            // 
            this.totalErrorLbl.AutoSize = true;
            this.totalErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.totalErrorLbl.Location = new System.Drawing.Point(7, 74);
            this.totalErrorLbl.Name = "totalErrorLbl";
            this.totalErrorLbl.Size = new System.Drawing.Size(62, 13);
            this.totalErrorLbl.TabIndex = 1;
            this.totalErrorLbl.Text = "Total Error :";
            // 
            // totalSentLbl
            // 
            this.totalSentLbl.AutoSize = true;
            this.totalSentLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalSentLbl.Location = new System.Drawing.Point(7, 20);
            this.totalSentLbl.Name = "totalSentLbl";
            this.totalSentLbl.Size = new System.Drawing.Size(62, 13);
            this.totalSentLbl.TabIndex = 0;
            this.totalSentLbl.Text = "Total Sent :";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(378, 483);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(97, 33);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.start);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(378, 533);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(97, 33);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.reset);
            // 
            // timerLbl2
            // 
            this.timerLbl2.AutoSize = true;
            this.timerLbl2.Location = new System.Drawing.Point(54, 103);
            this.timerLbl2.Name = "timerLbl2";
            this.timerLbl2.Size = new System.Drawing.Size(13, 13);
            this.timerLbl2.TabIndex = 8;
            this.timerLbl2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 611);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CN1-Prj";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton gbn;
        private System.Windows.Forms.RadioButton selectiveRepeat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox windowSizeTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Send_lbl;
        private System.Windows.Forms.RichTextBox sendingTB;
        private System.Windows.Forms.Label Receive_lbl;
        private System.Windows.Forms.RichTextBox receivingTB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox logTB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalSuccessLbl;
        private System.Windows.Forms.Label totalErrorLbl;
        private System.Windows.Forms.Label totalSentLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label timerLbl2;
    }
}

