namespace AdventureGame
{
    partial class CreateCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCharacter));
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.strengthComboBox = new System.Windows.Forms.ComboBox();
            this.intelligenceComboBox = new System.Windows.Forms.ComboBox();
            this.wisdomComboBox = new System.Windows.Forms.ComboBox();
            this.charismaComboBox = new System.Windows.Forms.ComboBox();
            this.dexterityComboBox = new System.Windows.Forms.ComboBox();
            this.constitutionComboBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
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
            this.raceInfoButton = new System.Windows.Forms.Button();
            this.classInfoButton = new System.Windows.Forms.Button();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Location = new System.Drawing.Point(328, 212);
            this.characterNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.characterNameTextBox.MaxLength = 20;
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(551, 38);
            this.characterNameTextBox.TabIndex = 0;
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Orc"});
            this.raceComboBox.Location = new System.Drawing.Point(328, 283);
            this.raceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(551, 39);
            this.raceComboBox.TabIndex = 1;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Warrior",
            "Sorcerer",
            "Ranger",
            "Cleric"});
            this.classComboBox.Location = new System.Drawing.Point(328, 355);
            this.classComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(551, 39);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // strengthComboBox
            // 
            this.strengthComboBox.FormattingEnabled = true;
            this.strengthComboBox.Items.AddRange(new object[] {
            "16",
            "14",
            "13",
            "12",
            "11",
            "10"});
            this.strengthComboBox.Location = new System.Drawing.Point(328, 429);
            this.strengthComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strengthComboBox.Name = "strengthComboBox";
            this.strengthComboBox.Size = new System.Drawing.Size(121, 39);
            this.strengthComboBox.TabIndex = 5;
            this.strengthComboBox.SelectedIndexChanged += new System.EventHandler(this.strengthComboBox_SelectedIndexChanged);
            // 
            // intelligenceComboBox
            // 
            this.intelligenceComboBox.FormattingEnabled = true;
            this.intelligenceComboBox.Items.AddRange(new object[] {
            "16",
            "14",
            "13",
            "12",
            "11",
            "10"});
            this.intelligenceComboBox.Location = new System.Drawing.Point(328, 796);
            this.intelligenceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intelligenceComboBox.Name = "intelligenceComboBox";
            this.intelligenceComboBox.Size = new System.Drawing.Size(121, 39);
            this.intelligenceComboBox.TabIndex = 10;
            this.intelligenceComboBox.SelectedIndexChanged += new System.EventHandler(this.intelligenceComboBox_SelectedIndexChanged);
            // 
            // wisdomComboBox
            // 
            this.wisdomComboBox.FormattingEnabled = true;
            this.wisdomComboBox.Items.AddRange(new object[] {
            "16",
            "14",
            "13",
            "12",
            "11",
            "10"});
            this.wisdomComboBox.Location = new System.Drawing.Point(328, 720);
            this.wisdomComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wisdomComboBox.Name = "wisdomComboBox";
            this.wisdomComboBox.Size = new System.Drawing.Size(121, 39);
            this.wisdomComboBox.TabIndex = 9;
            this.wisdomComboBox.SelectedIndexChanged += new System.EventHandler(this.wisdomComboBox_SelectedIndexChanged);
            // 
            // charismaComboBox
            // 
            this.charismaComboBox.FormattingEnabled = true;
            this.charismaComboBox.Items.AddRange(new object[] {
            "16",
            "14",
            "13",
            "12",
            "11",
            "10"});
            this.charismaComboBox.Location = new System.Drawing.Point(328, 648);
            this.charismaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charismaComboBox.Name = "charismaComboBox";
            this.charismaComboBox.Size = new System.Drawing.Size(121, 39);
            this.charismaComboBox.TabIndex = 8;
            this.charismaComboBox.SelectedIndexChanged += new System.EventHandler(this.charismaComboBox_SelectedIndexChanged);
            // 
            // dexterityComboBox
            // 
            this.dexterityComboBox.FormattingEnabled = true;
            this.dexterityComboBox.Items.AddRange(new object[] {
            "16",
            "14",
            "13",
            "12",
            "11",
            "10"});
            this.dexterityComboBox.Location = new System.Drawing.Point(328, 574);
            this.dexterityComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dexterityComboBox.Name = "dexterityComboBox";
            this.dexterityComboBox.Size = new System.Drawing.Size(121, 39);
            this.dexterityComboBox.TabIndex = 7;
            this.dexterityComboBox.SelectedIndexChanged += new System.EventHandler(this.dexterityComboBox_SelectedIndexChanged);
            // 
            // constitutionComboBox
            // 
            this.constitutionComboBox.FormattingEnabled = true;
            this.constitutionComboBox.Items.AddRange(new object[] {
            "16",
            "14",
            "13",
            "12",
            "11",
            "10"});
            this.constitutionComboBox.Location = new System.Drawing.Point(328, 500);
            this.constitutionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.constitutionComboBox.Name = "constitutionComboBox";
            this.constitutionComboBox.Size = new System.Drawing.Size(121, 39);
            this.constitutionComboBox.TabIndex = 6;
            this.constitutionComboBox.SelectedIndexChanged += new System.EventHandler(this.constitutionComboBox_SelectedIndexChanged);
            // 
            // createButton
            // 
            this.createButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createButton.BackgroundImage")));
            this.createButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createButton.Font = new System.Drawing.Font("Old English Text MT", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(368, 894);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(208, 67);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetButton.BackgroundImage")));
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Font = new System.Drawing.Font("Old English Text MT", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(600, 894);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(208, 67);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 95);
            this.label1.TabIndex = 11;
            this.label1.Text = "Character Creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 48);
            this.label3.TabIndex = 13;
            this.label3.Text = "Race:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 48);
            this.label4.TabIndex = 14;
            this.label4.Text = "Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 48);
            this.label5.TabIndex = 15;
            this.label5.Text = "Strength:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 48);
            this.label6.TabIndex = 16;
            this.label6.Text = "Constitution:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 48);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dexterity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 640);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 48);
            this.label8.TabIndex = 18;
            this.label8.Text = "Charisma:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 712);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 48);
            this.label9.TabIndex = 19;
            this.label9.Text = "Wisdom:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 791);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 48);
            this.label10.TabIndex = 20;
            this.label10.Text = "Intelligence:";
            // 
            // raceInfoButton
            // 
            this.raceInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raceInfoButton.BackgroundImage")));
            this.raceInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.raceInfoButton.Font = new System.Drawing.Font("Old English Text MT", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceInfoButton.Location = new System.Drawing.Point(925, 274);
            this.raceInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raceInfoButton.Name = "raceInfoButton";
            this.raceInfoButton.Size = new System.Drawing.Size(154, 57);
            this.raceInfoButton.TabIndex = 2;
            this.raceInfoButton.Text = "Info";
            this.raceInfoButton.UseVisualStyleBackColor = true;
            this.raceInfoButton.Click += new System.EventHandler(this.raceInfoButton_Click);
            // 
            // classInfoButton
            // 
            this.classInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("classInfoButton.BackgroundImage")));
            this.classInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.classInfoButton.Font = new System.Drawing.Font("Old English Text MT", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classInfoButton.Location = new System.Drawing.Point(925, 345);
            this.classInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classInfoButton.Name = "classInfoButton";
            this.classInfoButton.Size = new System.Drawing.Size(154, 59);
            this.classInfoButton.TabIndex = 4;
            this.classInfoButton.Text = "Info";
            this.classInfoButton.UseVisualStyleBackColor = true;
            this.classInfoButton.Click += new System.EventHandler(this.classInfoButton_Click);
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthLabel.Location = new System.Drawing.Point(488, 426);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(0, 39);
            this.strengthLabel.TabIndex = 23;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.constitutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constitutionLabel.Location = new System.Drawing.Point(488, 498);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(0, 39);
            this.constitutionLabel.TabIndex = 24;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.BackColor = System.Drawing.Color.Transparent;
            this.dexterityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterityLabel.Location = new System.Drawing.Point(488, 572);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(0, 39);
            this.dexterityLabel.TabIndex = 25;
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.BackColor = System.Drawing.Color.Transparent;
            this.charismaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charismaLabel.Location = new System.Drawing.Point(488, 643);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(0, 39);
            this.charismaLabel.TabIndex = 26;
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.BackColor = System.Drawing.Color.Transparent;
            this.wisdomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomLabel.Location = new System.Drawing.Point(488, 717);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(0, 39);
            this.wisdomLabel.TabIndex = 27;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.intelligenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelligenceLabel.Location = new System.Drawing.Point(488, 793);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(0, 39);
            this.intelligenceLabel.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(621, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 215);
            this.label11.TabIndex = 29;
            this.label11.Text = "* Each number may only be inserted into one field. ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(1178, 951);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 32);
            this.label12.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 49);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMenuToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(76, 45);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // returnToMenuToolStripMenuItem
            // 
            this.returnToMenuToolStripMenuItem.Name = "returnToMenuToolStripMenuItem";
            this.returnToMenuToolStripMenuItem.Size = new System.Drawing.Size(341, 46);
            this.returnToMenuToolStripMenuItem.Text = "Return to Menu";
            this.returnToMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMenuToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(341, 46);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AdventureGame.Properties.Resources.backgound;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 1008);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.dexterityLabel);
            this.Controls.Add(this.constitutionLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.classInfoButton);
            this.Controls.Add(this.raceInfoButton);
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
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.constitutionComboBox);
            this.Controls.Add(this.dexterityComboBox);
            this.Controls.Add(this.charismaComboBox);
            this.Controls.Add(this.wisdomComboBox);
            this.Controls.Add(this.intelligenceComboBox);
            this.Controls.Add(this.strengthComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.characterNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Your Character";
            this.Load += new System.EventHandler(this.CreateCharacter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox strengthComboBox;
        private System.Windows.Forms.ComboBox intelligenceComboBox;
        private System.Windows.Forms.ComboBox wisdomComboBox;
        private System.Windows.Forms.ComboBox charismaComboBox;
        private System.Windows.Forms.ComboBox dexterityComboBox;
        private System.Windows.Forms.ComboBox constitutionComboBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button resetButton;
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
        private System.Windows.Forms.Button raceInfoButton;
        private System.Windows.Forms.Button classInfoButton;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
    }
}