using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class start_screen : Form
    {
        public start_screen()
        {
            InitializeComponent();
            this.Text = "Adventure Game";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormManager.RestoreLastActiveFormLocation(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager.SaveFormLocation(this);
            this.Hide();
            main_menu main_menu = new main_menu();
            main_menu.ShowDialog();
            this.Close();
        }
    }
}
