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
    public partial class Restore : Form
    {
        // we put master incase the Database is removed
        SqlConnection con = new SqlConnection(@"server= .\SQLEXPRESS; Database=master;Integrated Security=false; User ID=sa; Password=moh123456");
        SqlCommand cmd;
        public Restore()
        {
            InitializeComponent();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = openFileDialog1.FileName;
            }
        }

        private void CreateBakcup_Click(object sender, EventArgs e)
        {
            if (FileName.Text != string.Empty)
            {
                try
                {
                    //the replace cuz the file names can't hold / or :

                    string qu = "ALTER Database MadinatSales_d SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database MadinatSales_d from Disk='" + FileName.Text + "'";
                    cmd = new SqlCommand(qu, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تمت الاستعادة بنجاح", "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show(" رجاءاً حدد المسار الذي تريد الاستعادة منه", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }
    }
}
