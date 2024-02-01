using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using CompuMaster.VisualBasicCompatibility;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace DatabaseLearning
{
    public partial class Form1 : Form
    {
        private List<PlayerCharacter> players;
        private List<gameClassData> playerClass;
        private List<gameSaveData> playerSaveData;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Adventure Game - Main Menu";
            classListDisplayBox.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }


        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
            /*
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a CSV File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadDataFromCSV(filePath);

                    foreach (var PlayerCharacter in players)
                    {
                        Console.WriteLine($"Name: {PlayerCharacter.Name}, Level: {PlayerCharacter.Level}");
                    }
                }
            }*/
        }
        private void LoadDataFromCSV(string filePath)
        {
            players = new List<PlayerCharacter>();

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

                        // Assuming your CSV has columns 'Name' and 'Level'
                        string name = values[0];
                        int playerLevel = int.Parse(values[1]);
                        //int playerID = int.Parse(values[2]);

                        PlayerCharacter PlayerCharacter = new PlayerCharacter { Name = name, Level = playerLevel };
                        players.Add(PlayerCharacter);
                    }
                }

                MessageBox.Show($"Loaded {players.Count} records from {Path.GetFileName(filePath)}", "CSV Loaded");
                DisplayDataInLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from CSV: {ex.Message}", "Error");
            }
        }

        private void LoadClassDataFromCSV(string filePath)
        {
            playerClass = new List<gameClassData>();

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
                        int bonusSTR = int.Parse(values[1]);
                        int bonusIntel = int.Parse(values[2]);
                        int bonusDex = int.Parse(values[3]);
                        int bonusStam = int.Parse(values[4]);

                        gameClassData gameClassData = new gameClassData
                        {
                            className = name,
                            classBonusSTR = bonusSTR,
                            classBonusIntel = bonusIntel,
                            classBonusDex = bonusDex,
                            classBonusStam = bonusStam,
                        };
                        playerClass.Add(gameClassData);
                    }
                }

                MessageBox.Show($"Loaded {playerClass.Count} Classes from {Path.GetFileName(filePath)}", "Class Data Loaded");
                DisplayDataInClassListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from CSV: {ex.Message}", "classData.cvs Failed");
            }
        }


        private void DisplayDataInLabel()
        {
            // Clear the existing text
            loadLabel.Text = "";

            // Display the loaded data in the label
            foreach (var PlayerCharacter in players)
            {
                loadLabel.Text += $"Name: {PlayerCharacter.Name}, Level: {PlayerCharacter.Level}{Environment.NewLine}";
            }
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getClassBonus();
        }
        private void getClassBonus()
        {
            // Check if there is a selected item
            if (classListDisplayBox.SelectedIndex != -1)
            {
                gameClassData selectedClass = playerClass[classListDisplayBox.SelectedIndex];

                // Update TextBox controls with the selected class details
                foreach (var gameClassData in playerClass)
                {
                    string className = selectedClass.className;
                    classNameDisplay.Text = className.ToString();

                    int bonusSTRdisplay = selectedClass.classBonusSTR;
                    bonusSTRBox.Text = bonusSTRdisplay.ToString();

                    int bonusInteldisplay = selectedClass.classBonusIntel;
                    bonusIntelBox.Text = bonusInteldisplay.ToString();

                    int bonusDexdisplay = selectedClass.classBonusDex;
                    bonusDexBox.Text = bonusDexdisplay.ToString();

                    int bonusStamdisplay = selectedClass.classBonusStam;
                    bonusStamBox.Text = bonusStamdisplay.ToString();
                }
            }
        }
        private void DisplayDataInClassListBox()
        {
            // Clear the existing items in the ListBox
            classListDisplayBox.Items.Clear();

            // Display the loaded data in the ListBox
            foreach (var gameClassData in playerClass)
            {
                classListDisplayBox.Items.Add($"{gameClassData.className}");
            }
        }
        private void UpdateSaveGameFile(string newName,
                                        string newLevel,
                                        string newExperienceCurrent,
                                        string newExperienceTotal,
                                        string newHealthCurrent,
                                        string newHealthTotal,
                                        string newManaCurrent,
                                        string newManaTotal,
                                        string newStrength,
                                        string newIntellect,
                                        string newDexterity,
                                        string newStamina,
                                        string newClass)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                {

                }
                try
                {
                    List<string> lines = File.ReadAllLines("char_data.csv").ToList();

                    bool entryExists = false;

                    // Iterate through each line to find and update an existing entry
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string[] values = lines[i].Split(',');

                        // Assuming the CSV has columns 'Name' and 'Level'
                        string existingName = values[0];

                        if (existingName == newName)
                        {
                            // Update the existing entry
                            lines[i] = $"{newName},{newLevel},{newExperienceCurrent},{newExperienceTotal},{newHealthCurrent}," +
                                        $"{newHealthTotal},{newManaCurrent},{newManaTotal},{newStrength},{newIntellect},{newDexterity},{newStamina},{newClass}";
                            entryExists = true;
                            break;
                        }
                    }

                    // If the entry doesn't exist, create a new entry
                    if (!entryExists)
                    {
                        lines.Add($"{newName},{newLevel},{newExperienceCurrent},{newExperienceTotal},{newHealthCurrent}," +
                                  $"{newHealthTotal},{newManaCurrent},{newManaTotal},{newStrength},{newIntellect},{newDexterity},{newStamina},{newClass}");
                    }

                    // Write the updated or new data back to the CSV file
                    File.WriteAllLines("char_data.csv", lines);

                    MessageBox.Show($"Data updated in char_data.csv", "CSV Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data in CSV: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show($"You must have a name for your character to continue.", "Error");
            }
        }
        private void UpdateCsvFile(string newName, string newLevel)
        {
            try
            {
                // Append new data to the CSV file
                using (StreamWriter writer = new StreamWriter("sample.csv", true, Encoding.UTF8))
                {
                    // Write the new data
                    writer.WriteLine($"{newName},{newLevel}");
                }

                MessageBox.Show($"Data updated in sample.csv", "CSV Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data in CSV: {ex.Message}", "Error");
            }
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

                MessageBox.Show($"Loaded {playerSaveData.Count} Characters from {Path.GetFileName(filePath)}", "Character Save Data Loaded");
                //DisplayDataInClassListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from CSV: {ex.Message}", "char_data.cvs Failed");
            }
        }
        public class PlayerCharacter
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int ExperienceCurrent { get; set; }
            public int ExperienceTotal { get; set; }
            public int HealthCurrent { get; set; }
            public int HealthTotal { get; set; }
            public int ManaCurrent { get; set; }
            public int ManaTotal { get; set; }
            public int Strength { get; set; }
            public int Intellect { get; set; }
            public int Dexterity { get; set; }
            public int Stamina { get; set; }
            public string pClassName { get; set; }
            public int currentSkillPoints { get; set; }
            public int spentSkillPoints { get; set; }

        }

        public class gameSaveData
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int ExperienceCurrent { get; set; }
            public int ExperienceTotal { get; set; }
            public int HealthCurrent { get; set; }
            public int HealthTotal { get; set; }
            public int ManaCurrent { get; set; }
            public int ManaTotal { get; set; }
            public int Strength { get; set; }
            public int Intellect { get; set; }
            public int Dexterity { get; set; }
            public int Stamina { get; set; }
            public string pClassName { get; set; }
            public int currentSkillPoints { get; set; }
            public int spentSkillPoints { get; set; }

        }
        public class gameClassData
        {
            public string className { get; set; }
            public int classBonusSTR { get; set; }
            public int classBonusIntel { get; set; }
            public int classBonusDex { get; set; }
            public int classBonusStam { get; set; }

        }
        private void btnUpdateCsv_Click_1(object sender, EventArgs e)
        {
            // Update the CSV file with new data from TextBox controls
            UpdateCsvFile(txtNewName.Text, txtNewAge.Text);

            // Reload and display the updated data
            LoadDataFromCSV("sample.csv");
            DisplayDataInLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Preload data when the form is loaded
            LoadDataFromCSV("sample.csv");
            LoadClassDataFromCSV("classData.csv");
            LoadSavedCharacterDataFromCSV("char_data.csv");

            // Display the loaded data in the label
            DisplayDataInLabel();
            classListDisplayBox.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Create Character Button
            UpdateSaveGameFile(
                characterNameTextBox.Text, 
                labelPlayerLevel.Text,
                labelCurrentEXP.Text,
                labelTotalEXP.Text,
                labelCurrentHP.Text, 
                labeltotalHP.Text, 
                labelCurrentMP.Text, 
                labeltotalMP.Text,
                labelDisplaySTR.Text,
                labelDisplayIntel.Text,
                labelDisplayDex.Text,
                labelDisplayStam.Text,
                classNameDisplay.Text
              );
        }
    }
}