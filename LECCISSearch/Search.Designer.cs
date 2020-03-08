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
            this.searchPropertyStreetTextBox = new System.Windows.Forms.TextBox();
            this.searchPropertyStreetLabel = new System.Windows.Forms.Label();
            this.searchPropertyLabel = new System.Windows.Forms.Label();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1459, 85);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(129, 37);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPropertyStreetTextBox
            // 
            this.searchPropertyStreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetTextBox.Location = new System.Drawing.Point(979, 85);
            this.searchPropertyStreetTextBox.Name = "searchPropertyStreetTextBox";
            this.searchPropertyStreetTextBox.Size = new System.Drawing.Size(438, 38);
            this.searchPropertyStreetTextBox.TabIndex = 3;
            // 
            // searchPropertyStreetLabel
            // 
            this.searchPropertyStreetLabel.AutoSize = true;
            this.searchPropertyStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyStreetLabel.Location = new System.Drawing.Point(532, 85);
            this.searchPropertyStreetLabel.Name = "searchPropertyStreetLabel";
            this.searchPropertyStreetLabel.Size = new System.Drawing.Size(383, 37);
            this.searchPropertyStreetLabel.TabIndex = 4;
            this.searchPropertyStreetLabel.Text = "Search By Street Address";
            // 
            // searchPropertyLabel
            // 
            this.searchPropertyLabel.AutoSize = true;
            this.searchPropertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropertyLabel.Location = new System.Drawing.Point(812, 46);
            this.searchPropertyLabel.Name = "searchPropertyLabel";
            this.searchPropertyLabel.Size = new System.Drawing.Size(0, 37);
            this.searchPropertyLabel.TabIndex = 8;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(41, 196);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowTemplate.Height = 33;
            this.resultsDataGridView.Size = new System.Drawing.Size(2039, 421);
            this.resultsDataGridView.TabIndex = 9;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2121, 667);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.searchPropertyLabel);
            this.Controls.Add(this.searchPropertyStreetLabel);
            this.Controls.Add(this.searchPropertyStreetTextBox);
            this.Controls.Add(this.searchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchForm";
            this.Text = "Law Enforcement Community Check Information System (LECCIS)";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.TextBox searchPropertyStreetTextBox;
    private System.Windows.Forms.Label searchPropertyStreetLabel;
    private System.Windows.Forms.Label searchPropertyLabel;
    private System.Windows.Forms.DataGridView resultsDataGridView;
    }
}

