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
    public partial class fmCrud : Form
    {
        public fmCrud()
        {
            InitializeComponent();
        }

        void SearchStudent()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentGetAll @iin", con))
                {
                    if(string.IsNullOrEmpty(tbIin.Text))
                        cmd.Parameters.AddWithValue("iin", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("iin", tbIin.Text);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    gvStudent.DataSource = dt;
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbFN.Text = "";
            tbLN.Text = "";
            tbIIN2.Text = "";
            cbGender.SelectedIndex = -1;
            dtpDateBirth.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentIns @iin, @lastName, @firstName, @dateBirth, @gender", con))
                {
                    cmd.Parameters.AddWithValue("iin", tbIIN2.Text);
                    cmd.Parameters.AddWithValue("lastName", tbLN.Text);
                    cmd.Parameters.AddWithValue("firstName", tbFN.Text);
                    cmd.Parameters.AddWithValue("dateBirth", dtpDateBirth.Value);
                    cmd.Parameters.AddWithValue("gender", cbGender.SelectedIndex == 0 ? "m" : "f");
                    var status = int.Parse(cmd.ExecuteScalar().ToString());
                    if (status == 0)
                        MessageBox.Show("Данный студент уже существует");
                    else
                        MessageBox.Show("Студент успешно добавлен");
                }
                con.Close();
            }
        }

        private void gvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Text = gvStudent.SelectedCells[0].Value.ToString();
        }
    }
}
