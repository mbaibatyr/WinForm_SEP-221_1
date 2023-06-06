using MyWPF.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyWPF
{
    /// <summary>
    /// Логика взаимодействия для MyCRUD.xaml
    /// </summary>
    public partial class MyCRUD : Window
    {
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

                    var result = from DataRow row in dt.Rows
                           select new Student
                           {
                               id = int.Parse(row["id"].ToString()),
                               firstName = row["firstName"].ToString(),
                               lastName = row["lastName"].ToString(),
                               iin= row["iin"].ToString(),
                               dateBirth = DateTime.Parse(row["dateBirth"].ToString()),
                               gender = row["gender"].ToString()
                           };

                    grStudent.ItemsSource= result;
                }
            }
        }
        public MyCRUD()
        {
            InitializeComponent();
            SearchStudent();
        }
    }
}
