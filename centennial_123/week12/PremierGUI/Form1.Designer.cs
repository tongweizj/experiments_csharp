namespace PremierGUI
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
            this.lsbNameList = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.Label();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbNameList
            // 
            this.lsbNameList.FormattingEnabled = true;
            this.lsbNameList.ItemHeight = 18;
            this.lsbNameList.Location = new System.Drawing.Point(520, 0);
            this.lsbNameList.Name = "lsbNameList";
            this.lsbNameList.Size = new System.Drawing.Size(259, 544);
            this.lsbNameList.TabIndex = 0;
            this.lsbNameList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 24);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // picPerson
            // 
            this.picPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPerson.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPerson.InitialImage")));
            this.picPerson.Location = new System.Drawing.Point(155, 101);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(200, 250);
            this.picPerson.TabIndex = 2;
            this.picPerson.TabStop = false;
            this.picPerson.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 435);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(107, 18);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(16, 405);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(53, 18);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "Years";
            this.lblYears.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(16, 465);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(62, 18);
            this.lblParty.TabIndex = 5;
            this.lblParty.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picPerson);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lsbNameList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbNameList;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblParty;
    }
}

