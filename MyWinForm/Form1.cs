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

        private void button1_Click(object sender, EventArgs e)
        {
            var login = ConfigurationManager.AppSettings["login"];
            var password = ConfigurationManager.AppSettings["password"];
            Text = login + " " + password;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
