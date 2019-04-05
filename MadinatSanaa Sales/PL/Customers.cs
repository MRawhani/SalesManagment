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
    public partial class Customers : Form
    { 
        BL.CustomersClass cust = new BL.CustomersClass();
        int id,position;
       
        /* // this time we are going to do the operations here directly
         SqlConnection con = new SqlConnection(@"server= .\SQLEXPRESS; Database= MadinatSales_d; Integrated Security=false; User ID=sa; Password=moh123456");
         SqlDataAdapter da;
         DataTable dt = new DataTable();
         // this is for dealing with next and prev buttons
         // this gives you the control as you had in oracle
         BindingManagerBase bmb;
         // this is for updating commands
         SqlCommandBuilder comdb;*/
        public Customers()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.ShowAll();
            // this is for hiding the id يعتمد على رتبته في الاجراء المخزن
            this.dataGridView1.Columns[0].Visible = false;
            labelposition.Text = (1) + " / " + cust.ShowAll().Rows.Count;
            fetchfirst.Enabled = false;
            fetchprev.Enabled = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (!deletebtn.Enabled)
            {
                if (MessageBox.Show(
              "هناك بعض العمليات لم تكتمل ! هل أنت متأكد من الاغلاق؟", "عملية الاغلاق", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    addbtn.Focus();
                }



            }
            else
            {
                this.Close();
            }

        }

        private void fetchfirst_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == 0)
            {
                MessageBox.Show("لايوجد حقول سابقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fetchfirst.Enabled = false;
                fetchprev.Enabled = false;
                fetchlast.Enabled = true;
                fetchnext.Enabled = true;
            }
            else
            {
                position = 0;
                Navigate(position);
                fetchfirst.Enabled = false;
                fetchprev.Enabled = false;
                fetchlast.Enabled = true;
                fetchnext.Enabled = true;
                labelposition.Text = (position + 1) + " / " + cust.ShowAll().Rows.Count;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[position].Cells[this.dataGridView1.CurrentCell.ColumnIndex];

            }
        }

        private void fetchprev_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Index == 0)
            {
                MessageBox.Show("لايوجد حقول سابقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fetchfirst.Enabled = false;
                fetchprev.Enabled = false;
                fetchlast.Enabled = true;
                fetchnext.Enabled = true;
            }
            else
            {
                position = this.dataGridView1.CurrentRow.Index - 1;
                Navigate(position);
                labelposition.Text = (position + 1) + " / " + cust.ShowAll().Rows.Count;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[position].Cells[this.dataGridView1.CurrentCell.ColumnIndex];

                if (position == 0)
                {
                    fetchfirst.Enabled = false;
                    fetchprev.Enabled = false;
                    fetchlast.Enabled = true;
                    fetchnext.Enabled = true;
                }
                else
                {
                    fetchfirst.Enabled = true;
                    fetchprev.Enabled = true;
                    fetchlast.Enabled = true;
                    fetchnext.Enabled = true;
                }
            }
           
        }

        private void fetchnext_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == cust.ShowAll().Rows.Count-1)
            {
                MessageBox.Show("لايوجد حقول لاحقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fetchlast.Enabled = false;
                fetchnext.Enabled = false;
                fetchfirst.Enabled = true;
                fetchprev.Enabled = true;
            }
            else
            {
                // this is for getting the current row in the dataGridview
                position = this.dataGridView1.CurrentRow.Index + 1;
                Navigate(position);
                labelposition.Text = (position + 1) + " / " + cust.ShowAll().Rows.Count;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[position].Cells[this.dataGridView1.CurrentCell.ColumnIndex];

                if (position == (cust.ShowAll().Rows.Count - 1))
                {
                    fetchfirst.Enabled = true;
                    fetchprev.Enabled = true;
                    fetchlast.Enabled = false;
                    fetchnext.Enabled = false;
                }
                else
                {
                    fetchfirst.Enabled = true;
                    fetchprev.Enabled = true;
                    fetchlast.Enabled = true;
                    fetchnext.Enabled = true;
                }
            }
            
        }

        private void fetchlast_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == cust.ShowAll().Rows.Count - 1)
            {
                MessageBox.Show("لايوجد حقول لاحقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fetchlast.Enabled = false;
                fetchnext.Enabled = false;
                fetchfirst.Enabled = true;
                fetchprev.Enabled = true;
            }
            else
            {
                // the count will count with zero index
                position = cust.ShowAll().Rows.Count - 1;
                Navigate(position);
                labelposition.Text = (position + 1) + " / " + cust.ShowAll().Rows.Count;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[position].Cells[this.dataGridView1.CurrentCell.ColumnIndex];

                fetchfirst.Enabled = true;
                fetchprev.Enabled = true;
                fetchlast.Enabled = false;
                fetchnext.Enabled = false;
            }
           
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            firstname.Text = ""; lastname.Text = ""; phone.Text = ""; address.Text = "";
            updatebrn.Enabled = false;
            deletebtn.Enabled = false;
            newbtn.Enabled = false;
            addbtn.Enabled = true;
            firstname.ReadOnly = false;
            lastname.ReadOnly = false;
            phone.ReadOnly = false;
            address.ReadOnly = false;
            DebtText.ReadOnly = false;
            fetchfirst.Enabled = false;
            fetchprev.Enabled = false;
            fetchlast.Enabled = false;
            fetchnext.Enabled = false;
            dataGridView1.Enabled = false;
            DebtText.Text = "0"; 
            firstname.Focus();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
           
            if(firstname.Text!="" || lastname.Text!="" || phone.Text !="" || address.Text!="" || DebtText.Text != "")
            {
                try
                {
                    cust.Add_Customer(firstname.Text, lastname.Text, phone.Text, address.Text,Convert.ToDouble(DebtText.Text));
                    MessageBox.Show("تمت العملية بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fetchfirst.Enabled = true;
                    fetchprev.Enabled = true;
                    fetchlast.Enabled = true;
                    fetchnext.Enabled = true;
                    dataGridView1.Enabled = true;
                    this.dataGridView1.DataSource = cust.ShowAll();
                }
                catch
                {
                    return;
                }
               

            }
            else
            {
                MessageBox.Show("لم تتم الإضافة ! الحقول فارغة", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            updatebrn.Enabled = true;
            deletebtn.Enabled = true;
            newbtn.Enabled = true;
            addbtn.Enabled = false;
            firstname.ReadOnly = true;
            lastname.ReadOnly = true;
            phone.ReadOnly = true;
            address.ReadOnly = true;
            DebtText.ReadOnly = true;
            dataGridView1.Focus();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل أنت متأكد من الحذف", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (firstname.Text != "" || lastname.Text != "" || phone.Text != "" || address.Text != "" || DebtText.Text != "")
                {
                    try
                    {
                        cust.DeleteCustomer(id);
                        MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dataGridView1.DataSource = cust.ShowAll();
                        firstname.Text = ""; lastname.Text = ""; phone.Text = ""; address.Text = "";

                    }
                    catch
                    {
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("خطأ! لايوجد بيانات لحذفها", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void updatebrn_Click(object sender, EventArgs e)
        {
            if (firstname.Text != "" || lastname.Text != "" || phone.Text != "" || address.Text != "" || DebtText.Text != "")
            {
                try
                {
                    deletebtn.Enabled = false;
                    newbtn.Enabled = false;
                    addbtn.Enabled = false;
                    updatebrn.Enabled = false;
                    firstname.ReadOnly = false;
                    lastname.ReadOnly = false;
                    phone.ReadOnly = false;
                    address.ReadOnly = false;
                    DebtText.ReadOnly = false;
                    SaveEdit.Enabled = true;
                    firstname.Focus();

                }
                catch
                {
                    return;
                }


            }
            else
            {
                MessageBox.Show("!الحقول فارغة", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
          

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.firstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.lastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.address.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.DebtText.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            int i = dataGridView1.CurrentRow.Index;
                labelposition.Text = (i + 1) + " / " + cust.ShowAll().Rows.Count;
            if (i == 0)
            {
                fetchfirst.Enabled = false;
                fetchprev.Enabled = false;
            } else if (i == cust.ShowAll().Rows.Count-1)
            {
                fetchlast.Enabled = false;
                fetchnext.Enabled = false;
                fetchfirst.Enabled = true;
                fetchprev.Enabled = true;
            }
            //this else for making the default false buttons TRUE
            else
            {
                fetchfirst.Enabled = true;
                fetchprev.Enabled = true;
                fetchlast.Enabled = true;
                fetchnext.Enabled = true;
            }
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            if (firstname.Text != "" || lastname.Text != "" || phone.Text != "" || address.Text != "")
            {
                try
                {
                    cust.update_Customer(firstname.Text, lastname.Text, phone.Text, address.Text,Convert.ToDouble(DebtText.Text),id);
                    MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.ShowAll();
                }
                catch
                {
                    return;
                }


            }
            else
            {
                MessageBox.Show("لم يتم التعديل ! الحقول فارغة", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            deletebtn.Enabled = true;
            newbtn.Enabled = true;
            addbtn.Enabled = true;
            updatebrn.Enabled = true;
            firstname.ReadOnly = true;
            lastname.ReadOnly = true;
            phone.ReadOnly = true;
            address.ReadOnly = true;
            DebtText.ReadOnly = true;
            SaveEdit.Enabled = false;
        }

        private void searchText_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue== (char)Keys.Enter)
            {
                DataTable dt = new DataTable();
                dt = cust.SearchCust(searchText.Text);
                this.dataGridView1.DataSource = dt;
            }
           
        }

        private void Searchbrn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cust.SearchCust(searchText.Text);
            this.dataGridView1.DataSource = dt;
        }

       

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DebtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void عرضفواتيرهذاالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FormOrdersList ordfrm = new FormOrdersList();
            ordfrm.textSearch.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString() + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ordfrm.ShowDialog();
        }

        private void Navigate(int index)
        {
            try
            {
                DataTable dt = cust.ShowAll();
                // thsi is for getting the row[index] with the column number 
                //  column no.0 is the id !! We don't want to shoe it
                id = Convert.ToInt32(dt.Rows[index][0].ToString());
                firstname.Text = dt.Rows[index][1].ToString();
                lastname.Text = dt.Rows[index][2].ToString();
                phone.Text = dt.Rows[index][3].ToString();
                address.Text = dt.Rows[index][4].ToString();
                DebtText.Text = dt.Rows[index][5].ToString();
            }
            catch
            {
                return;
            }
           

        }
    }
}
