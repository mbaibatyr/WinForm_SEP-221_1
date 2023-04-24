﻿using MyWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btTestConnection_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString()))
            {
                con.Open();
                Text = con.State.ToString();
            }
        }

        private void btLoadFromList_Click(object sender, EventArgs e)
        {
            List<City> cities = new List<City>()
            {
                new City(){id=1, name="Atyrau"},
                new City(){id=2, name="Aktau"},
                new City(){id=3, name="Alga"}
            };
            cities.Add(new City() { id = 4, name = "Shymkent" });

            cbCity.Items.Clear();
            cbCity.DataSource = cities;
        }

        private void btLoadFromDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                //Text = con.State.ToString();
                using (SqlCommand cmd = new SqlCommand("select id, name from CITY", con))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    cbCity.Items.Clear();
                    cbCity.DataSource = dt;
                }
            }
        }
    }
}
