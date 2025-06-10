namespace UI.WinForms.Forms.Characters
{
    partial class CharacterSheetForm
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
            ProgressBarHealth = new ProgressBar();
            LabelHealth = new Label();
            TextBoxName = new TextBox();
            ListBoxInventory = new ListBox();
            GroupBoxGeneral = new GroupBox();
            ProgressBarExperience = new ProgressBar();
            LavelExperience = new Label();
            TextBoxLevel = new TextBox();
            LabelLevel = new Label();
            TextBoxAC = new TextBox();
            LabelAC = new Label();
            LabelDescription = new Label();
            RichTextBoxDescription = new RichTextBox();
            TextBoxArmor = new TextBox();
            TextBoxWeapon = new TextBox();
            LabelArmor = new Label();
            LabelWeapon = new Label();
            GroupBoxInventory = new GroupBox();
            ButtonDrop = new Button();
            ButtonInspect = new Button();
            ButtonUse = new Button();
            LabelCP = new Label();
            LabelSP = new Label();
            TextBoxPP = new TextBox();
            LabelGP = new Label();
            TextBoxGP = new TextBox();
            LabelPP = new Label();
            TextBoxSP = new TextBox();
            TextBoxCP = new TextBox();
            ButtonBack = new Button();
            GroupBoxGeneral.SuspendLayout();
            GroupBoxInventory.SuspendLayout();
            SuspendLayout();
            // 
            // ProgressBarHealth
            // 
            ProgressBarHealth.Location = new Point(63, 51);
            ProgressBarHealth.Name = "ProgressBarHealth";
            ProgressBarHealth.Size = new Size(100, 23);
            ProgressBarHealth.TabIndex = 0;
            // 
            // LabelHealth
            // 
            LabelHealth.AutoSize = true;
            LabelHealth.Location = new Point(6, 54);
            LabelHealth.Name = "LabelHealth";
            LabelHealth.Size = new Size(42, 15);
            LabelHealth.TabIndex = 1;
            LabelHealth.Text = "Health";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(6, 22);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(157, 23);
            TextBoxName.TabIndex = 2;
            // 
            // ListBoxInventory
            // 
            ListBoxInventory.FormattingEnabled = true;
            ListBoxInventory.Location = new Point(6, 22);
            ListBoxInventory.Name = "ListBoxInventory";
            ListBoxInventory.Size = new Size(374, 274);
            ListBoxInventory.TabIndex = 3;
            ListBoxInventory.SelectedIndexChanged += ListBoxInventory_SelectedIndexChanged;
            // 
            // GroupBoxGeneral
            // 
            GroupBoxGeneral.Controls.Add(ProgressBarExperience);
            GroupBoxGeneral.Controls.Add(LavelExperience);
            GroupBoxGeneral.Controls.Add(TextBoxLevel);
            GroupBoxGeneral.Controls.Add(LabelLevel);
            GroupBoxGeneral.Controls.Add(TextBoxAC);
            GroupBoxGeneral.Controls.Add(LabelAC);
            GroupBoxGeneral.Controls.Add(LabelDescription);
            GroupBoxGeneral.Controls.Add(RichTextBoxDescription);
            GroupBoxGeneral.Controls.Add(TextBoxArmor);
            GroupBoxGeneral.Controls.Add(TextBoxWeapon);
            GroupBoxGeneral.Controls.Add(LabelArmor);
            GroupBoxGeneral.Controls.Add(LabelWeapon);
            GroupBoxGeneral.Controls.Add(TextBoxName);
            GroupBoxGeneral.Controls.Add(ProgressBarHealth);
            GroupBoxGeneral.Controls.Add(LabelHealth);
            GroupBoxGeneral.Location = new Point(12, 12);
            GroupBoxGeneral.Name = "GroupBoxGeneral";
            GroupBoxGeneral.Size = new Size(200, 368);
            GroupBoxGeneral.TabIndex = 4;
            GroupBoxGeneral.TabStop = false;
            GroupBoxGeneral.Text = "General Information";
            // 
            // ProgressBarExperience
            // 
            ProgressBarExperience.Location = new Point(63, 109);
            ProgressBarExperience.Name = "ProgressBarExperience";
            ProgressBarExperience.Size = new Size(100, 23);
            ProgressBarExperience.TabIndex = 7;
            // 
            // LavelExperience
            // 
            LavelExperience.AutoSize = true;
            LavelExperience.Location = new Point(6, 112);
            LavelExperience.Name = "LavelExperience";
            LavelExperience.Size = new Size(21, 15);
            LavelExperience.TabIndex = 9;
            LavelExperience.Text = "XP";
            // 
            // TextBoxLevel
            // 
            TextBoxLevel.Location = new Point(63, 80);
            TextBoxLevel.Name = "TextBoxLevel";
            TextBoxLevel.ReadOnly = true;
            TextBoxLevel.Size = new Size(100, 23);
            TextBoxLevel.TabIndex = 10;
            // 
            // LabelLevel
            // 
            LabelLevel.AutoSize = true;
            LabelLevel.Location = new Point(6, 83);
            LabelLevel.Name = "LabelLevel";
            LabelLevel.Size = new Size(34, 15);
            LabelLevel.TabIndex = 8;
            LabelLevel.Text = "Level";
            // 
            // TextBoxAC
            // 
            TextBoxAC.Location = new Point(63, 196);
            TextBoxAC.Name = "TextBoxAC";
            TextBoxAC.ReadOnly = true;
            TextBoxAC.Size = new Size(100, 23);
            TextBoxAC.TabIndex = 10;
            // 
            // LabelAC
            // 
            LabelAC.AutoSize = true;
            LabelAC.Location = new Point(7, 199);
            LabelAC.Name = "LabelAC";
            LabelAC.Size = new Size(23, 15);
            LabelAC.TabIndex = 9;
            LabelAC.Text = "AC";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(6, 222);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(67, 15);
            LabelDescription.TabIndex = 8;
            LabelDescription.Text = "Description";
            // 
            // RichTextBoxDescription
            // 
            RichTextBoxDescription.Location = new Point(6, 240);
            RichTextBoxDescription.Name = "RichTextBoxDescription";
            RichTextBoxDescription.Size = new Size(188, 120);
            RichTextBoxDescription.TabIndex = 7;
            RichTextBoxDescription.Text = "";
            // 
            // TextBoxArmor
            // 
            TextBoxArmor.Location = new Point(63, 167);
            TextBoxArmor.Name = "TextBoxArmor";
            TextBoxArmor.ReadOnly = true;
            TextBoxArmor.Size = new Size(100, 23);
            TextBoxArmor.TabIndex = 6;
            // 
            // TextBoxWeapon
            // 
            TextBoxWeapon.Location = new Point(63, 138);
            TextBoxWeapon.Name = "TextBoxWeapon";
            TextBoxWeapon.ReadOnly = true;
            TextBoxWeapon.Size = new Size(100, 23);
            TextBoxWeapon.TabIndex = 5;
            // 
            // LabelArmor
            // 
            LabelArmor.AutoSize = true;
            LabelArmor.Location = new Point(7, 170);
            LabelArmor.Name = "LabelArmor";
            LabelArmor.Size = new Size(41, 15);
            LabelArmor.TabIndex = 4;
            LabelArmor.Text = "Armor";
            // 
            // LabelWeapon
            // 
            LabelWeapon.AutoSize = true;
            LabelWeapon.Location = new Point(6, 141);
            LabelWeapon.Name = "LabelWeapon";
            LabelWeapon.Size = new Size(51, 15);
            LabelWeapon.TabIndex = 3;
            LabelWeapon.Text = "Weapon";
            // 
            // GroupBoxInventory
            // 
            GroupBoxInventory.Controls.Add(ButtonDrop);
            GroupBoxInventory.Controls.Add(ButtonInspect);
            GroupBoxInventory.Controls.Add(ButtonUse);
            GroupBoxInventory.Controls.Add(LabelCP);
            GroupBoxInventory.Controls.Add(ListBoxInventory);
            GroupBoxInventory.Controls.Add(LabelSP);
            GroupBoxInventory.Controls.Add(TextBoxPP);
            GroupBoxInventory.Controls.Add(LabelGP);
            GroupBoxInventory.Controls.Add(TextBoxGP);
            GroupBoxInventory.Controls.Add(LabelPP);
            GroupBoxInventory.Controls.Add(TextBoxSP);
            GroupBoxInventory.Controls.Add(TextBoxCP);
            GroupBoxInventory.Location = new Point(218, 12);
            GroupBoxInventory.Name = "GroupBoxInventory";
            GroupBoxInventory.Size = new Size(459, 338);
            GroupBoxInventory.TabIndex = 5;
            GroupBoxInventory.TabStop = false;
            GroupBoxInventory.Text = "Inventory";
            // 
            // ButtonDrop
            // 
            ButtonDrop.Location = new Point(168, 309);
            ButtonDrop.Name = "ButtonDrop";
            ButtonDrop.Size = new Size(75, 23);
            ButtonDrop.TabIndex = 16;
            ButtonDrop.Text = "Drop";
            ButtonDrop.UseVisualStyleBackColor = true;
            ButtonDrop.Click += ButtonDrop_Click;
            // 
            // ButtonInspect
            // 
            ButtonInspect.Location = new Point(87, 309);
            ButtonInspect.Name = "ButtonInspect";
            ButtonInspect.Size = new Size(75, 23);
            ButtonInspect.TabIndex = 15;
            ButtonInspect.Text = "Inspect";
            ButtonInspect.UseVisualStyleBackColor = true;
            ButtonInspect.Click += ButtonInspect_Click;
            // 
            // ButtonUse
            // 
            ButtonUse.Location = new Point(6, 309);
            ButtonUse.Name = "ButtonUse";
            ButtonUse.Size = new Size(75, 23);
            ButtonUse.TabIndex = 14;
            ButtonUse.Text = "Use";
            ButtonUse.UseVisualStyleBackColor = true;
            ButtonUse.Click += ButtonUse_Click;
            // 
            // LabelCP
            // 
            LabelCP.AutoSize = true;
            LabelCP.Location = new Point(432, 112);
            LabelCP.Name = "LabelCP";
            LabelCP.Size = new Size(22, 15);
            LabelCP.TabIndex = 13;
            LabelCP.Text = "CP";
            // 
            // LabelSP
            // 
            LabelSP.AutoSize = true;
            LabelSP.Location = new Point(432, 83);
            LabelSP.Name = "LabelSP";
            LabelSP.Size = new Size(20, 15);
            LabelSP.TabIndex = 12;
            LabelSP.Text = "SP";
            // 
            // TextBoxPP
            // 
            TextBoxPP.Location = new Point(386, 22);
            TextBoxPP.Name = "TextBoxPP";
            TextBoxPP.ReadOnly = true;
            TextBoxPP.Size = new Size(40, 23);
            TextBoxPP.TabIndex = 6;
            // 
            // LabelGP
            // 
            LabelGP.AutoSize = true;
            LabelGP.Location = new Point(432, 54);
            LabelGP.Name = "LabelGP";
            LabelGP.Size = new Size(22, 15);
            LabelGP.TabIndex = 11;
            LabelGP.Text = "GP";
            // 
            // TextBoxGP
            // 
            TextBoxGP.Location = new Point(386, 51);
            TextBoxGP.Name = "TextBoxGP";
            TextBoxGP.ReadOnly = true;
            TextBoxGP.Size = new Size(40, 23);
            TextBoxGP.TabIndex = 7;
            // 
            // LabelPP
            // 
            LabelPP.AutoSize = true;
            LabelPP.Location = new Point(432, 25);
            LabelPP.Name = "LabelPP";
            LabelPP.Size = new Size(21, 15);
            LabelPP.TabIndex = 10;
            LabelPP.Text = "PP";
            // 
            // TextBoxSP
            // 
            TextBoxSP.Location = new Point(386, 80);
            TextBoxSP.Name = "TextBoxSP";
            TextBoxSP.ReadOnly = true;
            TextBoxSP.Size = new Size(40, 23);
            TextBoxSP.TabIndex = 8;
            // 
            // TextBoxCP
            // 
            TextBoxCP.Location = new Point(386, 109);
            TextBoxCP.Name = "TextBoxCP";
            TextBoxCP.ReadOnly = true;
            TextBoxCP.Size = new Size(40, 23);
            TextBoxCP.TabIndex = 9;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 386);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(75, 23);
            ButtonBack.TabIndex = 6;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // CharacterSheetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 425);
            Controls.Add(ButtonBack);
            Controls.Add(GroupBoxInventory);
            Controls.Add(GroupBoxGeneral);
            Name = "CharacterSheetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Sheet";
            Load += CharacterSheetForm_Load;
            GroupBoxGeneral.ResumeLayout(false);
            GroupBoxGeneral.PerformLayout();
            GroupBoxInventory.ResumeLayout(false);
            GroupBoxInventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar ProgressBarHealth;
        private Label LabelHealth;
        private TextBox TextBoxName;
        private ListBox ListBoxInventory;
        private GroupBox GroupBoxGeneral;
        private GroupBox GroupBoxInventory;
        private TextBox TextBoxArmor;
        private TextBox TextBoxWeapon;
        private Label LabelArmor;
        private Label LabelWeapon;
        private TextBox TextBoxPP;
        private TextBox TextBoxGP;
        private TextBox TextBoxSP;
        private TextBox TextBoxCP;
        private Label LabelPP;
        private Label LabelGP;
        private Label LabelSP;
        private Label LabelCP;
        private Button ButtonDrop;
        private Button ButtonInspect;
        private Button ButtonUse;
        private Button ButtonBack;
        private Label LabelDescription;
        private RichTextBox RichTextBoxDescription;
        private TextBox TextBoxAC;
        private Label LabelAC;
        private ProgressBar ProgressBarExperience;
        private Label LavelExperience;
        private TextBox TextBoxLevel;
        private Label LabelLevel;
    }
}