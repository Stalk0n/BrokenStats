partial class NetworkInterfaceSelectorForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ComboBox comboBoxInterfaces;
    private System.Windows.Forms.Button buttonOk;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.comboBoxInterfaces = new System.Windows.Forms.ComboBox();
        this.buttonOk = new System.Windows.Forms.Button();

        // 
        // comboBoxInterfaces
        // 
        this.comboBoxInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBoxInterfaces.FormattingEnabled = true;
        this.comboBoxInterfaces.Location = new System.Drawing.Point(12, 12);
        this.comboBoxInterfaces.Name = "comboBoxInterfaces";
        this.comboBoxInterfaces.Size = new System.Drawing.Size(360, 23);

        // 
        // buttonOk
        // 
        this.buttonOk.Location = new System.Drawing.Point(12, 50);
        this.buttonOk.Name = "buttonOk";
        this.buttonOk.Size = new System.Drawing.Size(75, 23);
        this.buttonOk.Text = "OK";
        this.buttonOk.UseVisualStyleBackColor = true;

        // 
        // NetworkInterfaceSelectorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(384, 91);
        this.Controls.Add(this.comboBoxInterfaces);
        this.Controls.Add(this.buttonOk);
        this.Name = "NetworkInterfaceSelectorForm";
        this.Text = "Select Network Interface";
    }

    #endregion
}