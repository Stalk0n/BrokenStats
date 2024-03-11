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
            components = new System.ComponentModel.Container();
            tabPage1 = new TabPage();
            logRichTextBox = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            sQLiteDatabaseHandlerBindingSource = new BindingSource(components);
            colorDialog1 = new ColorDialog();
            sQLiteDatabaseHandlerBindingSource1 = new BindingSource(components);
            sQLiteDatabaseHandlerBindingSource2 = new BindingSource(components);
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDatabaseHandlerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDatabaseHandlerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDatabaseHandlerBindingSource2).BeginInit();
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
            tabPage1.Click += tabPage1_Click_1;
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
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(986, 672);
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(978, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(972, 633);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(SQLiteDatabaseHandler);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // sQLiteDatabaseHandlerBindingSource
            // 
            sQLiteDatabaseHandlerBindingSource.DataSource = typeof(SQLiteDatabaseHandler);
            // 
            // sQLiteDatabaseHandlerBindingSource1
            // 
            sQLiteDatabaseHandlerBindingSource1.DataSource = typeof(SQLiteDatabaseHandler);
            sQLiteDatabaseHandlerBindingSource1.CurrentChanged += sQLiteDatabaseHandlerBindingSource1_CurrentChanged;
            // 
            // sQLiteDatabaseHandlerBindingSource2
            // 
            sQLiteDatabaseHandlerBindingSource2.DataSource = typeof(SQLiteDatabaseHandler);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDatabaseHandlerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDatabaseHandlerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDatabaseHandlerBindingSource2).EndInit();
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
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private BindingSource sQLiteDatabaseHandlerBindingSource;
        private BindingSource sQLiteDatabaseHandlerBindingSource2;
        private BindingSource sQLiteDatabaseHandlerBindingSource1;
    }
}
