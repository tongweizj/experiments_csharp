namespace NotificationManagement
{
    partial class PublishNotification
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(80, 75);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(800, 180);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(80, 320);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(200, 80);
            this.btnPublish.TabIndex = 6;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(680, 320);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 80);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(76, 281);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(250, 24);
            this.lbMessage.TabIndex = 8;
            this.lbMessage.Text = "Notification Content";
            this.lbMessage.Click += new System.EventHandler(this.label2_Click);
            // 
            // PublishNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 429);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label1);
            this.Name = "PublishNotification";
            this.Text = "PublishNotification";
            this.Load += new System.EventHandler(this.PublishNotification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lbMessage;
    }
}