using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LECCISSearch
{

    public partial class searchForm : Form
    {
        string myconnection = "Server= 209.106.201.103; Database=group6; username=dbstudent14; password=spicymonster10";

        public searchForm()
        {
            InitializeComponent();



        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchPropertyStreetTextBox.TextLength == 0)
            {
                MessageBox.Show("Must search at least one variable.", "Invalid Input", MessageBoxButtons.OK);
                searchPropertyStreetTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Searching by Street Address.", "Search Message", MessageBoxButtons.OK);
                searchPropertyStreetTextBox.Clear();

                using (MySqlConnection mysqlCon = new MySqlConnection(myconnection))
                {
                    string query = "Select O.firstName, O.lastName, O.email, O.phoneNumber, P.streetNumnber,P.city, P.state, P.zip, P.acres, P.sqft From Owner O, Property P, OwnerWithProperty OP where O.OwnerId = OP.OwnerId AND P.PropertyId = OP.PropertyId AND streetNumnber like '%" + searchPropertyStreetTextBox.Text +"%';";
                    mysqlCon.Open();
                    DataTable ds = new DataTable();
                    MySqlDataAdapter cols = new MySqlDataAdapter(query, myconnection);
                    resultsDataGridView.DataSource = ds.AsDataView();
                }
            }
            }
        }

    }
