namespace LECCISAddProperty
{
  partial class addProperty
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProperty));
      this.Address = new System.Windows.Forms.TextBox();
      this.City = new System.Windows.Forms.TextBox();
      this.State = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.Zip = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // Address
      // 
      this.Address.ForeColor = System.Drawing.Color.Gray;
      resources.ApplyResources(this.Address, "Address");
      this.Address.Name = "Address";
      this.Address.UseWaitCursor = true;
      this.Address.Enter += new System.EventHandler(this.Address_Enter);
      this.Address.Leave += new System.EventHandler(this.Address_Leave);
      // 
      // City
      // 
      resources.ApplyResources(this.City, "City");
      this.City.Name = "City";
      this.City.UseWaitCursor = true;
      // 
      // State
      // 
      resources.ApplyResources(this.State, "State");
      this.State.Name = "State";
      this.State.UseWaitCursor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      resources.ApplyResources(this.comboBox1, "comboBox1");
      this.comboBox1.Name = "comboBox1";
      // 
      // Zip
      // 
      resources.ApplyResources(this.Zip, "Zip");
      this.Zip.Name = "Zip";
      this.Zip.UseWaitCursor = true;
      // 
      // addProperty
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.Controls.Add(this.Zip);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.State);
      this.Controls.Add(this.City);
      this.Controls.Add(this.Address);
      this.Name = "addProperty";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox Address;
    private System.Windows.Forms.TextBox City;
    private System.Windows.Forms.TextBox State;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox Zip;
  }
}

