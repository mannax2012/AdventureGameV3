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
     public partial class character_sheet : Form
    {
        public DataTable playerCharacterData;
        private DataTable CharacterSheetData;
        public character_sheet()
        {
            InitializeComponent();
        }
        public void SetDataTable()
        {
            CharacterSheetData = playerCharacterData;
        }
        private void character_sheet_Load(object sender, EventArgs e)
        {
            FormManager.RestoreLastActiveFormLocation(this);
            GetCharacterData();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetCharacterData()
        {
            
            if (CharacterSheetData != null)
            {
                foreach (DataRow row in CharacterSheetData.Rows)
                {
                    textPName.Text = row["Name"].ToString();
                }
            }
            else
            {
                FormManager.SaveFormLocation(this);
                this.Hide();
                MessageBox.Show($"DataTable playerCharacterData Failed to Load.");
                main_menu main_menu = new main_menu();
                main_menu.ShowDialog();
                this.Close();
            }
        }

        private void textPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textPName.Text = row["Name"].ToString();
            SaveDataTableToCSV(DataTable );
        }
    }
}
