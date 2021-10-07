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
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                panel_pause.Visible = true;
                panel_pause.Location = new Point(0, 0);
                timer1.Stop();
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
    }
}
