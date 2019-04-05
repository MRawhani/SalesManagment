using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadinatSanaa_Sales.PL
{
    public partial class UsersList : Form
    {
        BL.UseresClass user = new BL.UseresClass();
        public UsersList()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = user.Searchusers("");
        }

        private void AddNEw_Click(object sender, EventArgs e)
        {
            new FormUsers().ShowDialog();
            this.dataGridView1.DataSource = user.Searchusers("");

        }

        private void deleteCon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                try
                {
                    user.Deleteuser(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    this.dataGridView1.DataSource = user.Searchusers("");
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("قم بتحديد صف في الجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {
                MessageBox.Show("تم الغاء الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
           
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = user.Searchusers(textSearch.Text);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
