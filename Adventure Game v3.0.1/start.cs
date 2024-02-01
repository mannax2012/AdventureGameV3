using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game_v3._0._1
{
    public partial class start : Form
    {
        public start()
        {
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            main main = new main();
            main.ShowDialog();
            this.Close();
        }
    }
}
