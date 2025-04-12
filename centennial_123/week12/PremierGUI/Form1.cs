using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PremierGUI
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers;
        public Form1()
        {
            InitializeComponent();
            InitializeGui();

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void InitializeGui()
        {
            premiers = new Dictionary<string, Premier>();
            List<Premier> premierList = Premier.GetPremiers();
            foreach(Premier item in premierList)
            {
                premiers.Add(item.Key, item);
                lsbNameList.Items.Add(item.Key);
            }

            lsbNameList.DataSource = premiers.Keys.ToList();


        }

        public void ShowPremier(string key) {
            lbName.Text = premiers[key].Name + premiers[key].Life;
            lblYears.Text = $"Office from {premiers[key].Start} to {premiers[key].End}";
            lblDescription.Text = premiers[key].Constituent;
            lblParty.Text = premiers[key].Party;
            picPerson.ImageLocation = $"images\\{key}.jpg";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lsbNameList.SelectedValue.ToString());
            ShowPremier(lsbNameList.SelectedValue.ToString());
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e) {
            Console.WriteLine("hi");
            MessageBox.Show("hi");
            ShowPremier(lsbNameList.SelectedValue.ToString());
                }
        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
