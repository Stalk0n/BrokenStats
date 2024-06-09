namespace BrokenStats.UserControls
{
    partial class UC_ChatLog
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            dataGridViewChatLogMessage = new DataGridView();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewChatNickname = new DataGridView();
            nickDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            nickDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            chatLogNicknameBindingSource = new BindingSource(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            dataDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            messageDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            messagesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatLogMessage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatNickname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatLogNicknameBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messagesBindingSource).BeginInit();
            SuspendLayout();
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
            // 
            // dataGridViewChatLogMessage
            // 
            dataGridViewChatLogMessage.AllowUserToAddRows = false;
            dataGridViewChatLogMessage.AllowUserToDeleteRows = false;
            dataGridViewChatLogMessage.AutoGenerateColumns = false;
            dataGridViewChatLogMessage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewChatLogMessage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewChatLogMessage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChatLogMessage.Columns.AddRange(new DataGridViewColumn[] { dataDataGridViewTextBoxColumn, messageDataGridViewTextBoxColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewChatLogMessage.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewChatLogMessage.Dock = DockStyle.Left;
            dataGridViewChatLogMessage.Location = new Point(3, 3);
            dataGridViewChatLogMessage.Name = "dataGridViewChatLogMessage";
            dataGridViewChatLogMessage.ReadOnly = true;
            dataGridViewChatLogMessage.RowHeadersWidth = 51;
            dataGridViewChatLogMessage.Size = new Size(631, 385);
            dataGridViewChatLogMessage.TabIndex = 5;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Date";
            dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            dataDataGridViewTextBoxColumn.Width = 56;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            messageDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            messageDataGridViewTextBoxColumn.HeaderText = "Message";
            messageDataGridViewTextBoxColumn.MinimumWidth = 6;
            messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dataGridViewChatLogMessage, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewChatNickname
            // 
            dataGridViewChatNickname.AllowUserToAddRows = false;
            dataGridViewChatNickname.AllowUserToDeleteRows = false;
            dataGridViewChatNickname.AutoGenerateColumns = false;
            dataGridViewChatNickname.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChatNickname.Columns.AddRange(new DataGridViewColumn[] { nickDataGridViewTextBoxColumn });
            dataGridViewChatNickname.Location = new Point(3, 3);
            dataGridViewChatNickname.Name = "dataGridViewChatNickname";
            dataGridViewChatNickname.ReadOnly = true;
            dataGridViewChatNickname.RowHeadersWidth = 51;
            dataGridViewChatNickname.Size = new Size(293, 385);
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
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nickDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = chatLogNicknameBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(339, 544);
            dataGridView1.TabIndex = 0;
            // 
            // nickDataGridViewTextBoxColumn1
            // 
            nickDataGridViewTextBoxColumn1.DataPropertyName = "Nick";
            nickDataGridViewTextBoxColumn1.HeaderText = "Nick";
            nickDataGridViewTextBoxColumn1.Name = "nickDataGridViewTextBoxColumn1";
            // 
            // chatLogNicknameBindingSource
            // 
            chatLogNicknameBindingSource.DataSource = typeof(Tables.ChatLogNickname);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Controls.Add(dataGridView2, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1150, 600);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataDataGridViewTextBoxColumn1, messageDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = messagesBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(348, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(799, 544);
            dataGridView2.TabIndex = 1;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            dataDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn1
            // 
            messageDataGridViewTextBoxColumn1.DataPropertyName = "Message";
            messageDataGridViewTextBoxColumn1.HeaderText = "Message";
            messageDataGridViewTextBoxColumn1.Name = "messageDataGridViewTextBoxColumn1";
            messageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // messagesBindingSource
            // 
            messagesBindingSource.DataMember = "Messages";
            messagesBindingSource.DataSource = chatLogNicknameBindingSource;
            // 
            // UC_ChatLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "UC_ChatLog";
            Size = new Size(1150, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatLogMessage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChatNickname).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatLogNicknameBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)messagesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewChatLogMessage;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewChatNickname;
        private DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn1;
        private BindingSource chatLogNicknameBindingSource;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn1;
        private BindingSource messagesBindingSource;
    }
}
