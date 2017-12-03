namespace KO.ServerListener
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxGameServer = new System.Windows.Forms.CheckBox();
            this.cbxLoginServer = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFrequency = new System.Windows.Forms.TextBox();
            this.tbxHostIp = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxLogger = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusGameServer = new System.Windows.Forms.Button();
            this.statusLoginServer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.cbxGameServer);
            this.panel2.Controls.Add(this.cbxLoginServer);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbxFrequency);
            this.panel2.Controls.Add(this.tbxHostIp);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbxLogger);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 189);
            this.panel2.TabIndex = 1;
            // 
            // cbxGameServer
            // 
            this.cbxGameServer.AutoSize = true;
            this.cbxGameServer.Location = new System.Drawing.Point(11, 162);
            this.cbxGameServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxGameServer.Name = "cbxGameServer";
            this.cbxGameServer.Size = new System.Drawing.Size(88, 17);
            this.cbxGameServer.TabIndex = 6;
            this.cbxGameServer.Text = "Game Server";
            this.cbxGameServer.UseVisualStyleBackColor = true;
            // 
            // cbxLoginServer
            // 
            this.cbxLoginServer.AutoSize = true;
            this.cbxLoginServer.Checked = true;
            this.cbxLoginServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLoginServer.Location = new System.Drawing.Point(11, 142);
            this.cbxLoginServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxLoginServer.Name = "cbxLoginServer";
            this.cbxLoginServer.Size = new System.Drawing.Size(86, 17);
            this.cbxLoginServer.TabIndex = 6;
            this.cbxLoginServer.Text = "Login Server";
            this.cbxLoginServer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "miliseconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alert When Available:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Check every:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Target Server IP:";
            // 
            // tbxFrequency
            // 
            this.tbxFrequency.Location = new System.Drawing.Point(11, 91);
            this.tbxFrequency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFrequency.Name = "tbxFrequency";
            this.tbxFrequency.Size = new System.Drawing.Size(32, 20);
            this.tbxFrequency.TabIndex = 2;
            this.tbxFrequency.Text = "2000";
            // 
            // tbxHostIp
            // 
            this.tbxHostIp.Location = new System.Drawing.Point(11, 41);
            this.tbxHostIp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxHostIp.Name = "tbxHostIp";
            this.tbxHostIp.Size = new System.Drawing.Size(93, 20);
            this.tbxHostIp.TabIndex = 3;
            this.tbxHostIp.Text = "147.135.254.165";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(514, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(42, 22);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(514, 94);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Listening";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(514, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Listening";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logger Information";
            // 
            // lbxLogger
            // 
            this.lbxLogger.FormattingEnabled = true;
            this.lbxLogger.Location = new System.Drawing.Point(140, 32);
            this.lbxLogger.Name = "lbxLogger";
            this.lbxLogger.Size = new System.Drawing.Size(369, 147);
            this.lbxLogger.TabIndex = 0;
            this.lbxLogger.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(216)))));
            this.panel1.BackgroundImage = global::KO.ServerListener.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.statusGameServer);
            this.panel1.Controls.Add(this.statusLoginServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 230);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Game Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(53, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login Server";
            // 
            // statusGameServer
            // 
            this.statusGameServer.BackColor = System.Drawing.Color.Red;
            this.statusGameServer.Enabled = false;
            this.statusGameServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusGameServer.Font = new System.Drawing.Font("Arial", 8.25F);
            this.statusGameServer.Location = new System.Drawing.Point(317, 122);
            this.statusGameServer.Name = "statusGameServer";
            this.statusGameServer.Size = new System.Drawing.Size(73, 23);
            this.statusGameServer.TabIndex = 0;
            this.statusGameServer.TabStop = false;
            this.statusGameServer.Text = "Offline";
            this.statusGameServer.UseVisualStyleBackColor = false;
            // 
            // statusLoginServer
            // 
            this.statusLoginServer.BackColor = System.Drawing.Color.Red;
            this.statusLoginServer.Enabled = false;
            this.statusLoginServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLoginServer.Font = new System.Drawing.Font("Arial", 8.25F);
            this.statusLoginServer.Location = new System.Drawing.Point(317, 90);
            this.statusLoginServer.Name = "statusLoginServer";
            this.statusLoginServer.Size = new System.Drawing.Size(73, 23);
            this.statusLoginServer.TabIndex = 0;
            this.statusLoginServer.TabStop = false;
            this.statusLoginServer.Text = "Offline";
            this.statusLoginServer.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(591, 437);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnightOnline Server Listener";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button statusGameServer;
        private System.Windows.Forms.Button statusLoginServer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbxLogger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxHostIp;
        private System.Windows.Forms.TextBox tbxFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxGameServer;
        private System.Windows.Forms.CheckBox cbxLoginServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
    }
}

