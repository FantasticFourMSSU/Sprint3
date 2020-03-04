namespace LECCISAddOwner
{
  partial class addOwnerForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOwnerForm));
      this.firstName = new System.Windows.Forms.TextBox();
      this.lastName = new System.Windows.Forms.TextBox();
      this.phoneNumber = new System.Windows.Forms.TextBox();
      this.email = new System.Windows.Forms.TextBox();
      this.button = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // firstName
      // 
      this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstName.ForeColor = System.Drawing.Color.Gray;
      this.firstName.Location = new System.Drawing.Point(575, 162);
      this.firstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.firstName.Name = "firstName";
      this.firstName.Size = new System.Drawing.Size(232, 26);
      this.firstName.TabIndex = 0;
      this.firstName.Text = "First Name";
      this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // lastName
      // 
      this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastName.ForeColor = System.Drawing.Color.Gray;
      this.lastName.Location = new System.Drawing.Point(575, 246);
      this.lastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lastName.Name = "lastName";
      this.lastName.Size = new System.Drawing.Size(232, 26);
      this.lastName.TabIndex = 1;
      this.lastName.Text = "Last Name";
      this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
      // 
      // phoneNumber
      // 
      this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneNumber.ForeColor = System.Drawing.Color.Gray;
      this.phoneNumber.Location = new System.Drawing.Point(575, 335);
      this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.phoneNumber.Name = "phoneNumber";
      this.phoneNumber.Size = new System.Drawing.Size(232, 26);
      this.phoneNumber.TabIndex = 2;
      this.phoneNumber.Text = "Phone Number";
      this.phoneNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // email
      // 
      this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.email.ForeColor = System.Drawing.Color.Gray;
      this.email.Location = new System.Drawing.Point(575, 421);
      this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.email.Name = "email";
      this.email.Size = new System.Drawing.Size(232, 26);
      this.email.TabIndex = 3;
      this.email.Text = "Email";
      this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
      // 
      // button
      // 
      this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button.Location = new System.Drawing.Point(603, 567);
      this.button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button.Name = "button";
      this.button.Size = new System.Drawing.Size(192, 54);
      this.button.TabIndex = 4;
      this.button.Text = "Add Record";
      this.button.UseVisualStyleBackColor = true;
      this.button.Click += new System.EventHandler(this.button_Click);
      
      // 
      // addOwnerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(1427, 841);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button);
      this.Controls.Add(this.email);
      this.Controls.Add(this.phoneNumber);
      this.Controls.Add(this.lastName);
      this.Controls.Add(this.firstName);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "addOwnerForm";
      this.Text = "Law Enforcement Community Check Information System (LECCIS)";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

