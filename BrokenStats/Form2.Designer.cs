using Krypton.Toolkit;

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
            maximiseButton = new KryptonButton();
            exitButton = new KryptonButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            kryptonButton1 = new KryptonButton();
            panelContainer = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonButton7 = new KryptonButton();
            kryptonButton2 = new KryptonButton();
            kryptonButton4 = new KryptonButton();
            kryptonButton3 = new KryptonButton();
            kryptonButton5 = new KryptonButton();
            kryptonButton6 = new KryptonButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(minimiseButton);
            panel1.Controls.Add(maximiseButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 55);
            panel1.TabIndex = 0;
            // 
            // minimiseButton
            // 
            minimiseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimiseButton.Location = new Point(662, 0);
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
            minimiseButton.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // maximiseButton
            // 
            maximiseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximiseButton.Location = new Point(708, 0);
            maximiseButton.Margin = new Padding(0);
            maximiseButton.Name = "maximiseButton";
            maximiseButton.OverrideDefault.Back.Color1 = Color.FromArgb(26, 26, 26);
            maximiseButton.OverrideDefault.Back.Color2 = Color.FromArgb(26, 26, 26);
            maximiseButton.OverrideDefault.Border.Color1 = Color.FromArgb(26, 26, 26);
            maximiseButton.OverrideDefault.Border.Color2 = Color.FromArgb(26, 26, 26);
            maximiseButton.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            maximiseButton.OverrideFocus.Back.Color1 = Color.FromArgb(56, 56, 56);
            maximiseButton.OverrideFocus.Back.Color2 = Color.FromArgb(56, 56, 56);
            maximiseButton.OverrideFocus.Border.Color1 = Color.FromArgb(56, 56, 56);
            maximiseButton.OverrideFocus.Border.Color2 = Color.FromArgb(56, 56, 56);
            maximiseButton.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            maximiseButton.Size = new Size(46, 31);
            maximiseButton.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            maximiseButton.StateCommon.Back.Color2 = Color.FromArgb(26, 26, 26);
            maximiseButton.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            maximiseButton.StateCommon.Content.ShortText.Color1 = Color.White;
            maximiseButton.StateCommon.Content.ShortText.Color2 = Color.White;
            maximiseButton.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maximiseButton.StateDisabled.Back.Color1 = Color.FromArgb(26, 26, 26);
            maximiseButton.StateDisabled.Back.Color2 = Color.FromArgb(26, 26, 26);
            maximiseButton.StateDisabled.Border.DrawBorders = PaletteDrawBorders.None;
            maximiseButton.StateNormal.Back.Color1 = Color.FromArgb(26, 26, 26);
            maximiseButton.StateNormal.Back.Color2 = Color.FromArgb(26, 26, 26);
            maximiseButton.StateNormal.Border.DrawBorders = PaletteDrawBorders.None;
            maximiseButton.StateNormal.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            maximiseButton.StatePressed.Back.Color1 = Color.FromArgb(56, 56, 56);
            maximiseButton.StatePressed.Back.Color2 = Color.FromArgb(56, 56, 56);
            maximiseButton.StatePressed.Border.DrawBorders = PaletteDrawBorders.None;
            maximiseButton.StateTracking.Back.Color1 = Color.FromArgb(36, 36, 36);
            maximiseButton.StateTracking.Back.Color2 = Color.FromArgb(36, 36, 36);
            maximiseButton.StateTracking.Border.Color1 = Color.FromArgb(56, 56, 56);
            maximiseButton.StateTracking.Border.Color2 = Color.FromArgb(56, 56, 56);
            maximiseButton.StateTracking.Border.DrawBorders = PaletteDrawBorders.None;
            maximiseButton.TabIndex = 13;
            maximiseButton.Values.Text = "🗖";
            maximiseButton.Click += kryptonButton9_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.Location = new Point(754, 0);
            exitButton.Margin = new Padding(0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(46, 31);
            exitButton.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            exitButton.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            exitButton.StateCommon.Content.ShortText.Color1 = Color.White;
            exitButton.StateCommon.Content.ShortText.Color2 = Color.White;
            exitButton.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            kryptonButton1.Location = new Point(1, 1);
            kryptonButton1.Margin = new Padding(1);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton1.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton1.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton1.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.Size = new Size(112, 42);
            kryptonButton1.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton1.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            panelContainer.Size = new Size(800, 395);
            panelContainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.Controls.Add(kryptonButton7, 6, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton1, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton2, 1, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton4, 3, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton3, 2, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton5, 4, 0);
            tableLayoutPanel1.Controls.Add(kryptonButton6, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonButton7
            // 
            kryptonButton7.Location = new Point(685, 1);
            kryptonButton7.Margin = new Padding(1);
            kryptonButton7.Name = "kryptonButton7";
            kryptonButton7.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton7.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton7.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton7.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton7.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton7.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton7.Size = new Size(112, 42);
            kryptonButton7.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton7.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton7.StateCommon.Border.Color1 = SystemColors.Control;
            kryptonButton7.StateCommon.Border.Color2 = SystemColors.Control;
            kryptonButton7.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton7.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton7.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton7.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton7.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton7.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
            kryptonButton7.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonButton7.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton7.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton7.StateDisabled.Back.Color1 = SystemColors.Control;
            kryptonButton7.StateDisabled.Back.Color2 = SystemColors.Control;
            kryptonButton7.StateNormal.Back.Color1 = SystemColors.Control;
            kryptonButton7.StateNormal.Back.Color2 = SystemColors.Control;
            kryptonButton7.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton7.StatePressed.Back.Color2 = Color.DarkGray;
            kryptonButton7.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton7.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton7.TabIndex = 11;
            kryptonButton7.Values.Text = "Placeholder2";
            kryptonButton7.Click += kryptonButton7_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(115, 1);
            kryptonButton2.Margin = new Padding(1);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton2.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton2.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton2.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton2.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton2.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton2.Size = new Size(112, 42);
            kryptonButton2.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton2.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton2.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton2.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            kryptonButton4.Location = new Point(343, 1);
            kryptonButton4.Margin = new Padding(1);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton4.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton4.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton4.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton4.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.Size = new Size(112, 42);
            kryptonButton4.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton4.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton4.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton4.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton4.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(229, 1);
            kryptonButton3.Margin = new Padding(1);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton3.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton3.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton3.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton3.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton3.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton3.Size = new Size(112, 42);
            kryptonButton3.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton3.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton3.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton3.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
            kryptonButton3.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonButton3.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton3.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton3.StateDisabled.Back.Color1 = SystemColors.Control;
            kryptonButton3.StateDisabled.Back.Color2 = SystemColors.Control;
            kryptonButton3.StateNormal.Back.Color1 = SystemColors.Control;
            kryptonButton3.StateNormal.Back.Color2 = SystemColors.Control;
            kryptonButton3.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton3.StatePressed.Back.Color2 = Color.DarkGray;
            kryptonButton3.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton3.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton3.TabIndex = 7;
            kryptonButton3.Values.Text = "Battle statistics";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.Location = new Point(457, 1);
            kryptonButton5.Margin = new Padding(1);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton5.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton5.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton5.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton5.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton5.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton5.Size = new Size(112, 42);
            kryptonButton5.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton5.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton5.StateCommon.Border.Color1 = SystemColors.Control;
            kryptonButton5.StateCommon.Border.Color2 = SystemColors.Control;
            kryptonButton5.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton5.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton5.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton5.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton5.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // kryptonButton6
            // 
            kryptonButton6.Location = new Point(571, 1);
            kryptonButton6.Margin = new Padding(1);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton6.OverrideDefault.Back.Color2 = Color.Silver;
            kryptonButton6.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton6.OverrideFocus.Back.Color1 = Color.DarkGray;
            kryptonButton6.OverrideFocus.Back.Color2 = Color.DarkGray;
            kryptonButton6.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton6.Size = new Size(112, 42);
            kryptonButton6.StateCommon.Back.Color1 = SystemColors.Control;
            kryptonButton6.StateCommon.Back.Color2 = SystemColors.Control;
            kryptonButton6.StateCommon.Border.Color1 = SystemColors.Control;
            kryptonButton6.StateCommon.Border.Color2 = SystemColors.Control;
            kryptonButton6.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton6.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton6.StateCommon.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton6.StateCommon.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton6.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton6.StateCommon.Content.ShortText.MultiLine = InheritBool.True;
            kryptonButton6.StateCommon.Content.ShortText.MultiLineH = PaletteRelativeAlign.Center;
            kryptonButton6.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButton6.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButton6.StateDisabled.Back.Color1 = SystemColors.Control;
            kryptonButton6.StateDisabled.Back.Color2 = SystemColors.Control;
            kryptonButton6.StateNormal.Back.Color1 = SystemColors.Control;
            kryptonButton6.StateNormal.Back.Color2 = SystemColors.Control;
            kryptonButton6.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton6.StatePressed.Back.Color2 = Color.DarkGray;
            kryptonButton6.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton6.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton6.TabIndex = 10;
            kryptonButton6.Values.Text = "Placeholder1";
            kryptonButton6.Click += kryptonButton6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private KryptonButton kryptonButton6;
        private KryptonButton exitButton;
        private KryptonButton kryptonButton7;
        private KryptonButton minimiseButton;
        private KryptonButton maximiseButton;
    }
}