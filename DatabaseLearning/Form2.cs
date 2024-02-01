using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DatabaseLearning.Form1;

namespace DatabaseLearning
{
    public partial class Form2 : Form
    {
        private List<gameSaveData> playerSaveData;
        public Form2()
        {
            InitializeComponent();
            this.Text = "Load Saved Game";
            savedGameComboBox.SelectedIndexChanged += savedGameComboBox_SelectedIndexChanged;
        }
        private void LoadSavedCharacterDataFromCSV(string filePath)
        {
            playerSaveData = new List<gameSaveData>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Skip header
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        // Looking in CVS for values
                        string name = values[0];
                        int playerLevel = int.Parse(values[1]);
                        int playerCurrentEXP = int.Parse(values[2]);
                        int playerTotalEXP = int.Parse(values[3]);
                        int playerHealthCurrent = int.Parse(values[4]);
                        int playerHealthTotal = int.Parse(values[5]);
                        int playerManaCurrent = int.Parse(values[6]);
                        int playerManaTotal = int.Parse(values[7]);
                        int playerSTR = int.Parse(values[8]);
                        int playerIntel = int.Parse(values[9]);
                        int playerDex = int.Parse(values[10]);
                        int playerStamina = int.Parse(values[11]);
                        string playerClass = values[12];
                        // int playerCurrentSP = int.Parse(values[13]);
                        // int playerSpentSP = int.Parse(values[14]);


                        gameSaveData gameSaveData = new gameSaveData
                        {
                            Name = name,
                            Level = playerLevel,
                            ExperienceCurrent = playerCurrentEXP,
                            ExperienceTotal = playerTotalEXP,
                            HealthCurrent = playerHealthCurrent,
                            HealthTotal = playerHealthTotal,
                            ManaCurrent = playerManaCurrent,
                            ManaTotal = playerManaTotal,
                            Strength = playerSTR,
                            Intellect = playerIntel,
                            Dexterity = playerDex,
                            Stamina = playerStamina,
                            pClassName = playerClass,
                            //currentSkillPoints = playerCurrentSP,
                            // spentSkillPoints = playerSpentSP,


                        };
                        playerSaveData.Add(gameSaveData);
                    }
                }

                //MessageBox.Show($"Loaded {playerSaveData.Count} Characters from {Path.GetFileName(filePath)}", "Character Save Data Loaded");
                DisplaySaveDataInListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from CSV: {ex.Message}", "char_data.cvs Failed");
            }
        }
        private void DisplaySaveDataInListBox()
        {
            // Clear the existing items in the ListBox
            savedGameComboBox.Items.Clear();

            // Display the loaded data in the ListBox
            foreach (var gameSaveData in playerSaveData)
            {
                savedGameComboBox.Items.Add($"{gameSaveData.Name}");

                if (savedGameComboBox.Items.Count > 0)
                {
                    savedGameComboBox.SelectedIndex = 0;
                }
            }
        }
        private void savedGameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (savedGameComboBox.SelectedIndex != -1)
            {
                gameSaveData selectedPlayer = playerSaveData[savedGameComboBox.SelectedIndex];

                foreach (var gameSaveData in playerSaveData)
                {
                    int levelData = selectedPlayer.Level;
                    labelPlayerLevel.Text = levelData.ToString() + " " + selectedPlayer.pClassName;
                    int currentHPDtata = selectedPlayer.HealthCurrent;
                    labelCurrentHP.Text = currentHPDtata.ToString();
                    int totalHPDtata = selectedPlayer.HealthTotal;
                    labeltotalHP.Text = totalHPDtata.ToString();
                    int currentMPDtata = selectedPlayer.ManaCurrent;
                    labelCurrentMP.Text = currentMPDtata.ToString();
                    int totalMPDtata = selectedPlayer.ManaTotal;
                    labeltotalMP.Text = totalMPDtata.ToString();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadSavedCharacterDataFromCSV("char_data.csv");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
