namespace DatabaseLearning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdateCsv = new System.Windows.Forms.Button();
            this.loadLabel = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.load_button = new System.Windows.Forms.Button();
            this.txtNewAge = new System.Windows.Forms.TextBox();
            this.classListDisplayBox = new System.Windows.Forms.ListBox();
            this.bonusSTRBox = new System.Windows.Forms.TextBox();
            this.bonusIntelBox = new System.Windows.Forms.TextBox();
            this.bonusDexBox = new System.Windows.Forms.TextBox();
            this.bonusStamBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSTR = new System.Windows.Forms.Label();
            this.labelIntel = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.labelStamina = new System.Windows.Forms.Label();
            this.labelSkillPoints = new System.Windows.Forms.Label();
            this.labelCurrentHP = new System.Windows.Forms.Label();
            this.labeltotalHP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labeltotalMP = new System.Windows.Forms.Label();
            this.labelCurrentMP = new System.Windows.Forms.Label();
            this.labelPlayerLevel = new System.Windows.Forms.Label();
            this.labelDisplaySTR = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTotalEXP = new System.Windows.Forms.Label();
            this.labelCurrentEXP = new System.Windows.Forms.Label();
            this.labelDisplayIntel = new System.Windows.Forms.Label();
            this.labelDisplayDex = new System.Windows.Forms.Label();
            this.labelDisplayStam = new System.Windows.Forms.Label();
            this.labelTotalSkillPoints = new System.Windows.Forms.Label();
            this.ADDSTR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.REMOVE = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.classNameDisplay = new System.Windows.Forms.Label();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateCsv
            // 
            this.btnUpdateCsv.Location = new System.Drawing.Point(184, 415);
            this.btnUpdateCsv.Name = "btnUpdateCsv";
            this.btnUpdateCsv.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCsv.TabIndex = 0;
            this.btnUpdateCsv.Text = "Save";
            this.btnUpdateCsv.UseVisualStyleBackColor = true;
            this.btnUpdateCsv.Click += new System.EventHandler(this.btnUpdateCsv_Click_1);
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Location = new System.Drawing.Point(562, 171);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(129, 13);
            this.loadLabel.TabIndex = 1;
            this.loadLabel.Text = "Click Load to Change me.";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(12, 392);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(156, 20);
            this.txtNewName.TabIndex = 2;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(265, 416);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 3;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // txtNewAge
            // 
            this.txtNewAge.Location = new System.Drawing.Point(12, 418);
            this.txtNewAge.Name = "txtNewAge";
            this.txtNewAge.Size = new System.Drawing.Size(156, 20);
            this.txtNewAge.TabIndex = 4;
            // 
            // classListDisplayBox
            // 
            this.classListDisplayBox.FormattingEnabled = true;
            this.classListDisplayBox.Location = new System.Drawing.Point(565, 60);
            this.classListDisplayBox.Name = "classListDisplayBox";
            this.classListDisplayBox.Size = new System.Drawing.Size(120, 95);
            this.classListDisplayBox.TabIndex = 5;
            // 
            // bonusSTRBox
            // 
            this.bonusSTRBox.Location = new System.Drawing.Point(169, 104);
            this.bonusSTRBox.Name = "bonusSTRBox";
            this.bonusSTRBox.Size = new System.Drawing.Size(44, 20);
            this.bonusSTRBox.TabIndex = 7;
            // 
            // bonusIntelBox
            // 
            this.bonusIntelBox.Location = new System.Drawing.Point(169, 128);
            this.bonusIntelBox.Name = "bonusIntelBox";
            this.bonusIntelBox.Size = new System.Drawing.Size(44, 20);
            this.bonusIntelBox.TabIndex = 8;
            // 
            // bonusDexBox
            // 
            this.bonusDexBox.Location = new System.Drawing.Point(169, 153);
            this.bonusDexBox.Name = "bonusDexBox";
            this.bonusDexBox.Size = new System.Drawing.Size(44, 20);
            this.bonusDexBox.TabIndex = 9;
            // 
            // bonusStamBox
            // 
            this.bonusStamBox.Location = new System.Drawing.Point(169, 179);
            this.bonusStamBox.Name = "bonusStamBox";
            this.bonusStamBox.Size = new System.Drawing.Size(44, 20);
            this.bonusStamBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Character Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Experience:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Health:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mana:";
            // 
            // labelSTR
            // 
            this.labelSTR.AutoSize = true;
            this.labelSTR.Location = new System.Drawing.Point(14, 107);
            this.labelSTR.Name = "labelSTR";
            this.labelSTR.Size = new System.Drawing.Size(50, 13);
            this.labelSTR.TabIndex = 16;
            this.labelSTR.Text = "Strength:";
            // 
            // labelIntel
            // 
            this.labelIntel.AutoSize = true;
            this.labelIntel.Location = new System.Drawing.Point(14, 131);
            this.labelIntel.Name = "labelIntel";
            this.labelIntel.Size = new System.Drawing.Size(47, 13);
            this.labelIntel.TabIndex = 17;
            this.labelIntel.Text = "Intellect:";
            // 
            // labelDex
            // 
            this.labelDex.AutoSize = true;
            this.labelDex.Location = new System.Drawing.Point(14, 156);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(51, 13);
            this.labelDex.TabIndex = 18;
            this.labelDex.Text = "Dexterity:";
            // 
            // labelStamina
            // 
            this.labelStamina.AutoSize = true;
            this.labelStamina.Location = new System.Drawing.Point(14, 182);
            this.labelStamina.Name = "labelStamina";
            this.labelStamina.Size = new System.Drawing.Size(48, 13);
            this.labelStamina.TabIndex = 19;
            this.labelStamina.Text = "Stamina:";
            // 
            // labelSkillPoints
            // 
            this.labelSkillPoints.AutoSize = true;
            this.labelSkillPoints.Location = new System.Drawing.Point(14, 206);
            this.labelSkillPoints.Name = "labelSkillPoints";
            this.labelSkillPoints.Size = new System.Drawing.Size(61, 13);
            this.labelSkillPoints.TabIndex = 21;
            this.labelSkillPoints.Text = "Skill Points:";
            // 
            // labelCurrentHP
            // 
            this.labelCurrentHP.AutoSize = true;
            this.labelCurrentHP.Location = new System.Drawing.Point(61, 84);
            this.labelCurrentHP.Name = "labelCurrentHP";
            this.labelCurrentHP.Size = new System.Drawing.Size(25, 13);
            this.labelCurrentHP.TabIndex = 22;
            this.labelCurrentHP.Text = "100";
            // 
            // labeltotalHP
            // 
            this.labeltotalHP.AutoSize = true;
            this.labeltotalHP.Location = new System.Drawing.Point(92, 84);
            this.labeltotalHP.Name = "labeltotalHP";
            this.labeltotalHP.Size = new System.Drawing.Size(25, 13);
            this.labeltotalHP.TabIndex = 23;
            this.labeltotalHP.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "/";
            // 
            // labeltotalMP
            // 
            this.labeltotalMP.AutoSize = true;
            this.labeltotalMP.Location = new System.Drawing.Point(197, 84);
            this.labeltotalMP.Name = "labeltotalMP";
            this.labeltotalMP.Size = new System.Drawing.Size(25, 13);
            this.labeltotalMP.TabIndex = 26;
            this.labeltotalMP.Text = "100";
            // 
            // labelCurrentMP
            // 
            this.labelCurrentMP.AutoSize = true;
            this.labelCurrentMP.Location = new System.Drawing.Point(166, 84);
            this.labelCurrentMP.Name = "labelCurrentMP";
            this.labelCurrentMP.Size = new System.Drawing.Size(25, 13);
            this.labelCurrentMP.TabIndex = 25;
            this.labelCurrentMP.Text = "100";
            // 
            // labelPlayerLevel
            // 
            this.labelPlayerLevel.AutoSize = true;
            this.labelPlayerLevel.Location = new System.Drawing.Point(50, 60);
            this.labelPlayerLevel.Name = "labelPlayerLevel";
            this.labelPlayerLevel.Size = new System.Drawing.Size(25, 13);
            this.labelPlayerLevel.TabIndex = 28;
            this.labelPlayerLevel.Text = "100";
            // 
            // labelDisplaySTR
            // 
            this.labelDisplaySTR.AutoSize = true;
            this.labelDisplaySTR.Location = new System.Drawing.Point(75, 107);
            this.labelDisplaySTR.Name = "labelDisplaySTR";
            this.labelDisplaySTR.Size = new System.Drawing.Size(25, 13);
            this.labelDisplaySTR.TabIndex = 29;
            this.labelDisplaySTR.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "/";
            // 
            // labelTotalEXP
            // 
            this.labelTotalEXP.AutoSize = true;
            this.labelTotalEXP.Location = new System.Drawing.Point(214, 60);
            this.labelTotalEXP.Name = "labelTotalEXP";
            this.labelTotalEXP.Size = new System.Drawing.Size(25, 13);
            this.labelTotalEXP.TabIndex = 31;
            this.labelTotalEXP.Text = "100";
            // 
            // labelCurrentEXP
            // 
            this.labelCurrentEXP.AutoSize = true;
            this.labelCurrentEXP.Location = new System.Drawing.Point(183, 60);
            this.labelCurrentEXP.Name = "labelCurrentEXP";
            this.labelCurrentEXP.Size = new System.Drawing.Size(25, 13);
            this.labelCurrentEXP.TabIndex = 30;
            this.labelCurrentEXP.Text = "100";
            // 
            // labelDisplayIntel
            // 
            this.labelDisplayIntel.AutoSize = true;
            this.labelDisplayIntel.Location = new System.Drawing.Point(75, 131);
            this.labelDisplayIntel.Name = "labelDisplayIntel";
            this.labelDisplayIntel.Size = new System.Drawing.Size(25, 13);
            this.labelDisplayIntel.TabIndex = 33;
            this.labelDisplayIntel.Text = "100";
            // 
            // labelDisplayDex
            // 
            this.labelDisplayDex.AutoSize = true;
            this.labelDisplayDex.Location = new System.Drawing.Point(75, 156);
            this.labelDisplayDex.Name = "labelDisplayDex";
            this.labelDisplayDex.Size = new System.Drawing.Size(25, 13);
            this.labelDisplayDex.TabIndex = 34;
            this.labelDisplayDex.Text = "100";
            // 
            // labelDisplayStam
            // 
            this.labelDisplayStam.AutoSize = true;
            this.labelDisplayStam.Location = new System.Drawing.Point(75, 182);
            this.labelDisplayStam.Name = "labelDisplayStam";
            this.labelDisplayStam.Size = new System.Drawing.Size(25, 13);
            this.labelDisplayStam.TabIndex = 35;
            this.labelDisplayStam.Text = "100";
            // 
            // labelTotalSkillPoints
            // 
            this.labelTotalSkillPoints.AutoSize = true;
            this.labelTotalSkillPoints.Location = new System.Drawing.Point(75, 206);
            this.labelTotalSkillPoints.Name = "labelTotalSkillPoints";
            this.labelTotalSkillPoints.Size = new System.Drawing.Size(25, 13);
            this.labelTotalSkillPoints.TabIndex = 36;
            this.labelTotalSkillPoints.Text = "100";
            // 
            // ADDSTR
            // 
            this.ADDSTR.Location = new System.Drawing.Point(126, 102);
            this.ADDSTR.Name = "ADDSTR";
            this.ADDSTR.Size = new System.Drawing.Size(24, 23);
            this.ADDSTR.TabIndex = 37;
            this.ADDSTR.Text = "+";
            this.ADDSTR.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // REMOVE
            // 
            this.REMOVE.Location = new System.Drawing.Point(110, 201);
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(50, 23);
            this.REMOVE.TabIndex = 41;
            this.REMOVE.Text = "Reset";
            this.REMOVE.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(214, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Class:";
            // 
            // classNameDisplay
            // 
            this.classNameDisplay.AutoSize = true;
            this.classNameDisplay.Location = new System.Drawing.Point(255, 36);
            this.classNameDisplay.Name = "classNameDisplay";
            this.classNameDisplay.Size = new System.Drawing.Size(32, 13);
            this.classNameDisplay.TabIndex = 43;
            this.classNameDisplay.Text = "Class";
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Location = new System.Drawing.Point(106, 33);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.characterNameTextBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose a Class";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(583, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 67);
            this.button6.TabIndex = 45;
            this.button6.Text = "Create Character";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.characterNameTextBox);
            this.Controls.Add(this.classNameDisplay);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.REMOVE);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ADDSTR);
            this.Controls.Add(this.labelTotalSkillPoints);
            this.Controls.Add(this.labelDisplayStam);
            this.Controls.Add(this.labelDisplayDex);
            this.Controls.Add(this.labelDisplayIntel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTotalEXP);
            this.Controls.Add(this.labelCurrentEXP);
            this.Controls.Add(this.labelDisplaySTR);
            this.Controls.Add(this.labelPlayerLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labeltotalMP);
            this.Controls.Add(this.labelCurrentMP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labeltotalHP);
            this.Controls.Add(this.labelCurrentHP);
            this.Controls.Add(this.labelSkillPoints);
            this.Controls.Add(this.labelStamina);
            this.Controls.Add(this.labelDex);
            this.Controls.Add(this.labelIntel);
            this.Controls.Add(this.labelSTR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bonusStamBox);
            this.Controls.Add(this.bonusDexBox);
            this.Controls.Add(this.bonusIntelBox);
            this.Controls.Add(this.bonusSTRBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classListDisplayBox);
            this.Controls.Add(this.txtNewAge);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.btnUpdateCsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCsv;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.TextBox txtNewAge;
        private System.Windows.Forms.ListBox classListDisplayBox;
        private System.Windows.Forms.TextBox bonusSTRBox;
        private System.Windows.Forms.TextBox bonusIntelBox;
        private System.Windows.Forms.TextBox bonusDexBox;
        private System.Windows.Forms.TextBox bonusStamBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSTR;
        private System.Windows.Forms.Label labelIntel;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label labelStamina;
        private System.Windows.Forms.Label labelSkillPoints;
        private System.Windows.Forms.Label labelCurrentHP;
        private System.Windows.Forms.Label labeltotalHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeltotalMP;
        private System.Windows.Forms.Label labelCurrentMP;
        private System.Windows.Forms.Label labelPlayerLevel;
        private System.Windows.Forms.Label labelDisplaySTR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTotalEXP;
        private System.Windows.Forms.Label labelCurrentEXP;
        private System.Windows.Forms.Label labelDisplayIntel;
        private System.Windows.Forms.Label labelDisplayDex;
        private System.Windows.Forms.Label labelDisplayStam;
        private System.Windows.Forms.Label labelTotalSkillPoints;
        private System.Windows.Forms.Button ADDSTR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button REMOVE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label classNameDisplay;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
    }
}

