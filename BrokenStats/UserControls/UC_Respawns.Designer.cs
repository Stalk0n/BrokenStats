using System.Windows.Forms;

namespace BrokenStats.UserControls
{
    partial class UC_Respawns
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
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Location = new Point(150, 70);
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
            // UC_Respawns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UC_Respawns";
            Size = new Size(1150, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomButton customButton2;
    }
}
