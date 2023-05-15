using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class fmDialog : Form
    {
        public fmDialog()
        {
            InitializeComponent();
        }

        private void btFileOpen_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Отменено пользователем", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tbFileName.Text = openFileDialog1.FileName;
        }

        private void btExcelOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\Temp\Test";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Отменено пользователем", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Process.Start(openFileDialog.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                if(i % 2 == 0)
                    checkedListBox1.Items.Add(i.ToString(), true);
                else
                    checkedListBox1.Items.Add(i.ToString());
            }
            string st = "123" + Environment.NewLine + "456";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void fmDialog_Load(object sender, EventArgs e)
        {
            //int VisibleTime = 1000;
            //ToolTip t = new ToolTip();
            //t.Show("Hello World", btFileOpen, 0,0, VisibleTime);
            ///toolTip1.SetToolTip(tbFileName, "Save changes");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tbFileName_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = true;
            tt.Show(string.Empty, tbFileName);
            tt.Show("I need help", tbFileName, 0);
        }
    }
}
