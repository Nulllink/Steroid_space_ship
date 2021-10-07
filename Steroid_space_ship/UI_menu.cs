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
    public partial class UI_menu : Form
    {
        public static UI_game form;
        public UI_menu()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            form = new UI_game(this);
            Hide();
            form.Show();

        }
    }
}
