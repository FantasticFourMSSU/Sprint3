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
      this.Property = new System.Windows.Forms.Label();
      this.addRecord = new System.Windows.Forms.Button();
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
      this.City.ForeColor = System.Drawing.Color.Gray;
      resources.ApplyResources(this.City, "City");
      this.City.Name = "City";
      this.City.UseWaitCursor = true;
      // 
      // State
      // 
      this.State.ForeColor = System.Drawing.Color.Gray;
      resources.ApplyResources(this.State, "State");
      this.State.Name = "State";
      this.State.UseWaitCursor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.ForeColor = System.Drawing.Color.Gray;
      this.comboBox1.FormattingEnabled = true;
      resources.ApplyResources(this.comboBox1, "comboBox1");
      this.comboBox1.Name = "comboBox1";
      // 
      // Zip
      // 
      this.Zip.ForeColor = System.Drawing.Color.Gray;
      resources.ApplyResources(this.Zip, "Zip");
      this.Zip.Name = "Zip";
      this.Zip.UseWaitCursor = true;
      // 
      // Property
      // 
      resources.ApplyResources(this.Property, "Property");
      this.Property.Name = "Property";
      // 
      // addRecord
      // 
      resources.ApplyResources(this.addRecord, "addRecord");
      this.addRecord.Name = "addRecord";
      this.addRecord.UseVisualStyleBackColor = true;
      // 
      // addProperty
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.Controls.Add(this.addRecord);
      this.Controls.Add(this.Property);
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
    private System.Windows.Forms.Label Property;
    private System.Windows.Forms.Button addRecord;
  }
}

