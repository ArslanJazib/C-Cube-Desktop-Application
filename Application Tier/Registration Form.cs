using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entered_cnic = New_CNICbox.Text;
            string entered_name = New_Namebox.Text;
            bool validation=Player_Menu.Mgr.registerNewPlayer(entered_cnic,entered_name);
            if(validation==true)
            {
                MessageBox.Show("Player Registered Successfully","Successful",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Player already exists", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                New_CNICbox.Text = null;
                New_Namebox.Text = null;
            }
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void if_search_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Player_Menu.Mgr.exit();
        }

        private void GameHome_Click(object sender, EventArgs e)
        {
            Player_Menu PlayerHome = new Player_Menu();
            this.Hide();
            PlayerHome.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main_Menu home = new Main_Menu();
            this.Hide();
            home.Show();
        }
    }
}
