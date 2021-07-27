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
    public partial class Game_Menu : Form
    {
        public static Manager Mgr = new Manager();
        public Game_Menu()
        {
            InitializeComponent();
        }

        private void SetGame_btn_Click(object sender, EventArgs e)
        {
            Set_Game game = new Set_Game();
            this.Hide();
            game.Show();
        }

        private void Game_Menu_Load(object sender, EventArgs e)
        {

        }

        private void DisplayGame_Click(object sender, EventArgs e)
        {
            Display_All_Games display = new Display_All_Games();
            this.Hide();
            display.Show();
        }

        private void DeleteGame_Click(object sender, EventArgs e)
        {
            Delete_Game delgame = new Delete_Game();
            this.Hide();
            delgame.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main_Menu home = new Main_Menu();
            this.Hide();
            home.Show();
        }

        private void DisplayTable_Click(object sender, EventArgs e)
        {
            All_Tables all = new All_Tables();
            this.Hide();
            all.Show();
        }
    }
}
