using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBox.Checked)
            {
                lblBox.Text = "Checked";
            }
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setting the text property at runtime
            
            MessageBox.Show($"You have selected {(string)cmbBox.SelectedItem} ");
            // cmbBox.DisplayMember = 

        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBox.DataSource 					//setting all the items at once
  = new string[] { "Breakfast", "Lunch", "Dinner" };

        }
    }
}
