﻿using Krypton.Toolkit;

namespace BrokenStats
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            minimiseButton = new KryptonButton();
            exitButton = new KryptonButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            kryptonButton1 = new KryptonButton();
            panelContainer = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonButton2 = new KryptonButton();
            kryptonButton4 = new KryptonButton();
            kryptonButton5 = new KryptonButton();
            kryptonButton3 = new KryptonButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(kryptonButton3);
            panel1.Controls.Add(minimiseButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 55);
            panel1.TabIndex = 0;
            // 
            // minimiseButton
            // 
            minimiseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimiseButton.Location = new Point(1058, 0);
            minimiseButton.Margin = new Padding(0);
            minimiseButton.Name = "minimiseButton";
            minimiseButton.OverrideDefault.Back.Color1 = Color.FromArgb(26, 26, 26);
            minimiseButton.OverrideDefault.Back.Color2 = Color.FromArgb(26, 26, 26);
            minimiseButton.OverrideDefault.Border.Color1 = Color.FromArgb(26, 26, 26);
            minimiseButton.OverrideDefault.Border.Color2 = Color.FromArgb(26, 26, 26);
            minimiseButton.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            minimiseButton.OverrideFocus.Back.Color1 = Color.FromArgb(56, 56, 56);
            minimiseButton.OverrideFocus.Back.Color2 = Color.FromArgb(56, 56, 56);
            minimiseButton.OverrideFocus.Border.Color1 = Color.FromArgb(56, 56, 56);
            minimiseButton.OverrideFocus.Border.Color2 = Color.FromArgb(56, 56, 56);
            minimiseButton.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            minimiseButton.Size = new Size(46, 31);
            minimiseButton.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateCommon.Back.Color2 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateCommon.Border.Color1 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateCommon.Border.Color2 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            minimiseButton.StateCommon.Content.ShortText.Color1 = Color.White;
            minimiseButton.StateCommon.Content.ShortText.Color2 = Color.White;
            minimiseButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimiseButton.StateDisabled.Back.Color1 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateDisabled.Back.Color2 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateDisabled.Border.DrawBorders = PaletteDrawBorders.None;
            minimiseButton.StateNormal.Back.Color1 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateNormal.Back.Color2 = Color.FromArgb(26, 26, 26);
            minimiseButton.StateNormal.Border.DrawBorders = PaletteDrawBorders.None;
            minimiseButton.StateNormal.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            minimiseButton.StatePressed.Back.Color1 = Color.FromArgb(56, 56, 56);
            minimiseButton.StatePressed.Back.Color2 = Color.FromArgb(56, 56, 56);
            minimiseButton.StatePressed.Border.DrawBorders = PaletteDrawBorders.None;
            minimiseButton.StateTracking.Back.Color1 = Color.FromArgb(36, 36, 36);
            minimiseButton.StateTracking.Back.Color2 = Color.FromArgb(36, 36, 36);
            minimiseButton.StateTracking.Border.Color1 = Color.FromArgb(56, 56, 56);
            minimiseButton.StateTracking.Border.Color2 = Color.FromArgb(56, 56, 56);
            minimiseButton.StateTracking.Border.DrawBorders = PaletteDrawBorders.None;
            minimiseButton.TabIndex = 14;
            minimiseButton.Values.Text = "_";
            minimiseButton.Click += kryptonButton10_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.Location = new Point(1104, 0);
            exitButton.Margin = new Padding(0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(46, 31);
            exitButton.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            exitButton.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            exitButton.StateCommon.Content.ShortText.Color1 = Color.White;
            exitButton.StateCommon.Content.ShortText.Color2 = Color.White;
            exitButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.StateDisabled.Back.Color1 = Color.FromArgb(26, 26, 26);
            exitButton.StateDisabled.Back.Color2 = Color.FromArgb(26, 26, 26);
            exitButton.StateDisabled.Border.DrawBorders = PaletteDrawBorders.None;
            exitButton.StateNormal.Back.Color1 = Color.FromArgb(26, 26, 26);
            exitButton.StateNormal.Back.Color2 = Color.FromArgb(26, 26, 26);
            exitButton.StateNormal.Border.DrawBorders = PaletteDrawBorders.None;
            exitButton.StateNormal.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            exitButton.StatePressed.Back.Color1 = Color.FromArgb(56, 56, 56);
            exitButton.StatePressed.Back.Color2 = Color.FromArgb(56, 56, 56);
            exitButton.StatePressed.Border.DrawBorders = PaletteDrawBorders.None;
            exitButton.StateTracking.Back.Color1 = Color.FromArgb(159, 36, 36);
            exitButton.StateTracking.Back.Color2 = Color.FromArgb(159, 36, 36);
            exitButton.StateTracking.Border.DrawBorders = PaletteDrawBorders.None;
            exitButton.TabIndex = 12;
            exitButton.Values.Text = "×";
            exitButton.Click += kryptonButton8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(189, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 2;
            label2.Text = "Session length: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(189, 3);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 1;
            label1.Text = "Character: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton1.Location = new Point(1, 1);
            kryptonButton1.Margin = new Padding(1);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton1.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton1.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton1.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.Size = new Size(285, 42);
            kryptonButton1.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton1.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
            kryptonButton1.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonButton1.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton1.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton1.StateDisabled.Back.Color1 = SystemColors.Control;
            kryptonButton1.StateDisabled.Back.Color2 = SystemColors.Control;
            kryptonButton1.StateNormal.Back.Color1 = SystemColors.Control;
            kryptonButton1.StateNormal.Back.Color2 = SystemColors.Control;
            kryptonButton1.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton1.StatePressed.Back.Color2 = Color.DarkGray;
            kryptonButton1.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton1.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.Text = "Chat logs";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 55);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1150, 600);
            panelContainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Controls.Add(kryptonButton1, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton2, 1, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton4, 2, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton5, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1150, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton2.Location = new Point(288, 1);
            kryptonButton2.Margin = new Padding(1);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton2.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton2.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton2.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton2.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton2.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton2.Size = new Size(285, 42);
            kryptonButton2.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton2.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton2.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton2.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
            kryptonButton2.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonButton2.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton2.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton2.StateDisabled.Back.Color1 = SystemColors.Control;
            kryptonButton2.StateDisabled.Back.Color2 = SystemColors.Control;
            kryptonButton2.StateNormal.Back.Color1 = SystemColors.Control;
            kryptonButton2.StateNormal.Back.Color2 = SystemColors.Control;
            kryptonButton2.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton2.StatePressed.Back.Color2 = Color.DarkGray;
            kryptonButton2.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton2.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton2.TabIndex = 6;
            kryptonButton2.Values.Text = "Battle logs";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton4.Location = new Point(575, 1);
            kryptonButton4.Margin = new Padding(1);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton4.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton4.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton4.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton4.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.Size = new Size(285, 42);
            kryptonButton4.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton4.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton4.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton4.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton4.StateDisabled.Back.Color1 = SystemColors.Control;
            kryptonButton4.StateDisabled.Back.Color2 = SystemColors.Control;
            kryptonButton4.StateDisabled.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.StateNormal.Back.Color1 = SystemColors.Control;
            kryptonButton4.StateNormal.Back.Color2 = SystemColors.Control;
            kryptonButton4.StateNormal.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton4.StatePressed.Back.Color2 = Color.DarkGray;
            kryptonButton4.StatePressed.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton4.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton4.StateTracking.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.TabIndex = 8;
            kryptonButton4.Values.Text = "Calculator";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton5.Location = new Point(862, 1);
            kryptonButton5.Margin = new Padding(1);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton5.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton5.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton5.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton5.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton5.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton5.Size = new Size(287, 42);
            kryptonButton5.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton5.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton5.StateCommon.Border.Color1 = SystemColors.Control;
            kryptonButton5.StateCommon.Border.Color2 = SystemColors.Control;
            kryptonButton5.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton5.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton5.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton5.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton5.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton5.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
            kryptonButton5.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonButton5.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton5.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton5.StateDisabled.Back.Color1 = SystemColors.Control;
            kryptonButton5.StateDisabled.Back.Color2 = SystemColors.Control;
            kryptonButton5.StateNormal.Back.Color1 = SystemColors.Control;
            kryptonButton5.StateNormal.Back.Color2 = SystemColors.Control;
            kryptonButton5.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton5.StatePressed.Back.Color2 = Color.DarkGray;
            kryptonButton5.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton5.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton5.TabIndex = 9;
            kryptonButton5.Values.Text = "Respawns";
            kryptonButton5.Click += kryptonButton5_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(513, 17);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(90, 25);
            kryptonButton3.TabIndex = 15;
            kryptonButton3.Values.Text = "kryptonButton3";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 655);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panelContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private KryptonButton exitButton;
        private KryptonButton minimiseButton;
        private KryptonButton kryptonButton3;
    }
}