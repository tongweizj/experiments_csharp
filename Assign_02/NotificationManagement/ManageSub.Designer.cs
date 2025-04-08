namespace NotificationManagement
{
    partial class ManageSub
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
            this.chkEmailSubscription = new System.Windows.Forms.CheckBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.chkSMSSubscription = new System.Windows.Forms.CheckBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnUnSub = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.tbSMS = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkEmailSubscription
            // 
            this.chkEmailSubscription.AutoSize = true;
            this.chkEmailSubscription.Location = new System.Drawing.Point(44, 59);
            this.chkEmailSubscription.Name = "chkEmailSubscription";
            this.chkEmailSubscription.Size = new System.Drawing.Size(354, 28);
            this.chkEmailSubscription.TabIndex = 0;
            this.chkEmailSubscription.Text = "Notification Sent by Email";
            this.chkEmailSubscription.UseVisualStyleBackColor = true;
            this.chkEmailSubscription.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(424, 52);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(375, 35);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Text = "name@email.com";
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // chkSMSSubscription
            // 
            this.chkSMSSubscription.AutoSize = true;
            this.chkSMSSubscription.Location = new System.Drawing.Point(44, 161);
            this.chkSMSSubscription.Name = "chkSMSSubscription";
            this.chkSMSSubscription.Size = new System.Drawing.Size(330, 28);
            this.chkSMSSubscription.TabIndex = 2;
            this.chkSMSSubscription.Text = "Notification Sent by SMS";
            this.chkSMSSubscription.UseVisualStyleBackColor = true;
            this.chkSMSSubscription.CheckedChanged += new System.EventHandler(this.chkSMSSubscription_CheckedChanged);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(60, 284);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(200, 80);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "Subscribe";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUnSub
            // 
            this.btnUnSub.Location = new System.Drawing.Point(312, 284);
            this.btnUnSub.Name = "btnUnSub";
            this.btnUnSub.Size = new System.Drawing.Size(200, 80);
            this.btnUnSub.TabIndex = 6;
            this.btnUnSub.Text = "Unsubscribe";
            this.btnUnSub.UseVisualStyleBackColor = true;
            this.btnUnSub.Click += new System.EventHandler(this.btnUnSub_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(697, 284);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(200, 80);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // tbSMS
            // 
            this.tbSMS.Enabled = false;
            this.tbSMS.Location = new System.Drawing.Point(424, 159);
            this.tbSMS.Name = "tbSMS";
            this.tbSMS.Size = new System.Drawing.Size(375, 35);
            this.tbSMS.TabIndex = 8;
            this.tbSMS.Text = "888-888-8888";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbEmail.Location = new System.Drawing.Point(430, 108);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(82, 24);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "label1";
            // 
            // lbSMS
            // 
            this.lbSMS.AutoSize = true;
            this.lbSMS.Location = new System.Drawing.Point(430, 219);
            this.lbSMS.Name = "lbSMS";
            this.lbSMS.Size = new System.Drawing.Size(82, 24);
            this.lbSMS.TabIndex = 10;
            this.lbSMS.Text = "label2";
            // 
            // ManageSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 429);
            this.Controls.Add(this.lbSMS);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbSMS);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnUnSub);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.chkSMSSubscription);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.chkEmailSubscription);
            this.Name = "ManageSub";
            this.Text = "ManageSub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEmailSubscription;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.CheckBox chkSMSSubscription;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnUnSub;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox tbSMS;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSMS;
    }
}