using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steroid_space_ship
{
    public partial class UI_game : Form
    {
        public int[,] matrix = new int[20, 40];
        int timer;
        int count;
        UI_menu menu;
        public UI_game(UI_menu _menu)
        {
            menu = _menu;
            InitializeComponent();
        }

        private void UI_game_Load(object sender, EventArgs e)
        {
            matrix[10, 10] = 1;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Name = $"{i}_{j}",
                        Size = new Size(20, 20),
                        Location = new Point(20 * i, 20 * j),
                        BackColor = Color.Transparent,
                    };
                    gamepanel.Controls.Add(pic);
                }
            }
        }

        private void UI_game_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void go_Click(object sender, EventArgs e)
        {
            panel_pause.Visible = false;
            timer1.Start();
        }
        private void UI_game_KeyDown(object sender, KeyEventArgs e)
        {
            if (panel_pause.Visible == true)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    panel_pause.Visible = false;
                    timer1.Start();
                    mainTimer.Start();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                panel_pause.Visible = true;
                panel_pause.Location = new Point(0, 0);
                timer1.Stop();
                mainTimer.Stop();
            }
        }

        private void menuexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void score_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lifetime.Text = $"Время игры: {timer.ToString()}";
            scoregame.Text = $"Счёт игры: {count.ToString()}";
            timer++;

        }

        private void lifetime_Click(object sender, EventArgs e)
        {

        }

        private void panel_pause_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gamepanel_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    switch (matrix[i, j])
                    {
                        case 1:
                            PictureBox pic = gamepanel.Controls[$"{i}_{j}"] as PictureBox;
                            pic.BackColor = Color.White;
                            break;
                    }
                }
            }
        }
    }
}
