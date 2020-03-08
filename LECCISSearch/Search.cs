﻿using System;
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
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;username=dbstudent14;password=spicymonster10;");
        MySqlDataAdapter adpt;
        DataTable dt;

        public searchForm()
        {
            InitializeComponent();
            myconnection.Open();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {


            adpt = new MySqlDataAdapter("Select O.firstName, O.lastName, O.email, O.phoneNumber, P.streetNumnber, P.city, P.state, P.zip, P.acres, P.sqft From Owner O, Property P, OwnerWithProperty OP where O.OwnerId = OP.OwnerId AND P.PropertyId = OP.PropertyId AND streetNumnber like '%" + searchPropertyStreetTextBox.Text + "%'", myconnection);
            dt = new DataTable();
            adpt.Fill(dt);
            resultsDataGridView.DataSource = dt;
            searchPropertyStreetTextBox.Clear();

            //if (searchPropertyStreetTextBox.TextLength == 0)
            //{
            //    MessageBox.Show("Search field cannot be empty.", "Invalid Input", MessageBoxButtons.OK);
            //    searchPropertyStreetTextBox.Clear();
            //}
            //else
            //{

            //}
        }
    }
}

