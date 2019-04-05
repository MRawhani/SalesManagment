using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

using System.Data.SqlClient;
namespace MadinatSanaa_Sales.PL
{
    public partial class ShowAllClothes : Form
    {

        BL.ClothAddClass clo = new BL.ClothAddClass();
        public string SearchState = "default";
        public Boolean closed = false;
        // this variable is for entring the main form components from the login form
        // note that i have changed the modifiers of some of the main menu to public 
        static ShowAllClothes main;
        // this is for lcosing the static variable

        public static void main_closed(Object sender, FormClosedEventArgs e)
        {
            // we are making it nnull because we may deal with it in another for other rthanthe login  Form
            main = null;
        }
        // this mehtod is to use the current main or create a new one if it = null
        // this method for getting the intialized main in the constructor, better to get a variable using get method 
        public static ShowAllClothes getShowAllClothes_Form()
        {

            if (main == null)
            {
                main = new ShowAllClothes();
                main.FormClosed += new FormClosedEventHandler(main_closed);

            }
            return main;


        }

        public ShowAllClothes()
        {
            InitializeComponent();
            // this is for intializing the main to this
            if (main == null)
                main = this;
            this.dataGridView1.DataSource = clo.ShowAll();
            this.dataGridView1.Columns[6].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (SearchState =="default") {
                try
                {
                    DataTable dt = new DataTable();
                    dt = clo.SearchClothes(textSearch.Text);
                    this.dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("خطأ");
                }
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = clo.SearchClothesWithSubName(textSearch.Text);
                    this.dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("خطأ");
                }
            }
            
        }

        private void showAdd_Click(object sender, EventArgs e)
        {
            new ClothAddNew().ShowDialog();
            this.dataGridView1.DataSource = clo.ShowAll();
            this.dataGridView1.Columns[6].Visible = false;

        }

        private void Showdelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حذف السجل المحدد","عملية الحذف",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)== DialogResult.OK)
            {
                // i pass qty and price and sub_id to update the subliers credit
                clo.DeleteClothes(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(),Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value.ToString())
                   , this.dataGridView1.CurrentRow.Cells[3].Value.ToString(), Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[6].Value.ToString()));
                MessageBox.Show("تم الحذف","علملية الحذف",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.dataGridView1.DataSource = clo.ShowAll();
                this.dataGridView1.Columns[6].Visible = false;

            }
            else
            {
                MessageBox.Show("تم الغاء الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void showedit_Click(object sender, EventArgs e)
        {
            ClothAddNew addclo = new ClothAddNew();
            addclo.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            addclo.desc.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            addclo.quantity.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            addclo.price.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            addclo.cmbCat.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            addclo.Subcombo.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            addclo.Text = " :تحديث بيانات العنصر المحدد"+ this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            addclo.add_btn.Text = "تحديث";
            addclo.state = "edit";
            addclo.id.ReadOnly = true;
            
            byte[] img = (byte[])clo.Get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0]["Item_image"];
         //   MessageBox.Show(Convert.ToString(img));
            // Bitmap bitmap = (Bitmap)clo.Get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
           MemoryStream ms = new MemoryStream(img);        //bitmap.Save(ms,ImageFormat.Jpeg);
          //  ms.Write(img, 0, img.Length);
            // ms.Position = 0;
            //   System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            //  Image img2 = (Image)converter.ConvertFrom(img);
            addclo.pictureBox1.Image = Image.FromStream(ms);
            addclo.ShowDialog();
            if (addclo.closed)
            {
                this.dataGridView1.DataSource = clo.ShowAll();
                this.dataGridView1.Columns[6].Visible = false;
            }
            

        }

        private void showprintone_Click(object sender, EventArgs e)
        {
            Reports.OneClothRep re = new Reports.OneClothRep();
            re.SetParameterValue("@id", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Reports.ClothesReport myform = new Reports.ClothesReport();
            myform.crystalReportViewer1.ReportSource = re;
            myform.ShowDialog();
        }

        private void showPrintAll_Click(object sender, EventArgs e)
        {
            // Crystal reports may change but theForms stay one
            Reports.AllClothes myreport = new Reports.AllClothes();
            
            Reports.ClothesReport myform = new Reports.ClothesReport();
            myform.Refresh();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.Refresh();
            myform.ShowDialog();
        }

        private void showExit_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
            
        }
 
        private void showImage_Click(object sender, EventArgs e)
        {
            byte[] img = (byte[])clo.Get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0]["Item_image"];
            MemoryStream ms = new MemoryStream(img);        //bitmap.Save(ms,ImageFormat.Jpeg);
            PL.ShowPicture pic = new ShowPicture();
            pic.Text = "صورة البضاعة " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pic.pictureBox1.Image = Image.FromStream(ms);
            pic.ShowDialog();
            // SqlDataReader dr = clo.Get_images(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //  dr.Read();
            /* byte[] buteimg = clo.Get_images(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
             MemoryStream ms = new MemoryStream(buteimg);
             PL.Form1 f = new PL.Form1();
               f.pictureBox1.Image = Image.FromStream(ms);
            // f.Text = ms[2].ToString();
             f.ShowDialog();
            // dr.Close();
            */

        }

        private void showexportexcell_Click(object sender, EventArgs e)
        {
            PL.OrderDetailsForm ordfrm = new OrderDetailsForm();
            ordfrm.searchText.Text = (this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ordfrm.Text = " عرض عمليات الشراء للبضاعة ذا المعرف" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ordfrm.ShowDialog();
        }
    }
}
