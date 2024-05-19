namespace BrokenStats.UserControls
{
    partial class UC_BattleLog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            nickDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            battleLogNicknameBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            experienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            psychoExperienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            goldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            droppeditemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            opponentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            battleLogBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battleLogNicknameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(dataGridView2, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nickDataGridViewTextBoxColumn });
            dataGridView1.DataSource = battleLogNicknameBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(194, 394);
            dataGridView1.TabIndex = 0;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            nickDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // battleLogNicknameBindingSource
            // 
            battleLogNicknameBindingSource.DataSource = typeof(Tables.BattleLogNickname);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataDataGridViewTextBoxColumn, experienceDataGridViewTextBoxColumn, psychoExperienceDataGridViewTextBoxColumn, goldDataGridViewTextBoxColumn, droppeditemsDataGridViewTextBoxColumn, opponentsDataGridViewTextBoxColumn });
            dataGridView2.DataSource = battleLogBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(203, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(594, 394);
            dataGridView2.TabIndex = 1;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // psychoExperienceDataGridViewTextBoxColumn
            // 
            psychoExperienceDataGridViewTextBoxColumn.DataPropertyName = "Psycho_Experience";
            psychoExperienceDataGridViewTextBoxColumn.HeaderText = "Psycho_Experience";
            psychoExperienceDataGridViewTextBoxColumn.Name = "psychoExperienceDataGridViewTextBoxColumn";
            // 
            // goldDataGridViewTextBoxColumn
            // 
            goldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
            goldDataGridViewTextBoxColumn.HeaderText = "Gold";
            goldDataGridViewTextBoxColumn.Name = "goldDataGridViewTextBoxColumn";
            // 
            // droppeditemsDataGridViewTextBoxColumn
            // 
            droppeditemsDataGridViewTextBoxColumn.DataPropertyName = "Dropped_items";
            droppeditemsDataGridViewTextBoxColumn.HeaderText = "Dropped_items";
            droppeditemsDataGridViewTextBoxColumn.Name = "droppeditemsDataGridViewTextBoxColumn";
            // 
            // opponentsDataGridViewTextBoxColumn
            // 
            opponentsDataGridViewTextBoxColumn.DataPropertyName = "Opponents";
            opponentsDataGridViewTextBoxColumn.HeaderText = "Opponents";
            opponentsDataGridViewTextBoxColumn.Name = "opponentsDataGridViewTextBoxColumn";
            // 
            // battleLogBindingSource
            // 
            battleLogBindingSource.DataMember = "BattleLog";
            battleLogBindingSource.DataSource = battleLogNicknameBindingSource;
            // 
            // UC_BattleLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanel1);
            Location = new Point(0, 50);
            Name = "UC_BattleLog";
            Size = new Size(800, 450);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)battleLogNicknameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private BindingSource battleLogNicknameBindingSource;
        private BindingSource battleLogBindingSource;
        private DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn psychoExperienceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn droppeditemsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn opponentsDataGridViewTextBoxColumn;
    }
}
