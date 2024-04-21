
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
            label1 = new Label();
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
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(944, 450);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(936, 422);
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(936, 391);
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
            dataGridViewChatLogMessage.Location = new Point(399, 3);
            dataGridViewChatLogMessage.Name = "dataGridViewChatLogMessage";
            dataGridViewChatLogMessage.ReadOnly = true;
            dataGridViewChatLogMessage.Size = new Size(677, 385);
            dataGridViewChatLogMessage.TabIndex = 5;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Date";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            messageDataGridViewTextBoxColumn.HeaderText = "Message";
            messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            messageDataGridViewTextBoxColumn.ReadOnly = true;
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
            dataGridViewChatNickname.Location = new Point(3, 3);
            dataGridViewChatNickname.Name = "dataGridViewChatNickname";
            dataGridViewChatNickname.ReadOnly = true;
            dataGridViewChatNickname.Size = new Size(390, 385);
            dataGridViewChatNickname.TabIndex = 4;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            nickDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(581, 396);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 3;
            button1.Text = "Tester";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(936, 422);
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
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(936, 422);
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
            dataGridViewBattleLogNickname.Location = new Point(3, 3);
            dataGridViewBattleLogNickname.Name = "dataGridViewBattleLogNickname";
            dataGridViewBattleLogNickname.ReadOnly = true;
            dataGridViewBattleLogNickname.Size = new Size(240, 416);
            dataGridViewBattleLogNickname.TabIndex = 0;
            // 
            // nickDataGridViewTextBoxColumn1
            // 
            nickDataGridViewTextBoxColumn1.DataPropertyName = "Nick";
            nickDataGridViewTextBoxColumn1.HeaderText = "Nick";
            nickDataGridViewTextBoxColumn1.Name = "nickDataGridViewTextBoxColumn1";
            nickDataGridViewTextBoxColumn1.ReadOnly = true;
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
            dataGridViewBattleLogLogs.Location = new Point(249, 3);
            dataGridViewBattleLogLogs.Name = "dataGridViewBattleLogLogs";
            dataGridViewBattleLogLogs.ReadOnly = true;
            dataGridViewBattleLogLogs.Size = new Size(684, 416);
            dataGridViewBattleLogLogs.TabIndex = 1;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            dataDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            experienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psychoExperienceDataGridViewTextBoxColumn
            // 
            psychoExperienceDataGridViewTextBoxColumn.DataPropertyName = "Psycho_Experience";
            psychoExperienceDataGridViewTextBoxColumn.HeaderText = "Psycho_Experience";
            psychoExperienceDataGridViewTextBoxColumn.Name = "psychoExperienceDataGridViewTextBoxColumn";
            psychoExperienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goldDataGridViewTextBoxColumn
            // 
            goldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
            goldDataGridViewTextBoxColumn.HeaderText = "Gold";
            goldDataGridViewTextBoxColumn.Name = "goldDataGridViewTextBoxColumn";
            goldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // droppeditemsDataGridViewTextBoxColumn
            // 
            droppeditemsDataGridViewTextBoxColumn.DataPropertyName = "Dropped_items";
            droppeditemsDataGridViewTextBoxColumn.HeaderText = "Dropped_items";
            droppeditemsDataGridViewTextBoxColumn.Name = "droppeditemsDataGridViewTextBoxColumn";
            droppeditemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opponentsDataGridViewTextBoxColumn
            // 
            opponentsDataGridViewTextBoxColumn.DataPropertyName = "Opponents";
            opponentsDataGridViewTextBoxColumn.HeaderText = "Opponents";
            opponentsDataGridViewTextBoxColumn.Name = "opponentsDataGridViewTextBoxColumn";
            opponentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // battleLogBindingSource
            // 
            battleLogBindingSource.DataMember = "BattleLog";
            battleLogBindingSource.DataSource = battleLogNicknameBindingSource;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(224, 224, 224);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(936, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 148);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "BrokenStats";
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
    }
}
