using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LECCISAddOwner
{
  public partial class addOwnerForm : Form
  {
    public addOwnerForm()
    {
      InitializeComponent();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string str = "datasource = ; username = ; password =  ";
            string query = "INSERT INTO Owner( firstName, lastName, phoneNumber, email) VALUES (' " + this.firstName.Text + " ','" + this.lastName.Text + " ', '" + this.phoneNumber.Text + " ',' " + this.email.Text; "');
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
          
            try
            {
                con.open();
                DataSet ds = new DataSet();
                MessageBox.Show("Saved");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
