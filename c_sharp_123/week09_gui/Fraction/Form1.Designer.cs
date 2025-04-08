using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fraction
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFTop = new System.Windows.Forms.TextBox();
            this.tbFDown = new System.Windows.Forms.TextBox();
            this.tbSDown = new System.Windows.Forms.TextBox();
            this.tbSTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRDown = new System.Windows.Forms.TextBox();
            this.tbRTop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPO = new System.Windows.Forms.Button();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoMul = new System.Windows.Forms.RadioButton();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblFirst.Location = new System.Drawing.Point(40, 63);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(70, 24);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(95, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // tbFTop
            // 
            this.tbFTop.Location = new System.Drawing.Point(44, 97);
            this.tbFTop.Name = "tbFTop";
            this.tbFTop.Size = new System.Drawing.Size(48, 28);
            this.tbFTop.TabIndex = 0;
            // 
            // tbFDown
            // 
            this.tbFDown.Location = new System.Drawing.Point(118, 97);
            this.tbFDown.Name = "tbFDown";
            this.tbFDown.Size = new System.Drawing.Size(48, 28);
            this.tbFDown.TabIndex = 1;
            // 
            // tbSDown
            // 
            this.tbSDown.Location = new System.Drawing.Point(377, 97);
            this.tbSDown.Name = "tbSDown";
            this.tbSDown.Size = new System.Drawing.Size(48, 28);
            this.tbSDown.TabIndex = 7;
            // 
            // tbSTop
            // 
            this.tbSTop.Location = new System.Drawing.Point(300, 97);
            this.tbSTop.Name = "tbSTop";
            this.tbSTop.Size = new System.Drawing.Size(48, 28);
            this.tbSTop.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(354, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F);
            this.label3.Location = new System.Drawing.Point(296, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F);
            this.label4.Location = new System.Drawing.Point(452, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "=";
            // 
            // tbRDown
            // 
            this.tbRDown.Enabled = false;
            this.tbRDown.Location = new System.Drawing.Point(591, 98);
            this.tbRDown.Name = "tbRDown";
            this.tbRDown.Size = new System.Drawing.Size(48, 28);
            this.tbRDown.TabIndex = 10;
            this.tbRDown.TabStop = false;
            // 
            // tbRTop
            // 
            this.tbRTop.Enabled = false;
            this.tbRTop.Location = new System.Drawing.Point(506, 97);
            this.tbRTop.Name = "tbRTop";
            this.tbRTop.Size = new System.Drawing.Size(48, 28);
            this.tbRTop.TabIndex = 9;
            this.tbRTop.TabStop = false;
            this.tbRTop.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F);
            this.label5.Location = new System.Drawing.Point(563, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F);
            this.label6.Location = new System.Drawing.Point(502, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Result";
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(39, 207);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(600, 48);
            this.btnPO.TabIndex = 8;
            this.btnPO.Text = "Perform Operation";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(24, 12);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(42, 22);
            this.rdoAdd.TabIndex = 2;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "+";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Location = new System.Drawing.Point(24, 40);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(42, 22);
            this.rdoSub.TabIndex = 3;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "-";
            this.rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoMul
            // 
            this.rdoMul.AutoSize = true;
            this.rdoMul.Location = new System.Drawing.Point(24, 68);
            this.rdoMul.Name = "rdoMul";
            this.rdoMul.Size = new System.Drawing.Size(42, 22);
            this.rdoMul.TabIndex = 4;
            this.rdoMul.TabStop = true;
            this.rdoMul.Text = "*";
            this.rdoMul.UseVisualStyleBackColor = true;
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Location = new System.Drawing.Point(24, 96);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(42, 22);
            this.rdoDiv.TabIndex = 5;
            this.rdoDiv.TabStop = true;
            this.rdoDiv.Text = "/";
            this.rdoDiv.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoDiv);
            this.panel1.Controls.Add(this.rdoAdd);
            this.panel1.Controls.Add(this.rdoSub);
            this.panel1.Controls.Add(this.rdoMul);
            this.panel1.Location = new System.Drawing.Point(183, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 141);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPO);
            this.Controls.Add(this.tbRDown);
            this.Controls.Add(this.tbRTop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSDown);
            this.Controls.Add(this.tbSTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFDown);
            this.Controls.Add(this.tbFTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFTop;
        private System.Windows.Forms.TextBox tbFDown;
        private System.Windows.Forms.TextBox tbSDown;
        private System.Windows.Forms.TextBox tbSTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRDown;
        private System.Windows.Forms.TextBox tbRTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.RadioButton rdoMul;
        private System.Windows.Forms.RadioButton rdoDiv;
        private Panel panel1;
    }
}

