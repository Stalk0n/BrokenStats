﻿namespace BrokenStats.UserControls
{
    partial class UC_EssenceCalculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customComboBoxRanga = new CustomControls.CustomComboBox();
            customComboBoxGwiazdki = new CustomControls.CustomComboBox();
            customTextBoxCenaOdlamkow = new CustomControls.CustomTextBox();
            customTextBoxCenaEsencji = new CustomControls.CustomTextBox();
            customTextBoxCenaPlatyny = new CustomControls.CustomTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            toggleButtonTargPremium = new CustomControls.ToggleButton();
            toggleButtonSynergetyk = new CustomControls.ToggleButton();
            label2 = new Label();
            toggleButtonSetItem = new CustomControls.ToggleButton();
            panel1 = new Panel();
            toggleButtonInhibitor = new CustomControls.ToggleButton();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelCenaWOdlamkachPo = new Label();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            labelIloscEsencji = new Label();
            labelIloscOdlamkow = new Label();
            labelCenaWEsencjachPo = new Label();
            customTextBoxCenaPrzedmiotu = new CustomControls.CustomTextBox();
            label11 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelProfit = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // customComboBoxRanga
            // 
            customComboBoxRanga.BackColor = Color.WhiteSmoke;
            customComboBoxRanga.BorderColor = Color.MediumSlateBlue;
            customComboBoxRanga.BorderSize = 1;
            customComboBoxRanga.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBoxRanga.Font = new Font("Segoe UI", 10F);
            customComboBoxRanga.ForeColor = Color.DimGray;
            customComboBoxRanga.IconColor = Color.MediumSlateBlue;
            customComboBoxRanga.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" });
            customComboBoxRanga.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBoxRanga.ListTextColor = Color.DimGray;
            customComboBoxRanga.Location = new Point(631, 93);
            customComboBoxRanga.MinimumSize = new Size(71, 35);
            customComboBoxRanga.Name = "customComboBoxRanga";
            customComboBoxRanga.Padding = new Padding(1);
            customComboBoxRanga.Size = new Size(71, 35);
            customComboBoxRanga.TabIndex = 45;
            customComboBoxRanga.Texts = "";
            customComboBoxRanga.OnSelectedIndexChanged += customComboBoxRanga_OnSelectedIndexChanged;
            // 
            // customComboBoxGwiazdki
            // 
            customComboBoxGwiazdki.BackColor = Color.WhiteSmoke;
            customComboBoxGwiazdki.BorderColor = Color.MediumSlateBlue;
            customComboBoxGwiazdki.BorderSize = 1;
            customComboBoxGwiazdki.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBoxGwiazdki.Font = new Font("Segoe UI", 10F);
            customComboBoxGwiazdki.ForeColor = Color.DimGray;
            customComboBoxGwiazdki.IconColor = Color.MediumSlateBlue;
            customComboBoxGwiazdki.Items.AddRange(new object[] { "1* - Bronze 1", "2* - Bronze 2", "3* - Bronze 3", "4* - Silver 1", "5* - Silver 2", "6* - Silver 3", "7* - Gold 1", "8* - Gold 2", "9* - Gold 3" });
            customComboBoxGwiazdki.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBoxGwiazdki.ListTextColor = Color.DimGray;
            customComboBoxGwiazdki.Location = new Point(478, 93);
            customComboBoxGwiazdki.MinimumSize = new Size(71, 35);
            customComboBoxGwiazdki.Name = "customComboBoxGwiazdki";
            customComboBoxGwiazdki.Padding = new Padding(1);
            customComboBoxGwiazdki.Size = new Size(146, 35);
            customComboBoxGwiazdki.TabIndex = 46;
            customComboBoxGwiazdki.Texts = "";
            customComboBoxGwiazdki.OnSelectedIndexChanged += customComboBoxGwiazdki_OnSelectedIndexChanged;
            // 
            // customTextBoxCenaOdlamkow
            // 
            customTextBoxCenaOdlamkow.BackColor = SystemColors.Window;
            customTextBoxCenaOdlamkow.BorderColor = Color.MediumSlateBlue;
            customTextBoxCenaOdlamkow.BorderFocusColor = Color.HotPink;
            customTextBoxCenaOdlamkow.BorderRadius = 0;
            customTextBoxCenaOdlamkow.BorderSize = 2;
            customTextBoxCenaOdlamkow.Font = new Font("Segoe UI", 9.5F);
            customTextBoxCenaOdlamkow.ForeColor = Color.DimGray;
            customTextBoxCenaOdlamkow.Location = new Point(325, 92);
            customTextBoxCenaOdlamkow.Margin = new Padding(5, 4, 5, 4);
            customTextBoxCenaOdlamkow.Multiline = false;
            customTextBoxCenaOdlamkow.Name = "customTextBoxCenaOdlamkow";
            customTextBoxCenaOdlamkow.Padding = new Padding(7, 7, 7, 7);
            customTextBoxCenaOdlamkow.PasswordChar = false;
            customTextBoxCenaOdlamkow.PlaceholderColor = Color.DarkGray;
            customTextBoxCenaOdlamkow.PlaceholderText = "Cena odłamków";
            customTextBoxCenaOdlamkow.SelectionLength = 0;
            customTextBoxCenaOdlamkow.SelectionStart = 0;
            customTextBoxCenaOdlamkow.Size = new Size(129, 36);
            customTextBoxCenaOdlamkow.TabIndex = 42;
            customTextBoxCenaOdlamkow.Texts = "";
            customTextBoxCenaOdlamkow.UnderlinedStyle = false;
            customTextBoxCenaOdlamkow._TextChanged += customTextBoxCenaOdlamkow__TextChanged;
            // 
            // customTextBoxCenaEsencji
            // 
            customTextBoxCenaEsencji.BackColor = SystemColors.Window;
            customTextBoxCenaEsencji.BorderColor = Color.MediumSlateBlue;
            customTextBoxCenaEsencji.BorderFocusColor = Color.HotPink;
            customTextBoxCenaEsencji.BorderRadius = 0;
            customTextBoxCenaEsencji.BorderSize = 2;
            customTextBoxCenaEsencji.Font = new Font("Segoe UI", 9.5F);
            customTextBoxCenaEsencji.ForeColor = Color.DimGray;
            customTextBoxCenaEsencji.Location = new Point(186, 92);
            customTextBoxCenaEsencji.Margin = new Padding(5, 4, 5, 4);
            customTextBoxCenaEsencji.Multiline = false;
            customTextBoxCenaEsencji.Name = "customTextBoxCenaEsencji";
            customTextBoxCenaEsencji.Padding = new Padding(7, 7, 7, 7);
            customTextBoxCenaEsencji.PasswordChar = false;
            customTextBoxCenaEsencji.PlaceholderColor = Color.DarkGray;
            customTextBoxCenaEsencji.PlaceholderText = "Cena esencji";
            customTextBoxCenaEsencji.SelectionLength = 0;
            customTextBoxCenaEsencji.SelectionStart = 0;
            customTextBoxCenaEsencji.Size = new Size(129, 36);
            customTextBoxCenaEsencji.TabIndex = 43;
            customTextBoxCenaEsencji.Texts = "";
            customTextBoxCenaEsencji.UnderlinedStyle = false;
            customTextBoxCenaEsencji._TextChanged += customTextBoxCenaEsencji__TextChanged;
            // 
            // customTextBoxCenaPlatyny
            // 
            customTextBoxCenaPlatyny.BackColor = SystemColors.Window;
            customTextBoxCenaPlatyny.BorderColor = Color.MediumSlateBlue;
            customTextBoxCenaPlatyny.BorderFocusColor = Color.HotPink;
            customTextBoxCenaPlatyny.BorderRadius = 0;
            customTextBoxCenaPlatyny.BorderSize = 2;
            customTextBoxCenaPlatyny.Font = new Font("Segoe UI", 9.5F);
            customTextBoxCenaPlatyny.ForeColor = Color.DimGray;
            customTextBoxCenaPlatyny.Location = new Point(48, 92);
            customTextBoxCenaPlatyny.Margin = new Padding(5, 4, 5, 4);
            customTextBoxCenaPlatyny.Multiline = false;
            customTextBoxCenaPlatyny.Name = "customTextBoxCenaPlatyny";
            customTextBoxCenaPlatyny.Padding = new Padding(7, 7, 7, 7);
            customTextBoxCenaPlatyny.PasswordChar = false;
            customTextBoxCenaPlatyny.PlaceholderColor = Color.DarkGray;
            customTextBoxCenaPlatyny.PlaceholderText = "Cena plat. za szt.";
            customTextBoxCenaPlatyny.SelectionLength = 0;
            customTextBoxCenaPlatyny.SelectionStart = 0;
            customTextBoxCenaPlatyny.Size = new Size(129, 36);
            customTextBoxCenaPlatyny.TabIndex = 44;
            customTextBoxCenaPlatyny.Texts = "";
            customTextBoxCenaPlatyny.UnderlinedStyle = false;
            customTextBoxCenaPlatyny._TextChanged += customTextBoxCenaPlatyny__TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(631, 71);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 40;
            label7.Text = "Ranga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(478, 71);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 39;
            label6.Text = "Gwiazdki";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(785, 149);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 38;
            label5.Text = "Targ Premium";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(785, 123);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 37;
            label4.Text = "Synergetyk";
            // 
            // toggleButtonTargPremium
            // 
            toggleButtonTargPremium.AutoSize = true;
            toggleButtonTargPremium.Location = new Point(734, 148);
            toggleButtonTargPremium.MinimumSize = new Size(45, 21);
            toggleButtonTargPremium.Name = "toggleButtonTargPremium";
            toggleButtonTargPremium.OffBackColor = Color.Gray;
            toggleButtonTargPremium.OffToggleColor = Color.Gainsboro;
            toggleButtonTargPremium.OnBackColor = Color.MediumSlateBlue;
            toggleButtonTargPremium.OnToggleColor = Color.WhiteSmoke;
            toggleButtonTargPremium.Size = new Size(45, 21);
            toggleButtonTargPremium.TabIndex = 35;
            toggleButtonTargPremium.UseVisualStyleBackColor = true;
            toggleButtonTargPremium.CheckedChanged += toggleButtonTargPremium_CheckedChanged;
            // 
            // toggleButtonSynergetyk
            // 
            toggleButtonSynergetyk.AutoSize = true;
            toggleButtonSynergetyk.Location = new Point(734, 121);
            toggleButtonSynergetyk.MinimumSize = new Size(45, 21);
            toggleButtonSynergetyk.Name = "toggleButtonSynergetyk";
            toggleButtonSynergetyk.OffBackColor = Color.Gray;
            toggleButtonSynergetyk.OffToggleColor = Color.Gainsboro;
            toggleButtonSynergetyk.OnBackColor = Color.MediumSlateBlue;
            toggleButtonSynergetyk.OnToggleColor = Color.WhiteSmoke;
            toggleButtonSynergetyk.Size = new Size(45, 21);
            toggleButtonSynergetyk.TabIndex = 36;
            toggleButtonSynergetyk.UseVisualStyleBackColor = true;
            toggleButtonSynergetyk.CheckedChanged += toggleButtonSynergetyk_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(785, 95);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 34;
            label2.Text = "Set Item";
            // 
            // toggleButtonSetItem
            // 
            toggleButtonSetItem.AutoSize = true;
            toggleButtonSetItem.Location = new Point(734, 95);
            toggleButtonSetItem.MinimumSize = new Size(45, 21);
            toggleButtonSetItem.Name = "toggleButtonSetItem";
            toggleButtonSetItem.OffBackColor = Color.Gray;
            toggleButtonSetItem.OffToggleColor = Color.Gainsboro;
            toggleButtonSetItem.OnBackColor = Color.MediumSlateBlue;
            toggleButtonSetItem.OnToggleColor = Color.WhiteSmoke;
            toggleButtonSetItem.Size = new Size(45, 21);
            toggleButtonSetItem.TabIndex = 33;
            toggleButtonSetItem.UseVisualStyleBackColor = true;
            toggleButtonSetItem.CheckedChanged += toggleButtonSetItem_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 67);
            panel1.TabIndex = 47;
            // 
            // toggleButtonInhibitor
            // 
            toggleButtonInhibitor.AutoSize = true;
            toggleButtonInhibitor.Location = new Point(734, 175);
            toggleButtonInhibitor.MinimumSize = new Size(45, 21);
            toggleButtonInhibitor.Name = "toggleButtonInhibitor";
            toggleButtonInhibitor.OffBackColor = Color.Gray;
            toggleButtonInhibitor.OffToggleColor = Color.Gainsboro;
            toggleButtonInhibitor.OnBackColor = Color.MediumSlateBlue;
            toggleButtonInhibitor.OnToggleColor = Color.WhiteSmoke;
            toggleButtonInhibitor.Size = new Size(45, 21);
            toggleButtonInhibitor.TabIndex = 48;
            toggleButtonInhibitor.UseVisualStyleBackColor = true;
            toggleButtonInhibitor.CheckedChanged += toggleButtonInhibitor_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(785, 176);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 49;
            label1.Text = "Inhibitor";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(labelCenaWOdlamkachPo, 3, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(label10, 3, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(labelIloscEsencji, 0, 1);
            tableLayoutPanel1.Controls.Add(labelIloscOdlamkow, 1, 1);
            tableLayoutPanel1.Controls.Add(labelCenaWEsencjachPo, 2, 1);
            tableLayoutPanel1.Location = new Point(48, 221);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(811, 133);
            tableLayoutPanel1.TabIndex = 50;
            // 
            // labelCenaWOdlamkachPo
            // 
            labelCenaWOdlamkachPo.AutoSize = true;
            labelCenaWOdlamkachPo.BackColor = Color.Gainsboro;
            labelCenaWOdlamkachPo.Dock = DockStyle.Fill;
            labelCenaWOdlamkachPo.Location = new Point(607, 67);
            labelCenaWOdlamkachPo.Margin = new Padding(1, 1, 0, 0);
            labelCenaWOdlamkachPo.Name = "labelCenaWOdlamkachPo";
            labelCenaWOdlamkachPo.Size = new Size(204, 66);
            labelCenaWOdlamkachPo.TabIndex = 7;
            labelCenaWOdlamkachPo.Text = "label14";
            labelCenaWOdlamkachPo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(196, 196, 196);
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(203, 0);
            label3.Margin = new Padding(1, 0, 1, 1);
            label3.Name = "label3";
            label3.Size = new Size(200, 65);
            label3.TabIndex = 0;
            label3.Text = "Ilość odłamków";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(196, 196, 196);
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(405, 0);
            label9.Margin = new Padding(1, 0, 1, 1);
            label9.Name = "label9";
            label9.Size = new Size(200, 65);
            label9.TabIndex = 2;
            label9.Text = "Cena w esencjach";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(196, 196, 196);
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(607, 0);
            label10.Margin = new Padding(1, 0, 0, 1);
            label10.Name = "label10";
            label10.Size = new Size(204, 65);
            label10.TabIndex = 3;
            label10.Text = "Cena w odłamkach";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(196, 196, 196);
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(0, 0, 1, 1);
            label8.Name = "label8";
            label8.Size = new Size(201, 65);
            label8.TabIndex = 1;
            label8.Text = "Ilość esencji";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIloscEsencji
            // 
            labelIloscEsencji.AutoSize = true;
            labelIloscEsencji.BackColor = Color.Gainsboro;
            labelIloscEsencji.Dock = DockStyle.Fill;
            labelIloscEsencji.Location = new Point(0, 67);
            labelIloscEsencji.Margin = new Padding(0, 1, 1, 0);
            labelIloscEsencji.Name = "labelIloscEsencji";
            labelIloscEsencji.Size = new Size(201, 66);
            labelIloscEsencji.TabIndex = 4;
            labelIloscEsencji.Text = "label11";
            labelIloscEsencji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIloscOdlamkow
            // 
            labelIloscOdlamkow.AutoSize = true;
            labelIloscOdlamkow.BackColor = Color.Gainsboro;
            labelIloscOdlamkow.Dock = DockStyle.Fill;
            labelIloscOdlamkow.Location = new Point(203, 67);
            labelIloscOdlamkow.Margin = new Padding(1, 1, 1, 0);
            labelIloscOdlamkow.Name = "labelIloscOdlamkow";
            labelIloscOdlamkow.Size = new Size(200, 66);
            labelIloscOdlamkow.TabIndex = 5;
            labelIloscOdlamkow.Text = "label12";
            labelIloscOdlamkow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCenaWEsencjachPo
            // 
            labelCenaWEsencjachPo.AutoSize = true;
            labelCenaWEsencjachPo.BackColor = Color.Gainsboro;
            labelCenaWEsencjachPo.Dock = DockStyle.Fill;
            labelCenaWEsencjachPo.Location = new Point(405, 67);
            labelCenaWEsencjachPo.Margin = new Padding(1, 1, 1, 0);
            labelCenaWEsencjachPo.Name = "labelCenaWEsencjachPo";
            labelCenaWEsencjachPo.Size = new Size(200, 66);
            labelCenaWEsencjachPo.TabIndex = 6;
            labelCenaWEsencjachPo.Text = "label13";
            labelCenaWEsencjachPo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customTextBoxCenaPrzedmiotu
            // 
            customTextBoxCenaPrzedmiotu.BackColor = SystemColors.Window;
            customTextBoxCenaPrzedmiotu.BorderColor = Color.MediumSlateBlue;
            customTextBoxCenaPrzedmiotu.BorderFocusColor = Color.HotPink;
            customTextBoxCenaPrzedmiotu.BorderRadius = 0;
            customTextBoxCenaPrzedmiotu.BorderSize = 2;
            customTextBoxCenaPrzedmiotu.Font = new Font("Segoe UI", 9.5F);
            customTextBoxCenaPrzedmiotu.ForeColor = Color.DimGray;
            customTextBoxCenaPrzedmiotu.Location = new Point(186, 148);
            customTextBoxCenaPrzedmiotu.Margin = new Padding(5, 4, 5, 4);
            customTextBoxCenaPrzedmiotu.Multiline = false;
            customTextBoxCenaPrzedmiotu.Name = "customTextBoxCenaPrzedmiotu";
            customTextBoxCenaPrzedmiotu.Padding = new Padding(7, 7, 7, 7);
            customTextBoxCenaPrzedmiotu.PasswordChar = false;
            customTextBoxCenaPrzedmiotu.PlaceholderColor = Color.DarkGray;
            customTextBoxCenaPrzedmiotu.PlaceholderText = "Cena przedmiotu";
            customTextBoxCenaPrzedmiotu.SelectionLength = 0;
            customTextBoxCenaPrzedmiotu.SelectionStart = 0;
            customTextBoxCenaPrzedmiotu.Size = new Size(129, 36);
            customTextBoxCenaPrzedmiotu.TabIndex = 51;
            customTextBoxCenaPrzedmiotu.Texts = "";
            customTextBoxCenaPrzedmiotu.UnderlinedStyle = false;
            customTextBoxCenaPrzedmiotu._TextChanged += customTextBoxCenaPrzedmiotu__TextChanged;
            customTextBoxCenaPrzedmiotu.Leave += customTextBoxCenaPrzedmiotu__Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(196, 196, 196);
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(0, 0);
            label11.Margin = new Padding(0, 0, 0, 1);
            label11.Name = "label11";
            label11.Size = new Size(200, 64);
            label11.TabIndex = 52;
            label11.Text = "Profit";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlDarkDark;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelProfit, 0, 1);
            tableLayoutPanel2.Controls.Add(label11, 0, 0);
            tableLayoutPanel2.Location = new Point(354, 393);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(200, 131);
            tableLayoutPanel2.TabIndex = 53;
            // 
            // labelProfit
            // 
            labelProfit.AutoSize = true;
            labelProfit.BackColor = Color.Gainsboro;
            labelProfit.Dock = DockStyle.Fill;
            labelProfit.Location = new Point(0, 66);
            labelProfit.Margin = new Padding(0, 1, 0, 0);
            labelProfit.Name = "labelProfit";
            labelProfit.Size = new Size(200, 65);
            labelProfit.TabIndex = 53;
            labelProfit.Text = "label12";
            labelProfit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_EssenceCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(customTextBoxCenaPrzedmiotu);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(toggleButtonInhibitor);
            Controls.Add(panel1);
            Controls.Add(customComboBoxRanga);
            Controls.Add(customComboBoxGwiazdki);
            Controls.Add(customTextBoxCenaOdlamkow);
            Controls.Add(customTextBoxCenaEsencji);
            Controls.Add(customTextBoxCenaPlatyny);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(toggleButtonTargPremium);
            Controls.Add(toggleButtonSynergetyk);
            Controls.Add(label2);
            Controls.Add(toggleButtonSetItem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_EssenceCalculator";
            Size = new Size(914, 600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomComboBox customComboBoxRanga;
        private CustomControls.CustomComboBox customComboBoxGwiazdki;
        private CustomControls.CustomTextBox customTextBoxCenaOdlamkow;
        private CustomControls.CustomTextBox customTextBoxCenaEsencji;
        private CustomControls.CustomTextBox customTextBoxCenaPlatyny;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private CustomControls.ToggleButton toggleButtonTargPremium;
        private CustomControls.ToggleButton toggleButtonSynergetyk;
        private Label label2;
        private CustomControls.ToggleButton toggleButtonSetItem;
        private Panel panel1;
        private CustomControls.ToggleButton toggleButtonInhibitor;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label labelIloscEsencji;
        private Label labelIloscOdlamkow;
        private Label labelCenaWEsencjachPo;
        private Label labelCenaWOdlamkachPo;
        private CustomControls.CustomTextBox customTextBoxCenaPrzedmiotu;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelProfit;
    }
}
