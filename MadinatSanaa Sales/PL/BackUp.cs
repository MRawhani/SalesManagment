using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace MadinatSanaa_Sales.PL
{
    public partial class BackUp : Form
    {
        SqlConnection con = new SqlConnection(@"server= .\SQLEXPRESS; Database= MadinatSales_d;Integrated Security=false; User ID=sa; Password=moh123456");
        SqlCommand cmd;
        public BackUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateBakcup_Click(object sender, EventArgs e)
        {
            if (FileName.Text != string.Empty)
            {
                try
                {
                    //the replace cuz the file names can't hold / or :
                    string name = FileName.Text + "\\MadinatSales_d" + " - " +
                        DateTime.Now.ToShortDateString().Replace('/', '-')
                        + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string qu = "Backup Database MadinatSales_d to Disk='" + name + ".bak'";
                    cmd = new SqlCommand(qu, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم انشاء النسخة بنجاح", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show(" رجاءاً حدد المسار الذي تريد الحفظ فيه", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
