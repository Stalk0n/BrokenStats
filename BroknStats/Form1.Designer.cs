using System.Windows.Forms;

namespace BroknStats
{
    partial class Form1
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
            tabPage1 = new TabPage();
            logRichTextBox = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            Items_Session = new TabPage();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            ItemQuantity = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            tabPage3 = new TabPage();
            colorDialog1 = new ColorDialog();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            Items_Session.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(logRichTextBox);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(978, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Logs";
            tabPage1.Click += tabPage1_Click;
            // 
            // logRichTextBox
            // 
            logRichTextBox.Location = new Point(8, 43);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.Size = new Size(422, 354);
            logRichTextBox.TabIndex = 5;
            logRichTextBox.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Console Log";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(632, 197);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(986, 672);
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(978, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(Items_Session);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(3, 3);
            tabControl2.Margin = new Padding(0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(972, 633);
            tabControl2.TabIndex = 1;
            // 
            // Items_Session
            // 
            Items_Session.Controls.Add(dataGridView1);
            Items_Session.Location = new Point(4, 29);
            Items_Session.Name = "Items_Session";
            Items_Session.Padding = new Padding(3);
            Items_Session.Size = new Size(964, 600);
            Items_Session.TabIndex = 0;
            Items_Session.Text = "Session";
            Items_Session.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, ItemName, ItemQuantity });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(958, 594);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Id
            // 
            Id.HeaderText = "#";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // ItemQuantity
            // 
            ItemQuantity.HeaderText = "Item Quantity";
            ItemQuantity.MinimumWidth = 6;
            ItemQuantity.Name = "ItemQuantity";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(964, 600);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Everything";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(978, 639);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Stats";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 672);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "BroknStats";
            Load += Form1_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            Items_Session.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private RichTextBox logRichTextBox;
        private ColorDialog colorDialog1;
        //private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private TabControl tabControl2;
        private TabPage Items_Session;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemQuantity;
    }
}
