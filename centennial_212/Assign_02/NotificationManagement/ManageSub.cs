using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotificationManagement
{
    public partial class ManageSub : Form
    {
        private readonly NotificationManager.NavgateHandler _navigate;
        
        List<string> subList = new List<string>();

        public ManageSub(NotificationManager.NavgateHandler navgateHandler)
        {
            InitializeComponent();
            _navigate = navgateHandler;
            lbEmail.Text = string.Empty;
            lbSMS.Text = string.Empty;
            changeBtnStatus();
        }
        private void changeBtnStatus()
        {
            if (chkEmailSubscription.Checked || chkSMSSubscription.Checked)
            {
                btnSub.Enabled = true;
                btnUnSub.Enabled = true;
            }
            else
            {
                btnSub.Enabled = false;
                btnUnSub.Enabled = false;
            }
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbEmail.Enabled = true;
            changeBtnStatus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Regex regEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if(chkEmailSubscription.Checked == true)
            {
                if (!regEmail.IsMatch(tbEmail.Text) || tbEmail.Text == "name@email.com")
                {
                    lbEmail.Text = "Invalide email address!";
                    lbEmail.ForeColor = Color.Red;
                    //return "Email地址形式上就不对";
                }else if (subList.Contains(tbEmail.Text))
                {
                    lbEmail.Text = "Duplicate email address!";
                    lbEmail.ForeColor = Color.Red;
                }
                else
                {
                    subList.Add(tbEmail.Text);
                    lbEmail.Text = "Email address subsribe successful!";
                    lbEmail.ForeColor = Color.Blue;
                }
            }
           
            Regex regSMS = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            if(chkSMSSubscription.Checked == true)
            {
                bool x = regSMS.IsMatch(tbSMS.Text);
                if (!regSMS.IsMatch(tbSMS.Text)||tbSMS.Text == "888-888-8888")
                {
                    lbSMS.Text = "Invalide mobile number!";
                    lbSMS.ForeColor = Color.Red;
                    //return "Email地址形式上就不对";
                }else if (subList.Contains(tbSMS.Text))
                {
                    lbSMS.Text = "Duplicate mobile number!";
                    lbSMS.ForeColor = Color.Red;
                }
                else 
                {
                    subList.Add(tbSMS.Text);
                    lbSMS.Text = "Mobile number subsribe successful!";
                    lbSMS.ForeColor = Color.Blue;
                }
            }


        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {

            _navigate?.Invoke(typeof(NotificationManager));
            this.Close();
        }

        private void chkSMSSubscription_CheckedChanged(object sender, EventArgs e)
        {
            tbSMS.Enabled = true;
            changeBtnStatus();
        }

        private void tbSMS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnUnSub_Click(object sender, EventArgs e)
        {
            if (chkEmailSubscription.Checked == true)
            {
                if (tbEmail.Text.Length == 0)
                {
                    lbEmail.Text = "Invalide email address!";
                    lbEmail.ForeColor = Color.Red;
                    //return "Email地址形式上就不对";
                }
                else if (!subList.Contains(tbEmail.Text))
                {
                    lbEmail.Text = "This email did not subscribe!";
                    lbEmail.ForeColor = Color.Red;
                }
                else
                {
                    subList.Remove(tbEmail.Text);
                    lbEmail.Text = "Email address unsubsribe successful!";
                    lbEmail.ForeColor = Color.Blue;
                }
            }
            if (chkSMSSubscription.Checked == true)
            {
                if (tbSMS.Text.Length == 0)
                {
                    lbSMS.Text = "Invalide mobile number!";
                    lbSMS.ForeColor = Color.Red;
                    //return "Email地址形式上就不对";
                }
                else if (!subList.Contains(tbSMS.Text))
                {
                    lbSMS.Text = "This mobile number did not subscribe!";
                    lbSMS.ForeColor = Color.Red;
                }
                else
                {
                    subList.Remove(tbSMS.Text);
                    lbSMS.Text = "Mobile number unsubsribe successful!";
                    lbSMS.ForeColor = Color.Blue;
                }
            }
        }
    }
}
