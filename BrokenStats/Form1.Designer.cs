
using BrokenStats.Tables;

namespace BrokenStats
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewChatLogMessage = new DataGridView();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messagesBindingSource = new BindingSource(components);
            chatLogNicknameBindingSource = new BindingSource(components);
            dataGridViewChatNickname = new DataGridView();
            nickDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewBattleLogNickname = new DataGridView();
            nickDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            battleLogNicknameBindingSource = new BindingSource(components);
            dataGridViewBattleLogLogs = new DataGridView();
            dataDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            experienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            psychoExperienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            goldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            droppeditemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            opponentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            battleLogBindingSource = new BindingSource(components);
            tabPage3 = new TabPage();
            customButton1 = new CustomControls.CustomButton();
            customComboBox2 = new CustomControls.CustomComboBox();
            customComboBox1 = new CustomControls.CustomComboBox();
            customTextBox3 = new CustomControls.CustomTextBox();
            customTextBox2 = new CustomControls.CustomTextBox();
            customTextBox1 = new CustomControls.CustomTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            toggleButton3 = new CustomControls.ToggleButton();
            toggleButton2 = new CustomControls.ToggleButton();
            label2 = new Label();
            toggleButton1 = new CustomControls.ToggleButton();
            label3 = new Label();
            chart_label = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatLogMessage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messagesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatLogNicknameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatNickname).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBattleLogNickname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battleLogNicknameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBattleLogLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1079, 600);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1071, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ChatLogs";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dataGridViewChatLogMessage, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewChatNickname, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1070, 521);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // dataGridViewChatLogMessage
            // 
            dataGridViewChatLogMessage.AllowUserToAddRows = false;
            dataGridViewChatLogMessage.AllowUserToDeleteRows = false;
            dataGridViewChatLogMessage.AutoGenerateColumns = false;
            dataGridViewChatLogMessage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChatLogMessage.Columns.AddRange(new DataGridViewColumn[] { dataDataGridViewTextBoxColumn, messageDataGridViewTextBoxColumn });
            dataGridViewChatLogMessage.DataSource = messagesBindingSource;
            dataGridViewChatLogMessage.Location = new Point(455, 4);
            dataGridViewChatLogMessage.Margin = new Padding(3, 4, 3, 4);
            dataGridViewChatLogMessage.Name = "dataGridViewChatLogMessage";
            dataGridViewChatLogMessage.ReadOnly = true;
            dataGridViewChatLogMessage.RowHeadersWidth = 51;
            dataGridViewChatLogMessage.Size = new Size(774, 513);
            dataGridViewChatLogMessage.TabIndex = 5;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Date";
            dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            messageDataGridViewTextBoxColumn.HeaderText = "Message";
            messageDataGridViewTextBoxColumn.MinimumWidth = 6;
            messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            messageDataGridViewTextBoxColumn.ReadOnly = true;
            messageDataGridViewTextBoxColumn.Width = 125;
            // 
            // messagesBindingSource
            // 
            messagesBindingSource.DataMember = "Messages";
            messagesBindingSource.DataSource = chatLogNicknameBindingSource;
            // 
            // chatLogNicknameBindingSource
            // 
            chatLogNicknameBindingSource.DataSource = typeof(ChatLogNickname);
            // 
            // dataGridViewChatNickname
            // 
            dataGridViewChatNickname.AllowUserToAddRows = false;
            dataGridViewChatNickname.AllowUserToDeleteRows = false;
            dataGridViewChatNickname.AutoGenerateColumns = false;
            dataGridViewChatNickname.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChatNickname.Columns.AddRange(new DataGridViewColumn[] { nickDataGridViewTextBoxColumn });
            dataGridViewChatNickname.DataSource = chatLogNicknameBindingSource;
            dataGridViewChatNickname.Location = new Point(3, 4);
            dataGridViewChatNickname.Margin = new Padding(3, 4, 3, 4);
            dataGridViewChatNickname.Name = "dataGridViewChatNickname";
            dataGridViewChatNickname.ReadOnly = true;
            dataGridViewChatNickname.RowHeadersWidth = 51;
            dataGridViewChatNickname.Size = new Size(446, 513);
            dataGridViewChatNickname.TabIndex = 4;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            nickDataGridViewTextBoxColumn.MinimumWidth = 6;
            nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            nickDataGridViewTextBoxColumn.ReadOnly = true;
            nickDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(664, 528);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Tester";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1071, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(dataGridViewBattleLogNickname, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewBattleLogLogs, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1070, 563);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewBattleLogNickname
            // 
            dataGridViewBattleLogNickname.AllowUserToAddRows = false;
            dataGridViewBattleLogNickname.AllowUserToDeleteRows = false;
            dataGridViewBattleLogNickname.AutoGenerateColumns = false;
            dataGridViewBattleLogNickname.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBattleLogNickname.Columns.AddRange(new DataGridViewColumn[] { nickDataGridViewTextBoxColumn1 });
            dataGridViewBattleLogNickname.DataSource = battleLogNicknameBindingSource;
            dataGridViewBattleLogNickname.Location = new Point(3, 4);
            dataGridViewBattleLogNickname.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBattleLogNickname.Name = "dataGridViewBattleLogNickname";
            dataGridViewBattleLogNickname.ReadOnly = true;
            dataGridViewBattleLogNickname.RowHeadersWidth = 51;
            dataGridViewBattleLogNickname.Size = new Size(274, 555);
            dataGridViewBattleLogNickname.TabIndex = 0;
            // 
            // nickDataGridViewTextBoxColumn1
            // 
            nickDataGridViewTextBoxColumn1.DataPropertyName = "Nick";
            nickDataGridViewTextBoxColumn1.HeaderText = "Nick";
            nickDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nickDataGridViewTextBoxColumn1.Name = "nickDataGridViewTextBoxColumn1";
            nickDataGridViewTextBoxColumn1.ReadOnly = true;
            nickDataGridViewTextBoxColumn1.Width = 125;
            // 
            // battleLogNicknameBindingSource
            // 
            battleLogNicknameBindingSource.DataSource = typeof(BattleLogNickname);
            // 
            // dataGridViewBattleLogLogs
            // 
            dataGridViewBattleLogLogs.AllowUserToAddRows = false;
            dataGridViewBattleLogLogs.AllowUserToDeleteRows = false;
            dataGridViewBattleLogLogs.AutoGenerateColumns = false;
            dataGridViewBattleLogLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBattleLogLogs.Columns.AddRange(new DataGridViewColumn[] { dataDataGridViewTextBoxColumn1, experienceDataGridViewTextBoxColumn, psychoExperienceDataGridViewTextBoxColumn, goldDataGridViewTextBoxColumn, droppeditemsDataGridViewTextBoxColumn, opponentsDataGridViewTextBoxColumn });
            dataGridViewBattleLogLogs.DataSource = battleLogBindingSource;
            dataGridViewBattleLogLogs.Location = new Point(283, 4);
            dataGridViewBattleLogLogs.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBattleLogLogs.Name = "dataGridViewBattleLogLogs";
            dataGridViewBattleLogLogs.ReadOnly = true;
            dataGridViewBattleLogLogs.RowHeadersWidth = 51;
            dataGridViewBattleLogLogs.Size = new Size(782, 555);
            dataGridViewBattleLogLogs.TabIndex = 1;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            dataDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            dataDataGridViewTextBoxColumn1.ReadOnly = true;
            dataDataGridViewTextBoxColumn1.Width = 125;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            experienceDataGridViewTextBoxColumn.ReadOnly = true;
            experienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // psychoExperienceDataGridViewTextBoxColumn
            // 
            psychoExperienceDataGridViewTextBoxColumn.DataPropertyName = "Psycho_Experience";
            psychoExperienceDataGridViewTextBoxColumn.HeaderText = "Psycho_Experience";
            psychoExperienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            psychoExperienceDataGridViewTextBoxColumn.Name = "psychoExperienceDataGridViewTextBoxColumn";
            psychoExperienceDataGridViewTextBoxColumn.ReadOnly = true;
            psychoExperienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goldDataGridViewTextBoxColumn
            // 
            goldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
            goldDataGridViewTextBoxColumn.HeaderText = "Gold";
            goldDataGridViewTextBoxColumn.MinimumWidth = 6;
            goldDataGridViewTextBoxColumn.Name = "goldDataGridViewTextBoxColumn";
            goldDataGridViewTextBoxColumn.ReadOnly = true;
            goldDataGridViewTextBoxColumn.Width = 125;
            // 
            // droppeditemsDataGridViewTextBoxColumn
            // 
            droppeditemsDataGridViewTextBoxColumn.DataPropertyName = "Dropped_items";
            droppeditemsDataGridViewTextBoxColumn.HeaderText = "Dropped_items";
            droppeditemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            droppeditemsDataGridViewTextBoxColumn.Name = "droppeditemsDataGridViewTextBoxColumn";
            droppeditemsDataGridViewTextBoxColumn.ReadOnly = true;
            droppeditemsDataGridViewTextBoxColumn.Width = 125;
            // 
            // opponentsDataGridViewTextBoxColumn
            // 
            opponentsDataGridViewTextBoxColumn.DataPropertyName = "Opponents";
            opponentsDataGridViewTextBoxColumn.HeaderText = "Opponents";
            opponentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            opponentsDataGridViewTextBoxColumn.Name = "opponentsDataGridViewTextBoxColumn";
            opponentsDataGridViewTextBoxColumn.ReadOnly = true;
            opponentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // battleLogBindingSource
            // 
            battleLogBindingSource.DataMember = "BattleLog";
            battleLogBindingSource.DataSource = battleLogNicknameBindingSource;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(224, 224, 224);
            tabPage3.Controls.Add(customButton1);
            tabPage3.Controls.Add(customComboBox2);
            tabPage3.Controls.Add(customComboBox1);
            tabPage3.Controls.Add(customTextBox3);
            tabPage3.Controls.Add(customTextBox2);
            tabPage3.Controls.Add(customTextBox1);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(toggleButton3);
            tabPage3.Controls.Add(toggleButton2);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(toggleButton1);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(chart_label);
            tabPage3.Controls.Add(formsPlot1);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1071, 567);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Addons";
            tabPage3.Click += tabPage3_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.MediumSlateBlue;
            customButton1.BackgroundColor = Color.MediumSlateBlue;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(30, 245);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(188, 50);
            customButton1.TabIndex = 33;
            customButton1.Text = "Fit Plot";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customComboBox2
            // 
            customComboBox2.BackColor = Color.WhiteSmoke;
            customComboBox2.BorderColor = Color.MediumSlateBlue;
            customComboBox2.BorderSize = 1;
            customComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox2.Font = new Font("Segoe UI", 10F);
            customComboBox2.ForeColor = Color.DimGray;
            customComboBox2.IconColor = Color.MediumSlateBlue;
            customComboBox2.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" });
            customComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox2.ListTextColor = Color.DimGray;
            customComboBox2.Location = new Point(908, 283);
            customComboBox2.MinimumSize = new Size(71, 34);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(71, 34);
            customComboBox2.TabIndex = 32;
            customComboBox2.Texts = "";
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = Color.WhiteSmoke;
            customComboBox1.BorderColor = Color.MediumSlateBlue;
            customComboBox1.BorderSize = 1;
            customComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox1.Font = new Font("Segoe UI", 10F);
            customComboBox1.ForeColor = Color.DimGray;
            customComboBox1.IconColor = Color.MediumSlateBlue;
            customComboBox1.Items.AddRange(new object[] { "1* - Bronze 1", "2* - Bronze 2", "3* - Bronze 3", "4* - Silver 1", "5* - Silver 2", "6* - Silver 3", "7* - Gold 1", "8* - Gold 2", "9* - Gold 3" });
            customComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox1.ListTextColor = Color.DimGray;
            customComboBox1.Location = new Point(908, 209);
            customComboBox1.MinimumSize = new Size(71, 34);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(1);
            customComboBox1.Size = new Size(146, 34);
            customComboBox1.TabIndex = 32;
            customComboBox1.Texts = "";
            // 
            // customTextBox3
            // 
            customTextBox3.BackColor = SystemColors.Window;
            customTextBox3.BorderColor = Color.MediumSlateBlue;
            customTextBox3.BorderFocusColor = Color.HotPink;
            customTextBox3.BorderRadius = 0;
            customTextBox3.BorderSize = 2;
            customTextBox3.Font = new Font("Segoe UI", 9.5F);
            customTextBox3.ForeColor = Color.DimGray;
            customTextBox3.Location = new Point(773, 100);
            customTextBox3.Margin = new Padding(4);
            customTextBox3.Multiline = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(7);
            customTextBox3.PasswordChar = false;
            customTextBox3.PlaceholderColor = Color.DarkGray;
            customTextBox3.PlaceholderText = "Cena odłamków";
            customTextBox3.Size = new Size(129, 36);
            customTextBox3.TabIndex = 31;
            customTextBox3.Texts = "";
            customTextBox3.UnderlinedStyle = false;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.Window;
            customTextBox2.BorderColor = Color.MediumSlateBlue;
            customTextBox2.BorderFocusColor = Color.HotPink;
            customTextBox2.BorderRadius = 0;
            customTextBox2.BorderSize = 2;
            customTextBox2.Font = new Font("Segoe UI", 9.5F);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(638, 100);
            customTextBox2.Margin = new Padding(4);
            customTextBox2.Multiline = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.PlaceholderColor = Color.DarkGray;
            customTextBox2.PlaceholderText = "Cena esencji";
            customTextBox2.Size = new Size(129, 36);
            customTextBox2.TabIndex = 31;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.MediumSlateBlue;
            customTextBox1.BorderFocusColor = Color.HotPink;
            customTextBox1.BorderRadius = 0;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(503, 100);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Cena plat. za szt.";
            customTextBox1.Size = new Size(129, 36);
            customTextBox1.TabIndex = 31;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(669, 31);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 30;
            label8.Text = "Kalkulator";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(908, 260);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 29;
            label7.Text = "Ranga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(906, 186);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 28;
            label6.Text = "Gwiazdki";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(954, 142);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 27;
            label5.Text = "Inhibitor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(954, 112);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 26;
            label4.Text = "Targ Premium";
            // 
            // toggleButton3
            // 
            toggleButton3.AutoSize = true;
            toggleButton3.Location = new Point(908, 142);
            toggleButton3.MinimumSize = new Size(45, 22);
            toggleButton3.Name = "toggleButton3";
            toggleButton3.OffBackColor = Color.Gray;
            toggleButton3.OffToggleColor = Color.Gainsboro;
            toggleButton3.OnBackColor = Color.MediumSlateBlue;
            toggleButton3.OnToggleColor = Color.WhiteSmoke;
            toggleButton3.Size = new Size(45, 22);
            toggleButton3.TabIndex = 25;
            toggleButton3.UseVisualStyleBackColor = true;
            // 
            // toggleButton2
            // 
            toggleButton2.AutoSize = true;
            toggleButton2.Location = new Point(908, 114);
            toggleButton2.MinimumSize = new Size(45, 22);
            toggleButton2.Name = "toggleButton2";
            toggleButton2.OffBackColor = Color.Gray;
            toggleButton2.OffToggleColor = Color.Gainsboro;
            toggleButton2.OnBackColor = Color.MediumSlateBlue;
            toggleButton2.OnToggleColor = Color.WhiteSmoke;
            toggleButton2.Size = new Size(45, 22);
            toggleButton2.TabIndex = 25;
            toggleButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(954, 86);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 24;
            label2.Text = "Set Item";
            // 
            // toggleButton1
            // 
            toggleButton1.AutoSize = true;
            toggleButton1.Location = new Point(908, 86);
            toggleButton1.MinimumSize = new Size(45, 22);
            toggleButton1.Name = "toggleButton1";
            toggleButton1.OffBackColor = Color.Gray;
            toggleButton1.OffToggleColor = Color.Gainsboro;
            toggleButton1.OnBackColor = Color.MediumSlateBlue;
            toggleButton1.OnToggleColor = Color.WhiteSmoke;
            toggleButton1.Size = new Size(45, 22);
            toggleButton1.TabIndex = 23;
            toggleButton1.UseVisualStyleBackColor = true;
            toggleButton1.CheckedChanged += toggleButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(490, 0);
            label3.Name = "label3";
            label3.Size = new Size(2, 567);
            label3.TabIndex = 14;
            label3.Click += label3_Click;
            // 
            // chart_label
            // 
            chart_label.AutoSize = true;
            chart_label.Location = new Point(30, 22);
            chart_label.Name = "chart_label";
            chart_label.Size = new Size(183, 20);
            chart_label.TabIndex = 11;
            chart_label.Text = "Tyle punktów na wykresie: ";
            chart_label.Click += chart_label_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(30, 45);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(389, 179);
            formsPlot1.TabIndex = 10;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 372);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(156, 405);
            button2.Name = "button2";
            button2.Size = new Size(79, 38);
            button2.TabIndex = 8;
            button2.Text = "DodajXP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 197);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "BrokenStats";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatLogMessage).EndInit();
            ((System.ComponentModel.ISupportInitialize)messagesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatLogNicknameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatNickname).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBattleLogNickname).EndInit();
            ((System.ComponentModel.ISupportInitialize)battleLogNicknameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBattleLogLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TabPage tabPage3;
        private Label label1;
        private DataGridView dataGridViewChatNickname;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewChatLogMessage;
        private BindingSource messagesBindingSource;
        private BindingSource chatLogNicknameBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridViewBattleLogNickname;
        private DataGridView dataGridViewBattleLogLogs;
        private DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn1;
        private BindingSource battleLogNicknameBindingSource;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn psychoExperienceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn droppeditemsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn opponentsDataGridViewTextBoxColumn;
        private BindingSource battleLogBindingSource;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private Button button2;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer1;
        private Label chart_label;
        private Label label3;
        private CustomControls.ToggleButton toggleButton1;
        private Label label2;
        private CustomControls.ToggleButton toggleButton2;
        private Label label5;
        private Label label4;
        private CustomControls.ToggleButton toggleButton3;
        private Label label8;
        private Label label7;
        private Label label6;
        private CustomControls.CustomTextBox customTextBox3;
        private CustomControls.CustomTextBox customTextBox2;
        private CustomControls.CustomTextBox customTextBox1;
        private CustomControls.CustomComboBox customComboBox1;
        private CustomControls.CustomComboBox customComboBox2;
        private CustomControls.CustomButton customButton1;
    }
}
