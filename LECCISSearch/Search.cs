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
        public searchForm()
        {
            InitializeComponent();

            string connString = "Server= 209.106.201.103; Database=group6; uid=dbstudent14;pwd=spicymonster10";
            MySqlConnection conn = new MySqlConnection(connString);
            
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchOwnerFNTextBox.TextLength == 0)
            {
                if (searchOwnerLNTextBox.TextLength == 0)
                {
                    if (searchPropertyStreetTextBox.TextLength == 0)
                    {
                        MessageBox.Show("Must search at least one variable.", "Invalid Input", MessageBoxButtons.OK);
                        searchOwnerFNTextBox.Clear();
                        searchOwnerLNTextBox.Clear();
                        searchPropertyStreetTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Searching by Street Address.", "Search Message", MessageBoxButtons.OK);
                        searchOwnerFNTextBox.Clear();
                        searchOwnerLNTextBox.Clear();
                        searchPropertyStreetTextBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Searching by lastname.", "Search Message", MessageBoxButtons.OK);
                    searchOwnerFNTextBox.Clear();
                    searchOwnerLNTextBox.Clear();
                    searchPropertyStreetTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Searching by firstname.", "Search Message", MessageBoxButtons.OK);
                searchOwnerFNTextBox.Clear();
                searchOwnerLNTextBox.Clear();
                searchPropertyStreetTextBox.Clear();
            }
        }

    }

}
