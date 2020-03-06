namespace LECCISSearch
{
  partial class searchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOwnerFNTextBox = new System.Windows.Forms.TextBox();
            this.searchOwnerLNTextBox = new System.Windows.Forms.TextBox();
            this.searchPropertyStreetTextBox = new System.Windows.Forms.TextBox();
            this.searchPropertyStreetLabel = new System.Windows.Forms.Label();
            this.searchOwnerFNLabel = new System.Windows.Forms.Label();
            this.searchOwnerLNLabel = new System.Windows.Forms.Label();
            this.searchOwnerLabel = new System.Windows.Forms.Label();
            this.searchPropertyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(912, 844);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(206, 66);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchOwnerFNTextBox
            // 
            this.searchOwnerFNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOwnerFNTextBox.Location = new System.Drawing.Point(440, 223);
            this.searchOwnerFNTextBox.Name = "searchOwnerFNTextBox";
            this.searchOwnerFNTextBox.Size = new System.Drawing.Size(300, 38);
            this.searchOwnerFNTextBox.TabIndex = 1;
            // 
            // searchOwnerLNTextBox
            // 
            this.searchOwnerLNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOwnerLNTextBox.Location = new System.Drawing.Point(440, 323);
            this.searchOwnerLNTextBox.Name = "searchOwnerLNTextBox";
            this.searchOwnerLNTextBox.Size = new System.Drawing.Size(300, 38);
            this.searchOwnerLNTextBox.TabIndex = 2;
            // 
            // searchPropertyStreetTextBox
            // 
            this.searchPropertyStreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetTextBox.Location = new System.Drawing.Point(1519, 223);
            this.searchPropertyStreetTextBox.Name = "searchPropertyStreetTextBox";
            this.searchPropertyStreetTextBox.Size = new System.Drawing.Size(438, 38);
            this.searchPropertyStreetTextBox.TabIndex = 3;
            // 
            // searchPropertyStreetLabel
            // 
            this.searchPropertyStreetLabel.AutoSize = true;
            this.searchPropertyStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetLabel.Location = new System.Drawing.Point(1262, 223);
            this.searchPropertyStreetLabel.Name = "searchPropertyStreetLabel";
            this.searchPropertyStreetLabel.Size = new System.Drawing.Size(228, 37);
            this.searchPropertyStreetLabel.TabIndex = 4;
            this.searchPropertyStreetLabel.Text = "Street Address";
            // 
            // searchOwnerFNLabel
            // 
            this.searchOwnerFNLabel.AutoSize = true;
            this.searchOwnerFNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOwnerFNLabel.Location = new System.Drawing.Point(183, 223);
            this.searchOwnerFNLabel.Name = "searchOwnerFNLabel";
            this.searchOwnerFNLabel.Size = new System.Drawing.Size(175, 37);
            this.searchOwnerFNLabel.TabIndex = 5;
            this.searchOwnerFNLabel.Text = "First Name";
            // 
            // searchOwnerLNLabel
            // 
            this.searchOwnerLNLabel.AutoSize = true;
            this.searchOwnerLNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOwnerLNLabel.Location = new System.Drawing.Point(183, 323);
            this.searchOwnerLNLabel.Name = "searchOwnerLNLabel";
            this.searchOwnerLNLabel.Size = new System.Drawing.Size(173, 37);
            this.searchOwnerLNLabel.TabIndex = 6;
            this.searchOwnerLNLabel.Text = "Last Name";
            // 
            // searchOwnerLabel
            // 
            this.searchOwnerLabel.AutoSize = true;
            this.searchOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOwnerLabel.Location = new System.Drawing.Point(360, 114);
            this.searchOwnerLabel.Name = "searchOwnerLabel";
            this.searchOwnerLabel.Size = new System.Drawing.Size(266, 37);
            this.searchOwnerLabel.TabIndex = 7;
            this.searchOwnerLabel.Text = "Search By Owner";
            // 
            // searchPropertyLabel
            // 
            this.searchPropertyLabel.AutoSize = true;
            this.searchPropertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyLabel.Location = new System.Drawing.Point(1512, 114);
            this.searchPropertyLabel.Name = "searchPropertyLabel";
            this.searchPropertyLabel.Size = new System.Drawing.Size(292, 37);
            this.searchPropertyLabel.TabIndex = 8;
            this.searchPropertyLabel.Text = "Search By Property";
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2140, 1314);
            this.Controls.Add(this.searchPropertyLabel);
            this.Controls.Add(this.searchOwnerLabel);
            this.Controls.Add(this.searchOwnerLNLabel);
            this.Controls.Add(this.searchOwnerFNLabel);
            this.Controls.Add(this.searchPropertyStreetLabel);
            this.Controls.Add(this.searchPropertyStreetTextBox);
            this.Controls.Add(this.searchOwnerLNTextBox);
            this.Controls.Add(this.searchOwnerFNTextBox);
            this.Controls.Add(this.searchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchForm";
            this.Text = "Law Enforcement Community Check Information System (LECCIS)";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.TextBox searchOwnerFNTextBox;
    private System.Windows.Forms.TextBox searchOwnerLNTextBox;
    private System.Windows.Forms.TextBox searchPropertyStreetTextBox;
    private System.Windows.Forms.Label searchPropertyStreetLabel;
    private System.Windows.Forms.Label searchOwnerFNLabel;
    private System.Windows.Forms.Label searchOwnerLNLabel;
    private System.Windows.Forms.Label searchOwnerLabel;
    private System.Windows.Forms.Label searchPropertyLabel;
  }
}

