namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.ofd2 = new System.Windows.Forms.OpenFileDialog();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBotToken = new System.Windows.Forms.TextBox();
            this.txtDiscHPID = new System.Windows.Forms.TextBox();
            this.txtMonDelay = new System.Windows.Forms.TextBox();
            this.txtDiscLPID = new System.Windows.Forms.TextBox();
            this.txtMonScrpAmnt = new System.Windows.Forms.TextBox();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.txtMonIndexAmnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDisc = new System.Windows.Forms.TabPage();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnDiscClear = new System.Windows.Forms.Button();
            this.txtChannelID = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rtbDisc = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDisc = new System.Windows.Forms.ComboBox();
            this.btnDiscStop = new System.Windows.Forms.Button();
            this.btnDiscStart = new System.Windows.Forms.Button();
            this.tbMon = new System.Windows.Forms.TabPage();
            this.btnWebsel = new System.Windows.Forms.Button();
            this.btnWebpop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlWeb = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.rtbM = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSettings.SuspendLayout();
            this.tbDisc.SuspendLayout();
            this.tbMon.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // ofd2
            // 
            this.ofd2.FileName = "openFileDialog1";
            // 
            // tbSettings
            // 
            this.tbSettings.Controls.Add(this.label13);
            this.tbSettings.Controls.Add(this.txtBotToken);
            this.tbSettings.Controls.Add(this.txtDiscHPID);
            this.tbSettings.Controls.Add(this.txtMonDelay);
            this.tbSettings.Controls.Add(this.txtDiscLPID);
            this.tbSettings.Controls.Add(this.txtMonScrpAmnt);
            this.tbSettings.Controls.Add(this.txtGID);
            this.tbSettings.Controls.Add(this.txtMonIndexAmnt);
            this.tbSettings.Controls.Add(this.label4);
            this.tbSettings.Controls.Add(this.label14);
            this.tbSettings.Controls.Add(this.label24);
            this.tbSettings.Controls.Add(this.label15);
            this.tbSettings.Controls.Add(this.label1);
            this.tbSettings.Controls.Add(this.label23);
            this.tbSettings.Controls.Add(this.label6);
            this.tbSettings.Controls.Add(this.label5);
            this.tbSettings.Location = new System.Drawing.Point(4, 22);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(702, 496);
            this.tbSettings.TabIndex = 3;
            this.tbSettings.Text = "Settings";
            this.tbSettings.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(372, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Discord Bot Token:";
            // 
            // txtBotToken
            // 
            this.txtBotToken.BackColor = System.Drawing.Color.Black;
            this.txtBotToken.Location = new System.Drawing.Point(372, 66);
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.Size = new System.Drawing.Size(296, 20);
            this.txtBotToken.TabIndex = 0;
            this.txtBotToken.Tag = "discBotToken";
            this.txtBotToken.TextChanged += new System.EventHandler(this.settingsHelper);
            this.txtBotToken.MouseLeave += new System.EventHandler(this.txtBotToken_MouseLeave);
            this.txtBotToken.MouseHover += new System.EventHandler(this.txtBotToken_MouseHover);
            // 
            // txtDiscHPID
            // 
            this.txtDiscHPID.Location = new System.Drawing.Point(372, 111);
            this.txtDiscHPID.Name = "txtDiscHPID";
            this.txtDiscHPID.Size = new System.Drawing.Size(225, 20);
            this.txtDiscHPID.TabIndex = 3;
            this.txtDiscHPID.Tag = "discHPID";
            this.txtDiscHPID.TextChanged += new System.EventHandler(this.settingsHelper);
            // 
            // txtMonDelay
            // 
            this.txtMonDelay.Location = new System.Drawing.Point(32, 66);
            this.txtMonDelay.Name = "txtMonDelay";
            this.txtMonDelay.Size = new System.Drawing.Size(69, 20);
            this.txtMonDelay.TabIndex = 0;
            this.txtMonDelay.Tag = "monDelay";
            this.txtMonDelay.TextChanged += new System.EventHandler(this.settingsHelper);
            // 
            // txtDiscLPID
            // 
            this.txtDiscLPID.Location = new System.Drawing.Point(372, 156);
            this.txtDiscLPID.Name = "txtDiscLPID";
            this.txtDiscLPID.Size = new System.Drawing.Size(225, 20);
            this.txtDiscLPID.TabIndex = 5;
            this.txtDiscLPID.Tag = "discLPID";
            this.txtDiscLPID.TextChanged += new System.EventHandler(this.settingsHelper);
            // 
            // txtMonScrpAmnt
            // 
            this.txtMonScrpAmnt.Location = new System.Drawing.Point(32, 111);
            this.txtMonScrpAmnt.Name = "txtMonScrpAmnt";
            this.txtMonScrpAmnt.Size = new System.Drawing.Size(69, 20);
            this.txtMonScrpAmnt.TabIndex = 3;
            this.txtMonScrpAmnt.Tag = "monScrpAmnt";
            this.txtMonScrpAmnt.TextChanged += new System.EventHandler(this.settingsHelper);
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(372, 201);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(225, 20);
            this.txtGID.TabIndex = 7;
            this.txtGID.Tag = "discGID";
            this.txtGID.TextChanged += new System.EventHandler(this.settingsHelper);
            // 
            // txtMonIndexAmnt
            // 
            this.txtMonIndexAmnt.Location = new System.Drawing.Point(32, 156);
            this.txtMonIndexAmnt.Name = "txtMonIndexAmnt";
            this.txtMonIndexAmnt.Size = new System.Drawing.Size(69, 20);
            this.txtMonIndexAmnt.TabIndex = 5;
            this.txtMonIndexAmnt.Tag = "monIndexAmnt";
            this.txtMonIndexAmnt.TextChanged += new System.EventHandler(this.settingsHelper);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delay:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(372, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "High Priority Channel ID:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(360, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 24);
            this.label24.TabIndex = 23;
            this.label24.Text = "Discord:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(372, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Low Priority Channel ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scrape\'s per Proxy:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 24);
            this.label23.TabIndex = 22;
            this.label23.Text = "Monitor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "General Channel ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Index Amount:";
            // 
            // tbDisc
            // 
            this.tbDisc.Controls.Add(this.btnSendMsg);
            this.tbDisc.Controls.Add(this.btnDiscClear);
            this.tbDisc.Controls.Add(this.txtChannelID);
            this.tbDisc.Controls.Add(this.txtMessage);
            this.tbDisc.Controls.Add(this.rtbDisc);
            this.tbDisc.Controls.Add(this.label8);
            this.tbDisc.Controls.Add(this.label7);
            this.tbDisc.Controls.Add(this.cbDisc);
            this.tbDisc.Controls.Add(this.btnDiscStop);
            this.tbDisc.Controls.Add(this.btnDiscStart);
            this.tbDisc.Location = new System.Drawing.Point(4, 22);
            this.tbDisc.Name = "tbDisc";
            this.tbDisc.Padding = new System.Windows.Forms.Padding(3);
            this.tbDisc.Size = new System.Drawing.Size(702, 496);
            this.tbDisc.TabIndex = 1;
            this.tbDisc.Text = "Discord Bot";
            this.tbDisc.UseVisualStyleBackColor = true;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(631, 450);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(68, 20);
            this.btnSendMsg.TabIndex = 10;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnDiscClear
            // 
            this.btnDiscClear.Location = new System.Drawing.Point(168, 6);
            this.btnDiscClear.Name = "btnDiscClear";
            this.btnDiscClear.Size = new System.Drawing.Size(75, 23);
            this.btnDiscClear.TabIndex = 9;
            this.btnDiscClear.Text = "Clear";
            this.btnDiscClear.UseVisualStyleBackColor = true;
            this.btnDiscClear.Click += new System.EventHandler(this.btnDiscClear_Click);
            // 
            // txtChannelID
            // 
            this.txtChannelID.BackColor = System.Drawing.Color.White;
            this.txtChannelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannelID.ForeColor = System.Drawing.Color.Black;
            this.txtChannelID.Location = new System.Drawing.Point(113, 473);
            this.txtChannelID.MinimumSize = new System.Drawing.Size(40, 20);
            this.txtChannelID.Name = "txtChannelID";
            this.txtChannelID.Size = new System.Drawing.Size(147, 20);
            this.txtChannelID.TabIndex = 8;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.Location = new System.Drawing.Point(183, 450);
            this.txtMessage.MinimumSize = new System.Drawing.Size(40, 20);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(448, 20);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // rtbDisc
            // 
            this.rtbDisc.BackColor = System.Drawing.Color.Black;
            this.rtbDisc.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rtbDisc.Location = new System.Drawing.Point(4, 35);
            this.rtbDisc.Name = "rtbDisc";
            this.rtbDisc.ReadOnly = true;
            this.rtbDisc.Size = new System.Drawing.Size(695, 411);
            this.rtbDisc.TabIndex = 3;
            this.rtbDisc.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Custom Channel ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Send a Message:";
            // 
            // cbDisc
            // 
            this.cbDisc.BackColor = System.Drawing.Color.White;
            this.cbDisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDisc.ForeColor = System.Drawing.Color.Black;
            this.cbDisc.FormattingEnabled = true;
            this.cbDisc.Items.AddRange(new object[] {
            "General",
            "High Priority",
            "Low Priority",
            "Custom"});
            this.cbDisc.Location = new System.Drawing.Point(98, 449);
            this.cbDisc.Name = "cbDisc";
            this.cbDisc.Size = new System.Drawing.Size(82, 21);
            this.cbDisc.TabIndex = 5;
            // 
            // btnDiscStop
            // 
            this.btnDiscStop.Location = new System.Drawing.Point(87, 6);
            this.btnDiscStop.Name = "btnDiscStop";
            this.btnDiscStop.Size = new System.Drawing.Size(75, 23);
            this.btnDiscStop.TabIndex = 2;
            this.btnDiscStop.Text = "Stop";
            this.btnDiscStop.UseVisualStyleBackColor = true;
            this.btnDiscStop.Click += new System.EventHandler(this.btnDiscStop_Click);
            // 
            // btnDiscStart
            // 
            this.btnDiscStart.Location = new System.Drawing.Point(6, 6);
            this.btnDiscStart.Name = "btnDiscStart";
            this.btnDiscStart.Size = new System.Drawing.Size(75, 23);
            this.btnDiscStart.TabIndex = 0;
            this.btnDiscStart.Text = "Start";
            this.btnDiscStart.UseVisualStyleBackColor = true;
            this.btnDiscStart.Click += new System.EventHandler(this.btnDiscStart_Click);
            // 
            // tbMon
            // 
            this.tbMon.Controls.Add(this.btnWebsel);
            this.tbMon.Controls.Add(this.btnWebpop);
            this.tbMon.Controls.Add(this.label2);
            this.tbMon.Controls.Add(this.pnlWeb);
            this.tbMon.Controls.Add(this.label3);
            this.tbMon.Controls.Add(this.btnClr);
            this.tbMon.Controls.Add(this.cbAuto);
            this.tbMon.Controls.Add(this.rtbM);
            this.tbMon.Controls.Add(this.btnStop);
            this.tbMon.Controls.Add(this.btnRun);
            this.tbMon.Location = new System.Drawing.Point(4, 22);
            this.tbMon.Name = "tbMon";
            this.tbMon.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.tbMon.Size = new System.Drawing.Size(702, 496);
            this.tbMon.TabIndex = 0;
            this.tbMon.Text = "Monitor";
            this.tbMon.UseVisualStyleBackColor = true;
            // 
            // btnWebsel
            // 
            this.btnWebsel.Location = new System.Drawing.Point(625, 464);
            this.btnWebsel.Name = "btnWebsel";
            this.btnWebsel.Size = new System.Drawing.Size(70, 21);
            this.btnWebsel.TabIndex = 17;
            this.btnWebsel.Text = "Select All";
            this.btnWebsel.UseVisualStyleBackColor = true;
            this.btnWebsel.Click += new System.EventHandler(this.btnWebsel_Click);
            // 
            // btnWebpop
            // 
            this.btnWebpop.Location = new System.Drawing.Point(544, 464);
            this.btnWebpop.Name = "btnWebpop";
            this.btnWebpop.Size = new System.Drawing.Size(75, 21);
            this.btnWebpop.TabIndex = 16;
            this.btnWebpop.Text = "Refresh";
            this.btnWebpop.UseVisualStyleBackColor = true;
            this.btnWebpop.Click += new System.EventHandler(this.btnWebpop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Monitor Logs:";
            // 
            // pnlWeb
            // 
            this.pnlWeb.FormattingEnabled = true;
            this.pnlWeb.Location = new System.Drawing.Point(544, 32);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(154, 424);
            this.pnlWeb.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Websites:";
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(104, 457);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(89, 34);
            this.btnClr.TabIndex = 7;
            this.btnClr.Text = "clear!";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(315, 467);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(77, 17);
            this.cbAuto.TabIndex = 10;
            this.cbAuto.Text = "Auto Scroll";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // rtbM
            // 
            this.rtbM.BackColor = System.Drawing.Color.Black;
            this.rtbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbM.ForeColor = System.Drawing.Color.Lime;
            this.rtbM.Location = new System.Drawing.Point(3, 32);
            this.rtbM.Name = "rtbM";
            this.rtbM.ReadOnly = true;
            this.rtbM.Size = new System.Drawing.Size(535, 419);
            this.rtbM.TabIndex = 0;
            this.rtbM.Text = "";
            this.rtbM.TextChanged += new System.EventHandler(this.rtbM_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(199, 457);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 34);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(4, 457);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(94, 34);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "run!";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMon);
            this.tabControl1.Controls.Add(this.tbDisc);
            this.tabControl1.Controls.Add(this.tbSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 522);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 535);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbSettings.ResumeLayout(false);
            this.tbSettings.PerformLayout();
            this.tbDisc.ResumeLayout(false);
            this.tbDisc.PerformLayout();
            this.tbMon.ResumeLayout(false);
            this.tbMon.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.OpenFileDialog ofd2;
        private System.Windows.Forms.TabPage tbSettings;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBotToken;
        private System.Windows.Forms.TextBox txtDiscHPID;
        private System.Windows.Forms.TextBox txtMonDelay;
        private System.Windows.Forms.TextBox txtDiscLPID;
        private System.Windows.Forms.TextBox txtMonScrpAmnt;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.TextBox txtMonIndexAmnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbDisc;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnDiscClear;
        private System.Windows.Forms.TextBox txtChannelID;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox rtbDisc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDisc;
        private System.Windows.Forms.Button btnDiscStop;
        private System.Windows.Forms.Button btnDiscStart;
        private System.Windows.Forms.TabPage tbMon;
        private System.Windows.Forms.Button btnWebsel;
        private System.Windows.Forms.Button btnWebpop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox pnlWeb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.CheckBox cbAuto;
        public System.Windows.Forms.RichTextBox rtbM;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

