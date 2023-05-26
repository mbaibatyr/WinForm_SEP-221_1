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
using ClosedXML;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            if (cbTypeReport.SelectedIndex == 0)
                doReport(EnumType.csvEnum, dt);
            else if (cbTypeReport.SelectedIndex == 1)
                doReport(EnumType.excelEnum, dt);
            else if (cbTypeReport.SelectedIndex == 2)
                doReport(EnumType.pdfEnum, dt);

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
                else if (enumType == EnumType.excelEnum)
                {
                    var wb = new XLWorkbook();
                    wb.AddWorksheet(dt, "report");
                    wb.SaveAs(DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".xlsx");
                }
                else if (enumType == EnumType.pdfEnum)
                {
                    ExportToPdf(dt, DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".pdf");
                }
                return "ok";
            }
            catch (Exception err)
            {
                return "error. " + err.Message;
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

        public void ExportToPdf(DataTable dt, string strFilePath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(strFilePath, FileMode.Create));
            document.Open();
            //iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 5);
            //iTextSharp.text.Font font5 = FontFactory.GetFont("/fonts/DejaVuSans.ttf", "cp1251", BaseFont.EMBEDDED, 10);
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, "Cp1250", true);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                widths[i] = 4f;

            table.SetWidths(widths);

            table.WidthPercentage = 100;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Products"));

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), font5));
                    }
                }
            }
            document.Add(table);
            document.Close();
        }


    }
}
