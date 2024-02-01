namespace Adventure_Game
{
    partial class main_menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challengesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.classListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classListDataSet = new Adventure_Game.classListDataSet();
            this.classListDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBonusHP = new System.Windows.Forms.TextBox();
            this.textBoxBonusMana = new System.Windows.Forms.TextBox();
            this.textBoxBonusStr = new System.Windows.Forms.TextBox();
            this.textBoxBonusInt = new System.Windows.Forms.TextBox();
            this.textBoxBonusStam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textPName = new System.Windows.Forms.TextBox();
            this.textBoxPlayerHP = new System.Windows.Forms.TextBox();
            this.textBoxPlayerMP = new System.Windows.Forms.TextBox();
            this.textBoxPlayerSTR = new System.Windows.Forms.TextBox();
            this.textBoxPlayerINT = new System.Windows.Forms.TextBox();
            this.textBoxPlayerSTAM = new System.Windows.Forms.TextBox();
            this.ADDSTR = new System.Windows.Forms.Button();
            this.ADDINT = new System.Windows.Forms.Button();
            this.ADDSTAM = new System.Windows.Forms.Button();
            this.REMOVE = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSKILLPOINTS = new System.Windows.Forms.TextBox();
            this.addSTAMBox = new System.Windows.Forms.TextBox();
            this.AddINTBox = new System.Windows.Forms.TextBox();
            this.AddSTRBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.challengesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterSheetToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.playerToolStripMenuItem.Text = "Character";
            // 
            // characterSheetToolStripMenuItem
            // 
            this.characterSheetToolStripMenuItem.Name = "characterSheetToolStripMenuItem";
            this.characterSheetToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.characterSheetToolStripMenuItem.Text = "Stats Sheet";
            this.characterSheetToolStripMenuItem.Click += new System.EventHandler(this.characterSheetToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.optionsToolStripMenuItem.Text = "Shop";
            // 
            // challengesToolStripMenuItem
            // 
            this.challengesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.insaneToolStripMenuItem,
            this.epicToolStripMenuItem,
            this.legendaryToolStripMenuItem});
            this.challengesToolStripMenuItem.Name = "challengesToolStripMenuItem";
            this.challengesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.challengesToolStripMenuItem.Text = "Challenges";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            // 
            // insaneToolStripMenuItem
            // 
            this.insaneToolStripMenuItem.Name = "insaneToolStripMenuItem";
            this.insaneToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.insaneToolStripMenuItem.Text = "Insane";
            // 
            // epicToolStripMenuItem
            // 
            this.epicToolStripMenuItem.Name = "epicToolStripMenuItem";
            this.epicToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.epicToolStripMenuItem.Text = "Epic";
            // 
            // legendaryToolStripMenuItem
            // 
            this.legendaryToolStripMenuItem.Name = "legendaryToolStripMenuItem";
            this.legendaryToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.legendaryToolStripMenuItem.Text = "Legendary";
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(617, 45);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(121, 121);
            this.ClassList.TabIndex = 1;
            this.ClassList.SelectedIndexChanged += new System.EventHandler(this.ClassList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create Character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(464, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Text = "None";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // classListDataSetBindingSource
            // 
            this.classListDataSetBindingSource.DataSource = this.classListDataSet;
            this.classListDataSetBindingSource.Position = 0;
            // 
            // classListDataSet
            // 
            this.classListDataSet.DataSetName = "classListDataSet";
            this.classListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classListDataSetBindingSource1
            // 
            this.classListDataSetBindingSource1.DataSource = this.classListDataSet;
            this.classListDataSetBindingSource1.Position = 0;
            // 
            // textBoxBonusHP
            // 
            this.textBoxBonusHP.Location = new System.Drawing.Point(464, 64);
            this.textBoxBonusHP.Name = "textBoxBonusHP";
            this.textBoxBonusHP.ReadOnly = true;
            this.textBoxBonusHP.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonusHP.TabIndex = 4;
            this.textBoxBonusHP.Text = "None";
            this.textBoxBonusHP.TextChanged += new System.EventHandler(this.textBoxBonusHP_TextChanged);
            // 
            // textBoxBonusMana
            // 
            this.textBoxBonusMana.Location = new System.Drawing.Point(464, 90);
            this.textBoxBonusMana.Name = "textBoxBonusMana";
            this.textBoxBonusMana.ReadOnly = true;
            this.textBoxBonusMana.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonusMana.TabIndex = 5;
            this.textBoxBonusMana.Text = "None";
            // 
            // textBoxBonusStr
            // 
            this.textBoxBonusStr.Location = new System.Drawing.Point(464, 116);
            this.textBoxBonusStr.Name = "textBoxBonusStr";
            this.textBoxBonusStr.ReadOnly = true;
            this.textBoxBonusStr.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonusStr.TabIndex = 6;
            this.textBoxBonusStr.Text = "None";
            // 
            // textBoxBonusInt
            // 
            this.textBoxBonusInt.Location = new System.Drawing.Point(464, 142);
            this.textBoxBonusInt.Name = "textBoxBonusInt";
            this.textBoxBonusInt.ReadOnly = true;
            this.textBoxBonusInt.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonusInt.TabIndex = 7;
            this.textBoxBonusInt.Text = "None";
            // 
            // textBoxBonusStam
            // 
            this.textBoxBonusStam.Location = new System.Drawing.Point(464, 168);
            this.textBoxBonusStam.Name = "textBoxBonusStam";
            this.textBoxBonusStam.ReadOnly = true;
            this.textBoxBonusStam.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonusStam.TabIndex = 8;
            this.textBoxBonusStam.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bonus Health:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bonus Mana:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bonus Strength:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bonus Intellect:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bonus Stamina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Character Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Health Points:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mana Points:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Strength:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Intellect:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Stamina:";
            // 
            // textPName
            // 
            this.textPName.Location = new System.Drawing.Point(105, 38);
            this.textPName.MaxLength = 20;
            this.textPName.Name = "textPName";
            this.textPName.Size = new System.Drawing.Size(129, 20);
            this.textPName.TabIndex = 21;
            this.textPName.WordWrap = false;
            this.textPName.TextChanged += new System.EventHandler(this.textPName_TextChanged);
            // 
            // textBoxPlayerHP
            // 
            this.textBoxPlayerHP.Location = new System.Drawing.Point(105, 67);
            this.textBoxPlayerHP.Name = "textBoxPlayerHP";
            this.textBoxPlayerHP.ReadOnly = true;
            this.textBoxPlayerHP.Size = new System.Drawing.Size(60, 20);
            this.textBoxPlayerHP.TabIndex = 22;
            this.textBoxPlayerHP.Text = "100";
            this.textBoxPlayerHP.TextChanged += new System.EventHandler(this.textBoxPlayerHP_TextChanged);
            // 
            // textBoxPlayerMP
            // 
            this.textBoxPlayerMP.Location = new System.Drawing.Point(105, 93);
            this.textBoxPlayerMP.Name = "textBoxPlayerMP";
            this.textBoxPlayerMP.ReadOnly = true;
            this.textBoxPlayerMP.Size = new System.Drawing.Size(60, 20);
            this.textBoxPlayerMP.TabIndex = 23;
            this.textBoxPlayerMP.Text = "100";
            // 
            // textBoxPlayerSTR
            // 
            this.textBoxPlayerSTR.Location = new System.Drawing.Point(105, 119);
            this.textBoxPlayerSTR.Name = "textBoxPlayerSTR";
            this.textBoxPlayerSTR.ReadOnly = true;
            this.textBoxPlayerSTR.Size = new System.Drawing.Size(60, 20);
            this.textBoxPlayerSTR.TabIndex = 24;
            this.textBoxPlayerSTR.Text = "10";
            this.textBoxPlayerSTR.TextChanged += new System.EventHandler(this.textBoxPlayerSTR_TextChanged);
            // 
            // textBoxPlayerINT
            // 
            this.textBoxPlayerINT.Location = new System.Drawing.Point(105, 145);
            this.textBoxPlayerINT.Name = "textBoxPlayerINT";
            this.textBoxPlayerINT.ReadOnly = true;
            this.textBoxPlayerINT.Size = new System.Drawing.Size(60, 20);
            this.textBoxPlayerINT.TabIndex = 25;
            this.textBoxPlayerINT.Text = "10";
            // 
            // textBoxPlayerSTAM
            // 
            this.textBoxPlayerSTAM.Location = new System.Drawing.Point(105, 171);
            this.textBoxPlayerSTAM.Name = "textBoxPlayerSTAM";
            this.textBoxPlayerSTAM.ReadOnly = true;
            this.textBoxPlayerSTAM.Size = new System.Drawing.Size(60, 20);
            this.textBoxPlayerSTAM.TabIndex = 26;
            this.textBoxPlayerSTAM.Text = "10";
            // 
            // ADDSTR
            // 
            this.ADDSTR.Location = new System.Drawing.Point(211, 117);
            this.ADDSTR.Name = "ADDSTR";
            this.ADDSTR.Size = new System.Drawing.Size(23, 23);
            this.ADDSTR.TabIndex = 30;
            this.ADDSTR.Text = "+";
            this.ADDSTR.UseVisualStyleBackColor = true;
            this.ADDSTR.Click += new System.EventHandler(this.ADDSTR_Click);
            // 
            // ADDINT
            // 
            this.ADDINT.Location = new System.Drawing.Point(211, 143);
            this.ADDINT.Name = "ADDINT";
            this.ADDINT.Size = new System.Drawing.Size(23, 23);
            this.ADDINT.TabIndex = 31;
            this.ADDINT.Text = "+";
            this.ADDINT.UseVisualStyleBackColor = true;
            this.ADDINT.Click += new System.EventHandler(this.ADDINT_Click);
            // 
            // ADDSTAM
            // 
            this.ADDSTAM.Location = new System.Drawing.Point(211, 169);
            this.ADDSTAM.Name = "ADDSTAM";
            this.ADDSTAM.Size = new System.Drawing.Size(23, 23);
            this.ADDSTAM.TabIndex = 32;
            this.ADDSTAM.Text = "+";
            this.ADDSTAM.UseVisualStyleBackColor = true;
            this.ADDSTAM.Click += new System.EventHandler(this.ADDSTAM_Click);
            // 
            // REMOVE
            // 
            this.REMOVE.Location = new System.Drawing.Point(211, 199);
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(60, 23);
            this.REMOVE.TabIndex = 34;
            this.REMOVE.Text = "Reset Stats";
            this.REMOVE.UseVisualStyleBackColor = true;
            this.REMOVE.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Skill Points:";
            // 
            // textBoxSKILLPOINTS
            // 
            this.textBoxSKILLPOINTS.Location = new System.Drawing.Point(105, 199);
            this.textBoxSKILLPOINTS.Name = "textBoxSKILLPOINTS";
            this.textBoxSKILLPOINTS.ReadOnly = true;
            this.textBoxSKILLPOINTS.Size = new System.Drawing.Size(90, 20);
            this.textBoxSKILLPOINTS.TabIndex = 38;
            this.textBoxSKILLPOINTS.Text = "0";
            // 
            // addSTAMBox
            // 
            this.addSTAMBox.Location = new System.Drawing.Point(171, 172);
            this.addSTAMBox.Name = "addSTAMBox";
            this.addSTAMBox.ReadOnly = true;
            this.addSTAMBox.Size = new System.Drawing.Size(24, 20);
            this.addSTAMBox.TabIndex = 40;
            this.addSTAMBox.Text = "0";
            // 
            // AddINTBox
            // 
            this.AddINTBox.Location = new System.Drawing.Point(171, 145);
            this.AddINTBox.Name = "AddINTBox";
            this.AddINTBox.ReadOnly = true;
            this.AddINTBox.Size = new System.Drawing.Size(24, 20);
            this.AddINTBox.TabIndex = 41;
            this.AddINTBox.Text = "0";
            // 
            // AddSTRBox
            // 
            this.AddSTRBox.Location = new System.Drawing.Point(171, 120);
            this.AddSTRBox.Name = "AddSTRBox";
            this.AddSTRBox.ReadOnly = true;
            this.AddSTRBox.Size = new System.Drawing.Size(24, 20);
            this.AddSTRBox.TabIndex = 42;
            this.AddSTRBox.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(24, 20);
            this.textBox4.TabIndex = 43;
            this.textBox4.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(171, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(24, 20);
            this.textBox5.TabIndex = 44;
            this.textBox5.Text = "0";
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.AddSTRBox);
            this.Controls.Add(this.AddINTBox);
            this.Controls.Add(this.addSTAMBox);
            this.Controls.Add(this.textBoxSKILLPOINTS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.REMOVE);
            this.Controls.Add(this.ADDSTAM);
            this.Controls.Add(this.ADDINT);
            this.Controls.Add(this.ADDSTR);
            this.Controls.Add(this.textBoxPlayerSTAM);
            this.Controls.Add(this.textBoxPlayerINT);
            this.Controls.Add(this.textBoxPlayerSTR);
            this.Controls.Add(this.textBoxPlayerMP);
            this.Controls.Add(this.textBoxPlayerHP);
            this.Controls.Add(this.textPName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBonusStam);
            this.Controls.Add(this.textBoxBonusInt);
            this.Controls.Add(this.textBoxBonusStr);
            this.Controls.Add(this.textBoxBonusMana);
            this.Controls.Add(this.textBoxBonusHP);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challengesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem epicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendaryToolStripMenuItem;
        private System.Windows.Forms.ListBox ClassList;
        private System.Windows.Forms.BindingSource classListDataSetBindingSource;
        private classListDataSet classListDataSet;
        private System.Windows.Forms.BindingSource classListDataSetBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBonusHP;
        private System.Windows.Forms.TextBox textBoxBonusMana;
        private System.Windows.Forms.TextBox textBoxBonusStr;
        private System.Windows.Forms.TextBox textBoxBonusInt;
        private System.Windows.Forms.TextBox textBoxBonusStam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPlayerHP;
        private System.Windows.Forms.TextBox textBoxPlayerMP;
        private System.Windows.Forms.TextBox textBoxPlayerSTR;
        private System.Windows.Forms.TextBox textBoxPlayerINT;
        private System.Windows.Forms.TextBox textBoxPlayerSTAM;
        private System.Windows.Forms.Button ADDSTR;
        private System.Windows.Forms.Button ADDINT;
        private System.Windows.Forms.Button ADDSTAM;
        private System.Windows.Forms.Button REMOVE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSKILLPOINTS;
        public System.Windows.Forms.TextBox textPName;
        private System.Windows.Forms.TextBox addSTAMBox;
        private System.Windows.Forms.TextBox AddINTBox;
        private System.Windows.Forms.TextBox AddSTRBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}