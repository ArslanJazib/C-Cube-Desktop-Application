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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {
            Player_Menu player_menu_obj= new Player_Menu();
            this.Hide();
            player_menu_obj.Show();

        }

        private void Game_Click(object sender, EventArgs e)
        {
            Game_Menu game_menu = new Game_Menu();
            this.Hide();
            game_menu.Show();


        }
    }
}
