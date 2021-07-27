using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessaLayer;
namespace Journal
{
    public partial class Player_Menu : Form
    {
        public static Manager Mgr = new Manager();
        public Player_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_Form reg = new Registration_Form();
            this.Hide();
            reg.Show();
        }

        private void Player_Menu_Load(object sender, EventArgs e)
        {

        }

       

        private void Searching_Player_Click(object sender, EventArgs e)
        {
            Search_Display allplayers = new Search_Display();
            this.Hide();
            allplayers.Show();
        }

        private void Update_Player_Click(object sender, EventArgs e)
        {
            Update_Player_Form update = new Update_Player_Form();
            this.Hide();
            update.Show();
        }

        private void Delete_Player_Click(object sender, EventArgs e)
        {
            Delete_Player_Form delete = new Delete_Player_Form();
            this.Hide();
            delete.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main_Menu home = new Main_Menu();
            this.Hide();
            home.Show();
        }
    }
}
