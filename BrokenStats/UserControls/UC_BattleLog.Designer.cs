namespace BrokenStats.UserControls
{
    partial class UcBattleLog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource battleLogNicknameBindingSource;
        private System.Windows.Forms.DataGridView battleLogDataGridView;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (battleLogDataGridView != null && battleLogDataGridView.Parent != null)
                {
                    components.Dispose();
                }
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
            dataGridView2 = new DataGridView();
            battleLogBindingSource = new BindingSource(components);
            battleLogNicknameBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            nickDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            battleLogBindingSource1 = new BindingSource(components);
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            experienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PsychoExperience = new DataGridViewTextBoxColumn();
            goldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DroppedItems = new DataGridViewTextBoxColumn();
            opponentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battleLogNicknameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.35F));
            tableLayoutPanel1.Controls.Add(dataGridView2, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1150, 600);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataDataGridViewTextBoxColumn, experienceDataGridViewTextBoxColumn, PsychoExperience, goldDataGridViewTextBoxColumn, DroppedItems, opponentsDataGridViewTextBoxColumn });
            dataGridView2.DataSource = battleLogBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(205, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(942, 544);
            dataGridView2.TabIndex = 1;
            // 
            // battleLogBindingSource
            // 
            battleLogBindingSource.DataMember = "BattleLog";
            battleLogBindingSource.DataSource = battleLogNicknameBindingSource;
            // 
            // battleLogNicknameBindingSource
            // 
            battleLogNicknameBindingSource.DataSource = typeof(Tables.BattleLogNickname);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nickDataGridViewTextBoxColumn });
            dataGridView1.DataSource = battleLogNicknameBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(196, 544);
            dataGridView1.TabIndex = 0;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            nickDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // battleLogBindingSource1
            // 
            battleLogBindingSource1.DataMember = "BattleLog";
            battleLogBindingSource1.DataSource = battleLogNicknameBindingSource;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.FillWeight = 56F;
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            experienceDataGridViewTextBoxColumn.FillWeight = 50F;
            experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // PsychoExperience
            // 
            PsychoExperience.DataPropertyName = "PsychoExperience";
            PsychoExperience.FillWeight = 60F;
            PsychoExperience.HeaderText = "Psycho Experience";
            PsychoExperience.Name = "PsychoExperience";
            // 
            // goldDataGridViewTextBoxColumn
            // 
            goldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
            goldDataGridViewTextBoxColumn.FillWeight = 35F;
            goldDataGridViewTextBoxColumn.HeaderText = "Gold";
            goldDataGridViewTextBoxColumn.Name = "goldDataGridViewTextBoxColumn";
            // 
            // DroppedItems
            // 
            DroppedItems.DataPropertyName = "DroppedItems";
            DroppedItems.HeaderText = "Dropped Items";
            DroppedItems.Name = "DroppedItems";
            // 
            // opponentsDataGridViewTextBoxColumn
            // 
            opponentsDataGridViewTextBoxColumn.DataPropertyName = "Opponents";
            opponentsDataGridViewTextBoxColumn.HeaderText = "Opponents";
            opponentsDataGridViewTextBoxColumn.Name = "opponentsDataGridViewTextBoxColumn";
            // 
            // UcBattleLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanel1);
            Location = new Point(0, 50);
            Name = "UcBattleLog";
            Size = new Size(1150, 600);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)battleLogNicknameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)battleLogBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private BindingSource battleLogBindingSource;
        private DataGridViewTextBoxColumn psychoExperienceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn droppeditemsDataGridViewTextBoxColumn;
        private BindingSource battleLogBindingSource1;
        private DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PsychoExperience;
        private DataGridViewTextBoxColumn goldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DroppedItems;
        private DataGridViewTextBoxColumn opponentsDataGridViewTextBoxColumn;
    }
}
