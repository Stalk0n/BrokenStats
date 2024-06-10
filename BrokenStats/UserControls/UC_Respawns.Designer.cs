using System.Windows.Forms;

namespace BrokenStats.UserControls
{
    partial class UcRespawns
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            customButton1 = new CustomControls.CustomButton();
            customButton2 = new CustomControls.CustomButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 50);
            panel1.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 497F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Location = new Point(150, 170);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Size = new Size(850, 75);
            tableLayoutPanel1.TabIndex = 48;
            // 
            // label1
            // 
            label1.Location = new Point(575, 53);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 49;
            label1.Text = "Timers";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.MediumSlateBlue;
            customButton1.BackgroundColor = Color.MediumSlateBlue;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.Dock = DockStyle.Bottom;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(0, 577);
            customButton1.Margin = new Padding(3, 2, 3, 2);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(1150, 23);
            customButton1.TabIndex = 50;
            customButton1.Text = "tester";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.MediumSlateBlue;
            customButton2.BackgroundColor = Color.MediumSlateBlue;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 0;
            customButton2.BorderSize = 0;
            customButton2.Dock = DockStyle.Bottom;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(0, 554);
            customButton2.Margin = new Padding(3, 2, 3, 2);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(1150, 23);
            customButton2.TabIndex = 51;
            customButton2.Text = "tester";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 497F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Controls.Add(kryptonLabel1, 0, 0);
            tableLayoutPanel2.Controls.Add(kryptonLabel2, 1, 0);
            tableLayoutPanel2.Controls.Add(kryptonLabel3, 2, 0);
            tableLayoutPanel2.Controls.Add(kryptonLabel4, 3, 0);
            tableLayoutPanel2.Location = new Point(150, 97);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel2.Size = new Size(850, 75);
            tableLayoutPanel2.TabIndex = 49;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonLabel1.Location = new Point(4, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(64, 67);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Ikona";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonLabel2.Location = new Point(75, 4);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(144, 67);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Nazwa";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonLabel3.Location = new Point(226, 4);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(491, 67);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Lokacja";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonLabel4.Location = new Point(724, 4);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(122, 67);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.Text = "Czas";
            // 
            // UC_Respawns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UcRespawns";
            Size = new Size(1150, 600);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomButton customButton2;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}
