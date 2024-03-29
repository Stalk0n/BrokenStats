﻿using System.Windows.Forms;

namespace BrokenStats
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

            label1 = new Label();

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
            // logRichTextBox
            // 
            logRichTextBox.Location = new Point(8, 43);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.Size = new Size(422, 354);
            logRichTextBox.TabIndex = 5;
            logRichTextBox.Text = "";
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
            // tabControl1
            // 
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
            bindingSource1.DataSource = typeof(SqLiteDatabaseHandler);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // sQLiteDatabaseHandlerBindingSource
            // 
            sQLiteDatabaseHandlerBindingSource.DataSource = typeof(SqLiteDatabaseHandler);
            // 
            // sQLiteDatabaseHandlerBindingSource1
            // 
            sQLiteDatabaseHandlerBindingSource1.DataSource = typeof(SqLiteDatabaseHandler);
            sQLiteDatabaseHandlerBindingSource1.CurrentChanged += sQLiteDatabaseHandlerBindingSource1_CurrentChanged;
            // 
            // sQLiteDatabaseHandlerBindingSource2
            // 
            sQLiteDatabaseHandlerBindingSource2.DataSource = typeof(SqLiteDatabaseHandler);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 672);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "BrokenStats";
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
        private Label label1;
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
