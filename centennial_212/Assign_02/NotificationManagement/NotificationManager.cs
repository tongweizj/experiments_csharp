using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagement
{
    public partial class NotificationManager : Form
    {
        public delegate void NavgateHandler(Type formType);
        public NotificationManager()
        {
            InitializeComponent();
            lbWelcome.Text = "Welcome to the Notification Manager System!" +
                "\r\n\r\nGet started here:" +
                "\r\n\r\nPublish Notification: Send important messages to your users." +
                "\r\n\r\nManage Subscription: Set user preferences for receiving notifications.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ManageSub newForm = new ManageSub(this);
            ManageSub newForm = new ManageSub(HandleNavigation);
            this.Hide();
            newForm.ShowDialog();
        }
        private void HandleNavigation(Type formType)
        {
            // close all form
            foreach(var form in MdiChildren) form.Close();
            // create new form
            var newForm = (Form)Activator.CreateInstance(formType);
            //newForm.MdiParent = this;
            newForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PublishNotification newPublish = new PublishNotification(HandleNavigation);
            this.Hide();
            newPublish.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NotificationManager_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
