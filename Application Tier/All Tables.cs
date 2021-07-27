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
    public partial class All_Tables : Form
    {
        static int waiting;
        static int[] filled = new int[9];
        public All_Tables()
        {
            InitializeComponent();
        }

        private void All_Tables_Load(object sender, EventArgs e)
        {
           Game_Menu.Mgr.DisplayTableStatus(filled, ref waiting);
           for(int index=0;index<9;index++)
           {
                if(filled[index]>0)
                {
                    if(filled[index]==1)
                    {
                        table1player1.BackColor = Color.LightGreen;
                        table1player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 2)
                    {
                        table2player1.BackColor = Color.LightGreen;
                        table2player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 3)
                    {
                        table3player1.BackColor = Color.LightGreen;
                        table3player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 4)
                    {
                        table4player1.BackColor = Color.LightGreen;
                        table4player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 5)
                    {
                        table5player1.BackColor = Color.LightGreen;
                        table5player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 6)
                    {
                        table6player1.BackColor = Color.LightGreen;
                        table6player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 7)
                    {
                        table7player1.BackColor = Color.LightGreen;
                        table7player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 8)
                    {
                        table8player1.BackColor = Color.LightGreen;
                        table8player2.BackColor = Color.LightGreen;
                    }
                    if (filled[index] == 9)
                    {
                        table9player1.BackColor = Color.LightGreen;
                        table9player2.BackColor = Color.LightGreen;
                    }
                }
           }
            if (waiting == 1)
            {
                table1player1.BackColor = Color.Yellow;
            }
            if (waiting == 2)
            {
                table2player1.BackColor = Color.Yellow;
            }
            if (waiting == 3)
            {
                table3player1.BackColor = Color.Yellow;
            }
            if (waiting== 4)
            {
                table4player1.BackColor = Color.Yellow;
            }
            if (waiting == 5)
            {
                table5player1.BackColor = Color.Yellow;
            }
            if (waiting == 6)
            {
                table6player1.BackColor = Color.Yellow;
            }
            if (waiting == 7)
            {
                table7player1.BackColor = Color.Yellow;
            }
            if (waiting == 8)
            {
                table8player1.BackColor = Color.Yellow;
            }
            if (waiting == 9)
            {
                table9player1.BackColor = Color.Yellow;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main_Menu home = new Main_Menu();
            this.Hide();
            home.Show();
        }

        private void GameHome_Click(object sender, EventArgs e)
        {
            Game_Menu gamehome = new Game_Menu();
            this.Hide();
            gamehome.Show();
        }
    }
}
