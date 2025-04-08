using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagement
{
   
    public partial class PublishNotification : Form
    {
        private readonly NotificationManager.NavgateHandler _navigate;
        public PublishNotification(NotificationManager.NavgateHandler navgateHandler)
        {
            InitializeComponent();
            _navigate = navgateHandler;
            lbMessage.Text = "Please write more than 20 words!";
            changeBtnStatus();
        }
        private void changeBtnStatus()
        {
            if (tbMessage.Text.Length>0)
            {
                btnPublish.Enabled = true;
            }
            else
            {
                btnPublish.Enabled = false;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
           
                if ( tbMessage.Text.Length <= 20)
                {
                    lbMessage.Text = "Notification content less then 10 words!";
                    lbMessage.ForeColor = Color.Red;
                }
                else
                {
                    lbMessage.Text = "Notification content publish successful!";
                    lbMessage.ForeColor = Color.Blue;
                }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            _navigate?.Invoke(typeof(NotificationManager));
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbMessage.Text = tbMessage.Text.Length + " words";
            lbMessage.ForeColor = Color.Blue;
            changeBtnStatus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PublishNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
