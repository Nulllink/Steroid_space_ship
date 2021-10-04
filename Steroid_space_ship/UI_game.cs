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
        }
        private void UI_game_KeyDown(object sender, KeyEventArgs e)
        {
            if (panel_pause.Visible == true)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    panel_pause.Visible = false;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                panel_pause.Visible = true;
            }
        }

        private void menuexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
