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
    public partial class FormOrdersList : Form
    {
        BL.AddContract con = new BL.AddContract();
        public FormOrdersList()
        {
            InitializeComponent();
            /// if we set the parameter to null it brings them all
            this.dataGridView1.DataSource = con.SearchOrders("");
            this.dataGridView1.Columns[2].Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = con.SearchOrders(textSearch.Text);
                this.dataGridView1.Columns[2].Visible = false;
            }
            catch
            {
                return;
            }
           
        }

        private void showprintone_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Reports.ContractReport report = new Reports.ContractReport();
            Reports.ClothesReport frm = new Reports.ClothesReport();
            report.SetDataSource(con.GetOrderDetails(id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }

        private void deleteCon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    DataTable d = new DataTable();
                    //first fetch item id
                   d= con.GetItemIDForUpdatingQty(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    //checking if the bill has details
                    if (d.Rows.Count < 1)
                    {
                        con.DeleteOrder(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));


                        MessageBox.Show(
                       "تمت الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dataGridView1.DataSource = con.SearchOrders("");
                        this.dataGridView1.Columns[2].Visible = false;

                        return;
                    }
                    else
                    {
                        string item_id = d.Rows[0][0].ToString();
                        //second fetch qty
                        d = con.GetQtyBeforeDelete(item_id, Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        int qty = Convert.ToInt32(d.Rows[0][0].ToString());
                        /////// update before delet
                        con.updateQtyBeforeDelete(item_id, qty);
                        con.DeleteOrder(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));


                        MessageBox.Show(
                       "تمت الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dataGridView1.DataSource = con.SearchOrders("");
                        this.dataGridView1.Columns[2].Visible = false;
                    }
                   

                }
                catch(Exception ec)
                {
                    MessageBox.Show(  ec.ToString(), "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {
                MessageBox.Show("تم الغاء الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

        }

        private void AddNEw_Click(object sender, EventArgs e)
        {
            new ContractSales().ShowDialog();
            this.dataGridView1.DataSource = con.SearchOrders("");

        }

        private void تعديلالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractSales conFrm = new ContractSales();
            BL.ProfitsClass pr = new BL.ProfitsClass();
            DataTable d = new DataTable();
            d = con.GetDetailsByOrderID(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            conFrm.ConID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            conFrm.Con_date.Value = (DateTime)this.dataGridView1.CurrentRow.Cells[1].Value;
            conFrm.Con_user.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            conFrm.ConNote.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            conFrm.custId.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            conFrm.Total.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (this.dataGridView1.CurrentRow.Cells[7].Value.ToString() != string.Empty)
            {
                conFrm.debit.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                conFrm.paid.Text = Convert.ToString(Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[6].Value.ToString()) -   Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[7].Value.ToString()));
            }
            conFrm.PricePrev = Convert.ToDouble(pr.GetProfitPeforeUpdating(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString());
           
            conFrm.dataGridView1.DataSource = d;
            conFrm.Text = " :تحديث بيانات الفاتورة المحددة " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            conFrm.SaveSale.Text = "تحديث";
            conFrm.ConState = "edit";
            conFrm.newSale.Enabled = false;
            conFrm.Print.Enabled = false;
            conFrm.choosebtn.Enabled = false;
            conFrm.CustChoosBtn.Enabled = false;
            conFrm.SetDatatableForUpdate(d);
            conFrm.SaveSale.Enabled = true;
           // conFrm.paid.ReadOnly = true;
            conFrm.حذفالسطرالحاليToolStripMenuItem.Enabled = false;
            conFrm.حذفالكلToolStripMenuItem.Enabled = false;

            conFrm.ShowDialog();
            if (conFrm.closed)
            {
                this.dataGridView1.DataSource = con.SearchOrders(textSearch.Text);
                this.dataGridView1.Columns[2].Visible = false;
            }


        }

        private void اظهارسجلالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.LogList log = new LogList();
            log.textSearch.Text=(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            log.Text = " عرض سجل الفاتورة رقم " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            log.ShowDialog();
        }

        private void تفاصيلالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.OrderDetailsForm ordfrm = new OrderDetailsForm();
            ordfrm.searchText.Text = (this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ordfrm.Text = " عرض تفاصيل الفاتورة رقم" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ordfrm.ShowDialog();
        }
    }
    
}
