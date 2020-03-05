using MySql.Data.MySqlClient;
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

    private TextBox firstNameDisplay;
    private TextBox lastNameDisplay;
    private TextBox phoneNumberDisplay;
    private TextBox emailDisplay;


    public addOwnerForm()
    {
      InitializeComponent();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstNameDisplay.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            phoneNumberDisplay.Text = "";
        }

       

        private void email_TextChanged(object sender, EventArgs e)
        {
            emailDisplay.Text = "";
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            lastNameDisplay.Text = "";
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.Control;
        }

        private MySqlConnection ConnectToDatabase()
        {
            string myconnection = "Server= 209.106.201.103; Database=group6; uid=dbstudent14;pwd=spicymonster10";
            MySqlConnection conn = new MySqlConnection(myconnection);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("connection opened");
                
            }
            return conn;


        }

        private void button_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectToDatabase();

            string sql = "SELECT * FROM Owner";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show(string.Format("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
                                rdr.GetString(2)));

                    }

                }
            }
            conn.Close();



            //string str = "datasource = ; username = ; password =  ";
            //string query = "INSERT INTO Owner( firstName, lastName, phoneNumber, email) VALUES (' " + this.firstNameDisplay.Text + " ','" + this.lastNameDisplay.Text + " ', '" + this.phoneNumberDisplay.Text + " ',' " + this.emailDisplay.Text + "')";
            //SqlConnection con = new SqlConnection(str);
            //SqlCommand cmd = new SqlCommand(query, con);

            //try
            //{
            //    con.open();
            //    DataSet ds = new DataSet();
            //    MessageBox.Show("Saved");
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
