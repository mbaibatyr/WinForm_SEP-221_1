using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                    if (string.IsNullOrEmpty(tbIin.Text))
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

        private void btTypeReport_Click(object sender, EventArgs e)
        {
            var dt = getDataReport();
            doReport(EnumType.csvEnum, dt);

        }

        string doReport(EnumType enumType, DataTable dt)
        {
            try
            {
                if (enumType == EnumType.csvEnum)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("iin;lastName;firstName");
                    foreach (DataRow row in dt.Rows)
                    {
                        sb.AppendLine(row[0].ToString() + ";" + 
                            row["lastName"].ToString() + ";" + 
                            row[2].ToString());
                    }
                    File.WriteAllText(DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".csv", sb.ToString(), Encoding.UTF8);
                }
                else
                {

                }
                return "ok";
            }
            catch (Exception err)
            {
                return "error. " + err.Message ;
            }
        }

        DataTable getDataReport()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentRep1", con))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    con.Close();
                    return dt;
                }
            }
        }
    }
}
