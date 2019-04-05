using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MadinatSanaa_Sales.PL
{
    public partial class ClothAddNew : Form
    {
        public Boolean closed = false;
        BL.ClothAddClass clo = new BL.ClothAddClass();
        // this is for chechig if the opened dialoguw add or update
        public string state = "add";

       
        public ClothAddNew()
        {
            InitializeComponent();
            cmbCat.DataSource = clo.CategoriesFetch();
            cmbCat.DisplayMember = "description_cat";
            cmbCat.ValueMember = "ID_cat";
            Subcombo.DataSource = clo.SubbliersFetch();
            Subcombo.DisplayMember = "full name";
            Subcombo.ValueMember = "Sub_id";
            this.quantity.Text = "1";
          

        }

        private void ClothAddNew_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {

           
            byte[] byteimage = null;
           
                // first convert the image to binary input
                MemoryStream memoryStream = new MemoryStream();
                // we put the image in the stream created
                pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
               byteimage = memoryStream.ToArray();
           
                
            // now we pass the parameters to the add_cloth class
            // we put the compo as selected value cuz it is the primary 
            // we want to pas, nit the display member
            try
            {
                clo.Add_Cloth(Convert.ToInt32(cmbCat.SelectedValue), id.Text
               , desc.Text, Convert.ToInt32(quantity.Text), price.Text, Convert.ToInt32(Subcombo.SelectedValue),
               byteimage);

                MessageBox.Show("تمت الاضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()+"يرجى إدخال البيانات بشكل صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            else
            {

                byte[] byteimage = null;

                // first convert the image to binary input
                MemoryStream memoryStream = new MemoryStream();
                // we put the image in the stream created
                pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
                byteimage = memoryStream.ToArray();


                // now we pass the parameters to the add_cloth class
                // we put the compo as selected value cuz it is the primary 
                // we want to pas, nit the display member
                try
                {
                    clo.UpdateClothes(Convert.ToInt32(cmbCat.SelectedValue), id.Text
                   , desc.Text, Convert.ToInt32(quantity.Text), price.Text, Convert.ToInt32(Subcombo.SelectedValue),
                   byteimage);

                    MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch
                {
                    MessageBox.Show("يرجى إدخال البيانات بشكل صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            // this is for updatin the Datagrid even if the form is not lcosed
            ShowAllClothes.getShowAllClothes_Form().dataGridView1.DataSource = clo.ShowAll();
            ShowAllClothes.getShowAllClothes_Form().dataGridView1.Columns[6].Visible = false;

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            closed = true;
        }
        // this method for validating if the key is unique
        private void id_Validating(object sender, CancelEventArgs e)
        {
            if(state == "add")
            {
                DataTable dt = new DataTable();
                dt = clo.VertifyCloth(id.Text);
                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show("المعرف الذي أدخلته موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // reback the focus on the text
                    id.Focus();
                    id.SelectionStart = 0;
                    id.SelectionLength = id.TextLength;
                }
            }
           
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quantity_Validating(object sender, CancelEventArgs e)
        {
           /* try
            {
                int i = Convert.ToInt32(this.quantity.Text);
            }
            catch
            {
                MessageBox.Show("أدخل رقم صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // reback the focus on the text
                quantity.Focus();
                quantity.Text = "1";
                quantity.SelectionStart = 0;
                quantity.SelectionLength = quantity.TextLength;
            }*/
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
