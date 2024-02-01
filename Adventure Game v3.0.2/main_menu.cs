using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Adventure_Game
{
    public partial class main_menu : Form
    {
        private DataTable classDataTable;
        public DataTable playerCharacterData;

        public int totalAdjustedSTR;
        public int totalAdjustedINT;
        public int totalAdjustedSTAM;
        public int totalSP = 15;
        public int currentSP = 0;

        public int playerHPBASE = 100;
        public int playerHPCurrent = 100;

        public int playerMPBASE = 100;
        public int playerMPCurrent = 100;

        public int playerSTRBASE = 10;
        public int playerSTRCurrent = 10;

        public int playerINTBASE = 10;
        public int playerINTCurrent = 10;

        public int playerSTAMBASE = 10;
        public int playerSTAMCurrent = 10;

        public int totalSTR;
        public int totalINT;
        public int totalSTAM;

        public string playerName = "Character Name";

        public string BonusHPValue;
        public string BonusMPValue;
        public string BonusSTRValue;
        public string BonusINTValue;
        public string BonusSTAMValue;
        public main_menu()
        {
            InitializeComponent();
            this.Text = "Adventure Game - Main Menu";
        }

        public void main_menu_Load(object sender, EventArgs e)
        {
            FormManager.RestoreLastActiveFormLocation(this);
            classDataTable = CreateMyDataTable(); // Replace with your actual logic
            
            character_sheet character_sheet = new character_sheet();
            character_sheet.SetDataTable();
            playerCharacterData = CreateMyCharacterDataTable();
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxSKILLPOINTS.Text = totalSP.ToString();
            textPName.Text = playerName.ToString();
            ClassList.SetSelected(0, true);
        }

        public void getSheetUpdate()
        {
            DataRow selectedRow = classDataTable.Rows[ClassList.SelectedIndex];

            string BonusHPValue = selectedRow["Bonus HP"].ToString();
            string BonusMPValue = selectedRow["Bonus MP"].ToString();
            string BonusSTRValue = selectedRow["Bonus Strength"].ToString();
            string BonusINTValue = selectedRow["Bonus Intellect"].ToString();
            string BonusSTAMValue = selectedRow["Bonus Stamina"].ToString();

            textBoxName.Text = selectedRow["Name"].ToString();
            textBoxBonusHP.Text = BonusHPValue;
            textBoxBonusMana.Text = BonusMPValue;
            textBoxBonusStr.Text = BonusSTRValue;
            textBoxBonusInt.Text = BonusINTValue;
            textBoxBonusStam.Text = BonusSTAMValue;

            if (classDataTable != null)
            {
                if (int.TryParse(BonusHPValue, out int BonusHPInt))
                {
                    int totalHP = playerHPBASE + BonusHPInt;
                    playerHPCurrent = totalHP;
                    textBoxPlayerHP.Text = playerHPCurrent.ToString();
                }

                if (int.TryParse(BonusMPValue, out int BonusMPInt))
                {
                    int totalMP = playerMPBASE + BonusMPInt;
                    textBoxPlayerMP.Text = totalMP.ToString();
                }

                if (int.TryParse(BonusSTRValue, out int BonusSTRInt))
                {
                    totalSTR = playerSTRBASE + BonusSTRInt;
                    playerSTRCurrent = totalSTR + totalAdjustedSTR;
                    textBoxPlayerSTR.Text = playerSTRCurrent.ToString();
                }

                if (int.TryParse(BonusINTValue, out int BonusINTELLInt))
                {
                    totalINT = playerINTBASE + BonusINTELLInt;
                    playerINTCurrent = totalINT + totalAdjustedINT;
                    textBoxPlayerINT.Text = playerINTCurrent.ToString();
                }

                if (int.TryParse(BonusSTAMValue, out int BonusSTAMInt))
                {
                    totalSTAM = playerSTAMBASE + BonusSTAMInt;
                    playerSTAMCurrent = totalSTAM + totalAdjustedSTAM;
                    textBoxPlayerSTAM.Text = playerSTAMCurrent.ToString();
                }
                textBoxSKILLPOINTS.Text = totalSP.ToString();
            }
        }
        public void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSheetUpdate();
        }
        private DataTable CreateMyDataTable()
        {
            // Create a new DataSet
            DataSet dataSet = new DataSet("MyDataSet");

            // Create a new DataTable
            DataTable playerCharacterClassDATA = new DataTable("playerCharacterClassDATA");

            // Add string columns to the DataTable
            playerCharacterClassDATA.Columns.Add("Name", typeof(string));
            playerCharacterClassDATA.Columns.Add("Bonus HP", typeof(string));
            playerCharacterClassDATA.Columns.Add("Bonus MP", typeof(string));
            playerCharacterClassDATA.Columns.Add("Bonus Strength", typeof(string));
            playerCharacterClassDATA.Columns.Add("Bonus Intellect", typeof(string));
            playerCharacterClassDATA.Columns.Add("Bonus Stamina", typeof(string));

            // Add the DataTable to the DataSet
            dataSet.Tables.Add(playerCharacterClassDATA);

            // Add some rows to the DataTable
            DataRow row1 = playerCharacterClassDATA.NewRow();
            row1["Name"] = "Warrior";
            row1["Bonus HP"] = "100";
            row1["Bonus MP"] = "0";
            row1["Bonus Strength"] = "8";
            row1["Bonus Intellect"] = "0";
            row1["Bonus Stamina"] = "2";
            playerCharacterClassDATA.Rows.Add(row1);

            DataRow row2 = playerCharacterClassDATA.NewRow();
            row2["Name"] = "Wizard";
            row2["Bonus HP"] = "0";
            row2["Bonus MP"] = "100";
            row2["Bonus Strength"] = "0";
            row2["Bonus Intellect"] = "10";
            row2["Bonus Stamina"] = "0";
            playerCharacterClassDATA.Rows.Add(row2);

            DataRow row3 = playerCharacterClassDATA.NewRow();
            row3["Name"] = "Archer";
            row3["Bonus HP"] = "50";
            row3["Bonus MP"] = "50";
            row3["Bonus Strength"] = "7";
            row3["Bonus Intellect"] = "2";
            row3["Bonus Stamina"] = "1";
            playerCharacterClassDATA.Rows.Add(row3);

            // Display the data in the ListBox
            foreach (DataRow row in playerCharacterClassDATA.Rows)
            {
                // Concatenate the values and add them to the ListBox
                string itemText = $"{row["Name"]}";
                ClassList.Items.Add(itemText);
            }
            return playerCharacterClassDATA;
        }
        private void characterSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.SaveFormLocation(this);
            this.Hide();
            character_sheet character_sheet = new character_sheet();
            character_sheet.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void button1_Click(object sender, EventArgs e) 
        {
            CreateMyCharacterDataTable();
        }
        private DataTable CreateMyCharacterDataTable()
        {
           // Create a new DataSet
           DataSet dataSetPlayer = new DataSet("MyDataSetPlayer");

            // Create a new DataTable
            DataTable characterInfoDataTable = new DataTable("characterInfoDataTable");

            // Add string columns to the DataTable
            characterInfoDataTable.Columns.Add("Name", typeof(string));
            characterInfoDataTable.Columns.Add("HP", typeof(string));
            characterInfoDataTable.Columns.Add("MP", typeof(string));
            characterInfoDataTable.Columns.Add("Strength", typeof(string));
            characterInfoDataTable.Columns.Add("Intellect", typeof(string));
            characterInfoDataTable.Columns.Add("Stamina", typeof(string));
            characterInfoDataTable.Columns.Add("SkillPoints", typeof(string));

            // Add the DataTable to the DataSet
            dataSetPlayer.Tables.Add(characterInfoDataTable);
            string playerName = textPName.Text;
            // Add some rows to the DataTable
            DataRow row1 = characterInfoDataTable.NewRow();
            row1["Name"] = playerName;
            row1["HP"] = textBoxPlayerHP.Text;
            row1["MP"] = textBoxPlayerMP.Text;
            row1["Strength"] = textBoxPlayerSTR.Text;
            row1["Intellect"] = textBoxPlayerINT.Text;
            row1["Stamina"] = textBoxPlayerSTAM.Text;
            row1["SkillPoints"] = textBoxSKILLPOINTS.Text;


            characterInfoDataTable.Rows.Add(row1);

            SaveDataTableToCSV(characterInfoDataTable, "class_data.csv");
            foreach (DataRow row in characterInfoDataTable.Rows)
            {
                string name = $"{row["Name"]}";
                MessageBox.Show($"Character Created - Name: {name}");
            }
            return characterInfoDataTable;
        }

        private void SaveDataTableToCSV(DataTable characterInfoDataTable, string v)
        {
            throw new NotImplementedException();
        }

        public void textBoxName_TextChanged(object sender, EventArgs e) {
        }
        private void textBoxBonusHP_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPlayerHP_TextChanged(object sender, EventArgs e)
        {

        }
        private void ADDSTR_Click(object sender, EventArgs e)
        {
            if (totalSP > 0)
            {
                totalSP = totalSP - 1;
                totalAdjustedSTR = totalAdjustedSTR + 1;

                if (int.TryParse(BonusSTRValue, out int BonusSTRInt))
                {
                    totalSTR = playerSTRBASE + BonusSTRInt;
                    playerSTRCurrent = totalSTR + 1;

                }
                getSheetUpdate();
                AddSTRBox.Text = totalAdjustedSTR.ToString();

            } else
            {
                MessageBox.Show($"Not enough skill points: {totalSP}");
            }

        }

        private void ADDINT_Click(object sender, EventArgs e)
        {
            if (totalSP > 0)
            {
                totalSP = totalSP - 1;
                totalAdjustedINT = totalAdjustedINT + 1;

                if (int.TryParse(BonusINTValue, out int BonusIntellInt))
                {
                    totalINT = playerINTBASE + BonusIntellInt;
                    playerINTCurrent = totalINT + 1;

                }
                getSheetUpdate();
                AddINTBox.Text = totalAdjustedINT.ToString();

            }
            else
            {
                MessageBox.Show($"Not enough skill points: {totalSP}");
            }
        }

        private void ADDSTAM_Click(object sender, EventArgs e)
        {
            if (totalSP > 0)
            {
                totalSP = totalSP - 1;
                totalAdjustedSTAM = totalAdjustedSTAM + 1;

                if (int.TryParse(BonusSTAMValue, out int BonusSTAMInt))
                {
                    totalSTAM = playerSTAMBASE + BonusSTAMInt;
                    playerSTAMCurrent = totalSTAM + 1;

                }
                getSheetUpdate();
                addSTAMBox.Text = totalAdjustedSTAM.ToString();

            }
            else
            {
                MessageBox.Show($"Not enough skill points: {totalSP}");
            }
        }
        private void REMOVE_Click(object sender, EventArgs e)
        {
            resetSKillPoints();
        }

        private void textPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void debugBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlayerSTR_TextChanged(object sender, EventArgs e)
        {

        }
        public void resetSKillPoints()
        {
            if (totalAdjustedSTR > 0 || totalAdjustedINT > 0 || totalAdjustedSTAM > 0)
            {
                totalSP += totalAdjustedSTR + totalAdjustedINT + totalAdjustedSTAM;

                if (int.TryParse(BonusSTRValue, out int BonusSTRInt))
                {
                    totalSTR = playerSTRBASE + BonusSTRInt;
                    playerSTRCurrent = totalSTR - totalAdjustedSTR;

                }

                if (int.TryParse(BonusINTValue, out int BonusIntellInt))
                {
                    totalINT = playerINTBASE + BonusIntellInt;
                    playerINTCurrent = totalINT - totalAdjustedINT;

                }

                if (int.TryParse(BonusSTAMValue, out int BonusSTAMInt))
                {
                    totalSTAM = playerSTAMBASE + BonusSTAMInt;
                    playerSTAMCurrent = totalSTAM - totalAdjustedSTAM;

                }
                totalAdjustedSTR = 0;
                totalAdjustedINT = 0;
                totalAdjustedSTAM = 0;

                AddSTRBox.Text = totalAdjustedSTR.ToString();
                AddINTBox.Text = totalAdjustedINT.ToString();
                addSTAMBox.Text = totalAdjustedSTAM.ToString();
                getSheetUpdate();
            }
            else
            {
                MessageBox.Show($"Your Skill Points have already been reset: {totalSP}");
            }
        }
    }
}
