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
    public partial class Form_Categories : Form
    {
        // this time we are going to do the operations here directly
        SqlConnection con = new SqlConnection(@"server= .\SQLEXPRESS; Database= MadinatSales_d; Integrated Security=false; User ID=sa; Password=moh123456");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        // this is for dealing with next and prev buttons
        // this gives you the control as you had in oracle
        BindingManagerBase bmb;
        // this is for updating commands
        SqlCommandBuilder comdb;
        public Form_Categories()
        {
            InitializeComponent();
            // we write the command instead of using sqlcommand
            da = new SqlDataAdapter("select iD_cat as 'معرف الصنف',description_cat as 'وصف الصنف' from Category", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            id_cat.DataBindings.Add("text", dt, "معرف الصنف");
            desk_cat.DataBindings.Add("text", dt, "وصف الصنف");
            bmb= this.BindingContext[dt];
            // setting the position to the label
            labelPosition.Text = (bmb.Position+1) + " / " + bmb.Count;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(!printAll.Enabled )
            {
                if (MessageBox.Show(
              "هناك بعض العمليات لم تكتمل ! هل أنت متأكد من الاغلاق؟", "عملية الاغلاق", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    desk_cat.Focus();
                }
                
               
                   
            }
            else
            {
                this.Close();
            }
          
        }

        private void fetchFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            labelPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            fetchFirst.Enabled = false;
            fetchprev.Enabled = false;
            fetchlast.Enabled = true;
            fetchnext.Enabled = true;
        }

        private void fetchlast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            labelPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            fetchFirst.Enabled = true;
            fetchprev.Enabled = true;
            fetchlast.Enabled = false;
            fetchnext.Enabled = false;
        }

        private void fetchprev_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            labelPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            if (bmb.Position == 0)
            {
                fetchFirst.Enabled = false;
                fetchprev.Enabled = false;
                fetchlast.Enabled = true;
                fetchnext.Enabled = true;
            }
            else
            {
                fetchFirst.Enabled = true;
                fetchprev.Enabled = true;
                fetchlast.Enabled = true;
                fetchnext.Enabled = true;
            }
        }

        private void fetchnext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            labelPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            if (bmb.Position == (bmb.Count-1))
            {
                fetchFirst.Enabled = true;
                fetchprev.Enabled = true;
                fetchlast.Enabled = false;
                fetchnext.Enabled = false;
            }
            else
            {
                fetchFirst.Enabled = true;
                fetchprev.Enabled = true;
                fetchlast.Enabled = true;
                fetchnext.Enabled = true;
            }
        }

        private void newCat_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            newCat.Enabled = false;
            updateCat.Enabled = false;
            deleteCAt.Enabled = false;
            printOne.Enabled = false;
            printAll.Enabled = false;
            addCat.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            id_cat.Text = id.ToString();
            desk_cat.Focus();
        }

        // this doesn't have sql command because we added with the add new method
        // and we are just updating now; with the:
        //  bmb.EndCurrentEdit(); call
        private void addCat_Click(object sender, EventArgs e)
        {

            
            if (desk_cat.Text != "")
            {
                try
                {

                    bool isFound = false;
                    for(int i=0; i < this.dataGridView1.Rows.Count - 1; i++)
                    {
                        if (desk_cat.Text == this.dataGridView1.Rows[i].Cells[1].Value.ToString())
                        {
                            isFound = true;
                            break;
                        }
                    }
                    //checkfor not repeating the value
                    if (!isFound)
                    {
                        // ending any op running  now
                        bmb.EndCurrentEdit();
                        // we pas da cuz it is the one binded wiht the table categories
                        //if the comdb knows what server ot deal with
                        // then he will know the dt that ahve the data
                        comdb = new SqlCommandBuilder(da);
                        //updating dt
                        da.Update(dt);
                        MessageBox.Show(
                            "تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addCat.Enabled = false;
                        newCat.Enabled = true;

                        updateCat.Enabled = true;
                        deleteCAt.Enabled = true;
                        printOne.Enabled = true;
                        printAll.Enabled = true;

                        labelPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
                    }
                    else
                    {
                        MessageBox.Show(
                        "لايمكنك إضافة صنفين بنفس الإسم", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        desk_cat.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                                   ex.ToString(), "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show(
                        "الحقل مايزال فارغاً!لن تتم الإضافة",
                        "عملية الإضافة", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                desk_cat.Focus();
            }


           

        }

        private void deleteCAt_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد الحذف؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {


                    // we use functions
                    bmb.RemoveAt(bmb.Position);
                    bmb.EndCurrentEdit();
                    comdb = new SqlCommandBuilder(da);
                    //updating dt
                    da.Update(dt);
                    MessageBox.Show(
                        "تمت الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                                   ex.ToString(), "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("تم الغاء الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            addCat.Enabled = false;
            newCat.Enabled = true;
            labelPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;


        }

        private void updateCat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من التعديل؟", "تعديل", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {

                
                // we use functions
               
                bmb.EndCurrentEdit();
                comdb = new SqlCommandBuilder(da);
                //updating dt
                da.Update(dt);
                MessageBox.Show(
                    "تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                                   ex.ToString(), "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                addCat.Enabled = false;
                newCat.Enabled = true;
                labelPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

            }
        }

        private void printAll_Click(object sender, EventArgs e)
        {
            Reports.ClothesReport report = new Reports.ClothesReport();
            Reports.AllCategories categories = new Reports.AllCategories();
            report.Refresh();
            report.crystalReportViewer1.ReportSource = categories;
            report.ShowDialog();
            report.Refresh();
        }

        private void printOne_Click(object sender, EventArgs e)
        {
            Reports.ClothesReport report = new Reports.ClothesReport();
            Reports.OneCat categories = new Reports.OneCat();
            categories.SetParameterValue("@id", Convert.ToInt32(id_cat.Text));
            report.crystalReportViewer1.ReportSource = categories;
            report.ShowDialog();
            report.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Categories_Load(object sender, EventArgs e)
        {

        }
    }
}
