namespace NotificationManagement
{
    partial class NotificationManager
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
            this.ManageSub = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManageSub
            // 
            this.ManageSub.Location = new System.Drawing.Point(39, 277);
            this.ManageSub.Name = "ManageSub";
            this.ManageSub.Size = new System.Drawing.Size(300, 80);
            this.ManageSub.TabIndex = 0;
            this.ManageSub.Text = "Manage Subscription";
            this.ManageSub.UseVisualStyleBackColor = true;
            this.ManageSub.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Publish Notification";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(756, 277);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 80);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(39, 34);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(166, 24);
            this.lbWelcome.TabIndex = 3;
            this.lbWelcome.Text = "Welcome Lable";
            this.lbWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // NotificationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 429);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ManageSub);
            this.Name = "NotificationManager";
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.NotificationManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageSub;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lbWelcome;
    }
}

