namespace Pinger
{
    partial class Pinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pinger));
            this._IPBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this._PingDelayBox = new System.Windows.Forms.TextBox();
            this.PingDelayLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.LiveLabel = new System.Windows.Forms.Label();
            this.RespondingLabel = new System.Windows.Forms.Label();
            this.respondingStatus = new System.Windows.Forms.PictureBox();
            this.liveStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.respondingStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // _IPBox
            // 
            this._IPBox.Location = new System.Drawing.Point(15, 45);
            this._IPBox.Name = "_IPBox";
            this._IPBox.Size = new System.Drawing.Size(245, 20);
            this._IPBox.TabIndex = 0;
            this._IPBox.Text = "127.0.0.1";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(12, 19);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(55, 13);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP-Adress:";
            // 
            // _PingDelayBox
            // 
            this._PingDelayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._PingDelayBox.Location = new System.Drawing.Point(15, 102);
            this._PingDelayBox.Name = "_PingDelayBox";
            this._PingDelayBox.Size = new System.Drawing.Size(52, 20);
            this._PingDelayBox.TabIndex = 2;
            this._PingDelayBox.Text = "2";
            this._PingDelayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PingDelayLabel
            // 
            this.PingDelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PingDelayLabel.AutoSize = true;
            this.PingDelayLabel.Location = new System.Drawing.Point(12, 76);
            this.PingDelayLabel.Name = "PingDelayLabel";
            this.PingDelayLabel.Size = new System.Drawing.Size(87, 13);
            this.PingDelayLabel.TabIndex = 3;
            this.PingDelayLabel.Text = "Ping Delay (sec):";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(267, 99);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(70, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelayBox
            // 
            this.DelayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayBox.Location = new System.Drawing.Point(267, 45);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.ReadOnly = true;
            this.DelayBox.Size = new System.Drawing.Size(70, 20);
            this.DelayBox.TabIndex = 5;
            this.DelayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DelayLabel
            // 
            this.DelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(278, 19);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(59, 13);
            this.DelayLabel.TabIndex = 6;
            this.DelayLabel.Text = "Delay (ms):";
            // 
            // LiveLabel
            // 
            this.LiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveLabel.AutoSize = true;
            this.LiveLabel.Location = new System.Drawing.Point(213, 105);
            this.LiveLabel.Name = "LiveLabel";
            this.LiveLabel.Size = new System.Drawing.Size(30, 13);
            this.LiveLabel.TabIndex = 8;
            this.LiveLabel.Text = "Live:";
            // 
            // RespondingLabel
            // 
            this.RespondingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RespondingLabel.AutoSize = true;
            this.RespondingLabel.Location = new System.Drawing.Point(176, 19);
            this.RespondingLabel.Name = "RespondingLabel";
            this.RespondingLabel.Size = new System.Drawing.Size(67, 13);
            this.RespondingLabel.TabIndex = 10;
            this.RespondingLabel.Text = "Responding:";
            // 
            // respondingStatus
            // 
            this.respondingStatus.Image = global::Pinger.Properties.Resources.IMGstatusNeutral;
            this.respondingStatus.Location = new System.Drawing.Point(244, 19);
            this.respondingStatus.Name = "respondingStatus";
            this.respondingStatus.Size = new System.Drawing.Size(16, 16);
            this.respondingStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.respondingStatus.TabIndex = 11;
            this.respondingStatus.TabStop = false;
            // 
            // liveStatus
            // 
            this.liveStatus.Image = global::Pinger.Properties.Resources.IMGstatusNeutral;
            this.liveStatus.Location = new System.Drawing.Point(244, 104);
            this.liveStatus.Name = "liveStatus";
            this.liveStatus.Size = new System.Drawing.Size(16, 16);
            this.liveStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liveStatus.TabIndex = 12;
            this.liveStatus.TabStop = false;
            // 
            // Pinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 138);
            this.Controls.Add(this.liveStatus);
            this.Controls.Add(this.respondingStatus);
            this.Controls.Add(this.RespondingLabel);
            this.Controls.Add(this.LiveLabel);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.DelayBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PingDelayLabel);
            this.Controls.Add(this._PingDelayBox);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this._IPBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 177);
            this.MinimumSize = new System.Drawing.Size(371, 177);
            this.Name = "Pinger";
            this.Text = "Pinger";
            this.Load += new System.EventHandler(this.Pinger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.respondingStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _IPBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox _PingDelayBox;
        private System.Windows.Forms.Label PingDelayLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.Label LiveLabel;
        private System.Windows.Forms.Label RespondingLabel;
        private System.Windows.Forms.PictureBox respondingStatus;
        private System.Windows.Forms.PictureBox liveStatus;
    }
}

