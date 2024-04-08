
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
            dataGridViewNicknames = new DataGridView();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nick = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            dataGridViewMessages = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            message = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            Button = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNicknames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMessages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewNicknames
            // 
            dataGridViewNicknames.AllowUserToAddRows = false;
            dataGridViewNicknames.AllowUserToDeleteRows = false;
            dataGridViewNicknames.AutoGenerateColumns = false;
            dataGridViewNicknames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNicknames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNicknames.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, Nick });
            dataGridViewNicknames.DataSource = categoryBindingSource;
            dataGridViewNicknames.Location = new Point(6, 7);
            dataGridViewNicknames.Margin = new Padding(3, 4, 3, 4);
            dataGridViewNicknames.Name = "dataGridViewNicknames";
            dataGridViewNicknames.ReadOnly = true;
            dataGridViewNicknames.RowHeadersWidth = 51;
            dataGridViewNicknames.Size = new Size(439, 513);
            dataGridViewNicknames.TabIndex = 0;
            dataGridViewNicknames.CellContentClick += dataGridViewNicknames_CellContentClick;
            dataGridViewNicknames.SelectionChanged += dataGridViewNicknames_SelectionChanged;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "NicknameId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "NicknameId";
            categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nick
            // 
            Nick.DataPropertyName = "Nick";
            Nick.HeaderText = "Nick";
            Nick.MinimumWidth = 6;
            Nick.Name = "Nick";
            Nick.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Nickname);
            // 
            // dataGridViewMessages
            // 
            dataGridViewMessages.AllowUserToAddRows = false;
            dataGridViewMessages.AllowUserToDeleteRows = false;
            dataGridViewMessages.AutoGenerateColumns = false;
            dataGridViewMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMessages.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, Data, message });
            dataGridViewMessages.DataSource = productsBindingSource;
            dataGridViewMessages.Location = new Point(451, 7);
            dataGridViewMessages.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMessages.Name = "dataGridViewMessages";
            dataGridViewMessages.ReadOnly = true;
            dataGridViewMessages.RowHeadersWidth = 51;
            dataGridViewMessages.Size = new Size(441, 512);
            dataGridViewMessages.TabIndex = 1;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "MessageId";
            productIdDataGridViewTextBoxColumn.HeaderText = "MessageId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Data
            // 
            Data.DataPropertyName = "Data";
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // message
            // 
            message.DataPropertyName = "message";
            message.HeaderText = "Message";
            message.MinimumWidth = 6;
            message.Name = "message";
            message.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Messages";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // Button
            // 
            Button.Location = new Point(806, 527);
            Button.Margin = new Padding(3, 4, 3, 4);
            Button.Name = "Button";
            Button.Size = new Size(86, 31);
            Button.TabIndex = 2;
            Button.Text = "Save";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 600);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridViewNicknames);
            tabPage1.Controls.Add(Button);
            tabPage1.Controls.Add(dataGridViewMessages);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(664, 528);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Messages and Nicknames";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNicknames).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMessages).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridViewNicknames;
        private DataGridView dataGridViewMessages;
        private Button Button;
        private BindingSource categoryBindingSource;
        private BindingSource productsBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Nick;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn message;
        private Button button1;
    }
}
