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
    public partial class GetMoney : Form
    {
        string status="";
        double prevPrice;
        BL.ProfitsClass pro = new BL.ProfitsClass();
        int position;

        public GetMoney()
        {
            InitializeComponent();
           // dt = pro.ShowAllGetMoney();
            position = pro.ShowAllGetMoney().Rows.Count - 1;
            Navigate(position);
           /* id.Text = dt.Rows[position][0].ToString();
            date.Value= Convert.ToDateTime(dt.Rows[position][1].ToString());
            Cus_id.Text= dt.Rows[position][2].ToString();
            ClientName.Text = dt.Rows[position][3].ToString();
            priceText.Text= dt.Rows[position][4].ToString();
            order_id.Text = dt.Rows[position][5].ToString();
            NoteText.Text= dt.Rows[position][6].ToString();
            labelPosition.Text = (position+1) + " / " + pro.ShowAllGetMoney().Rows.Count;*/
            lastFetch.Enabled = false;
            nextFetch.Enabled = false;
        }
        void Navigate(int position)
        {
            try
            {


                if (position >= 0)
                {
                    DataTable dt = new DataTable();
                    dt = pro.ShowAllGetMoney();
                    id.Text = dt.Rows[position][0].ToString();
                    date.Value = Convert.ToDateTime(dt.Rows[position][1].ToString());
                    Cus_id.Text = dt.Rows[position][2].ToString();
                    ClientName.Text = dt.Rows[position][3].ToString();
                    priceText.Text = dt.Rows[position][4].ToString();
                    order_id.Text = dt.Rows[position][5].ToString();
                    NoteText.Text = dt.Rows[position][6].ToString();
                    labelPosition.Text = (position + 1) + " / " + pro.ShowAllGetMoney().Rows.Count;
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
           
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            newbtn.Enabled = false;
            edit.Enabled = false;
            delete.Enabled = false;
            choosCust.Enabled = true;
            chooseOrder.Enabled = true;
            priceText.Enabled = true;
            date.Enabled = true;
            NoteText.Enabled = true;
            save.Enabled = true;
            status = "add";
            int ids = Convert.ToInt32(pro.GetMoneyLastId().Rows[0][0].ToString());
           
            Cus_id.Clear();
            priceText.Clear();
            order_id.Clear();
            ClientName.Clear();
            NoteText.Clear();
            date.Value = DateTime.Now;
            id.Text = ids.ToString();
            id.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newbtn.Enabled = false;
            edit.Enabled = false;
            delete.Enabled = false;
            choosCust.Enabled = false;
            chooseOrder.Enabled = false;
            priceText.Enabled = true;
            date.Enabled = true;
            NoteText.Enabled = true;
            save.Enabled = true;
            status = "edit";

            prevPrice = Convert.ToDouble(priceText.Text);
            NoteText.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (status == "add")
            {
                if (Cus_id.Text != "" && priceText.Text != string.Empty)
                {
                    try
                    {

                        if (order_id.Text != string.Empty)
                        {
                            //add the bill
                            pro.AddMoney(Convert.ToInt32(id.Text), date.Value, Convert.ToInt32(Cus_id.Text)
                                , Convert.ToDouble(priceText.Text), Convert.ToInt32(order_id.Text), NoteText.Text);

                        }
                        else
                        {
                            //add the bill
                            pro.AddMoneyWithoutorder(Convert.ToInt32(id.Text), date.Value, Convert.ToInt32(Cus_id.Text)
                                , Convert.ToDouble(priceText.Text), NoteText.Text);

                        }
                        MessageBox.Show(
                                "تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        save.Enabled = false;
                        newbtn.Enabled = true;

                        edit.Enabled = true;
                        delete.Enabled = true;
                        chooseOrder.Enabled = false;
                        choosCust.Enabled = false;
                        priceText.Enabled = false;
                        date.Enabled = false;
                        NoteText.Enabled = false;
                        position = pro.ShowAllGetMoney().Rows.Count - 1;
                        Navigate(position);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                                       ex.ToString(), "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    MessageBox.Show(
                            "بعض الحقول ماتزال فارغة!لن تتم الإضافة",
                            "عملية الإضافة", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    priceText.Focus();
                }

            }
            else if(status=="edit")
            {
                if (Cus_id.Text != "" && priceText.Text != string.Empty)
                {
                    try
                    {
                            //add the bill
                            pro.UpdateMoney(Convert.ToInt32(id.Text), date.Value,
                                Convert.ToDouble(priceText.Text),  NoteText.Text,prevPrice, Convert.ToInt32(Cus_id.Text));

                        
                   
                        MessageBox.Show(
                                "تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        save.Enabled = false;
                        newbtn.Enabled = true;

                        edit.Enabled = true;
                        delete.Enabled = true;
                        chooseOrder.Enabled = false;
                        choosCust.Enabled = false;
                        priceText.Enabled = false;
                        date.Enabled = false;
                        NoteText.Enabled = false;
                       // position = pro.ShowAllGetMoney().Rows.Count - 1;
                      //  Navigate(position);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                                       ex.ToString(), "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    MessageBox.Show(
                            "بعض الحقول ماتزال فارغة!لن يتم التعديل",
                            "عملية التعديل", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    priceText.Focus();
                }
            }



        }

        private void choosCust_Click(object sender, EventArgs e)
        {
            PL.CustomersList cu = new CustomersList();
            cu.ShowDialog();
            // first show the dialoge and doubleClick(Event was set in the list form)
            // then the form will close and here we fech data
            // the closing is just for the user
            this.Cus_id.Text = cu.ListGridVeiw.CurrentRow.Cells[0].Value.ToString();
            this.ClientName.Text = cu.ListGridVeiw.CurrentRow.Cells[1].Value.ToString()+" "+cu.ListGridVeiw.CurrentRow.Cells[2].Value.ToString();
           // this.debtText.Text = cu.ListGridVeiw.CurrentRow.Cells[5].Value.ToString();
        }

        private void Cus_id_TextChanged(object sender, EventArgs e)
        {
         // Cus_id.AutoCompleteCustomSource=dt;
        }

        private void priceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void prevFetch_Click(object sender, EventArgs e)
        {
            if (save.Enabled)
            {
                MessageBox.Show("مازالت هناك عمليات قيد الحفظ!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            position -= 1;
            if (position<0)
            {
                MessageBox.Show("لايوجد حقول سابقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstFetch.Enabled = false;
                prevFetch.Enabled = false;
                lastFetch.Enabled = true;
                nextFetch.Enabled = true;
            }
            else
            {
               
                Navigate(position);
               
                if (position == 0)
                {
                    firstFetch.Enabled = false;
                    prevFetch.Enabled = false;
                    lastFetch.Enabled = true;
                    nextFetch.Enabled = true;
                }
                else
                {
                    firstFetch.Enabled = true;
                    prevFetch.Enabled = true;
                    lastFetch.Enabled = true;
                    nextFetch.Enabled = true;
                }
            }
        }

        private void firstFetch_Click(object sender, EventArgs e)
        {
            if (save.Enabled)
            {
                MessageBox.Show("مازالت هناك عمليات قيد الحفظ!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            position =0;
            if (position < 0)
            {
                MessageBox.Show("لايوجد حقول سابقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstFetch.Enabled = false;
                prevFetch.Enabled = false;
                lastFetch.Enabled = true;
                nextFetch.Enabled = true;
            }
            else
            {

                Navigate(position);

                    firstFetch.Enabled = false;
                    prevFetch.Enabled = false;
                    lastFetch.Enabled = true;
                    nextFetch.Enabled = true;
              
                  
                
            }
        }

        private void nextFetch_Click(object sender, EventArgs e)
        {
            if (save.Enabled)
            {
                MessageBox.Show("مازالت هناك عمليات قيد الحفظ!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            position += 1;
            if (position>pro.ShowAllGetMoney().Rows.Count-1)
            {
                MessageBox.Show("لايوجد حقول لاحقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastFetch.Enabled = false;
                nextFetch.Enabled = false;
                firstFetch.Enabled = true;
                prevFetch.Enabled = true;
            }
            else
            {
                
                Navigate(position);
              
                if (position == pro.ShowAllGetMoney().Rows.Count-1)
                {
                    lastFetch.Enabled = false;
                    nextFetch.Enabled = false;
                    firstFetch.Enabled = true;
                    prevFetch.Enabled = true;
                }
                else
                {
                    lastFetch.Enabled = true;
                    nextFetch.Enabled = true;
                    firstFetch.Enabled = true;
                    prevFetch.Enabled = true;
                }
            }
        }

        private void lastFetch_Click(object sender, EventArgs e)
        {
            if (save.Enabled)
            {
                MessageBox.Show("مازالت هناك عمليات قيد الحفظ!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            position = pro.ShowAllGetMoney().Rows.Count-1;
            if (position > pro.ShowAllGetMoney().Rows.Count - 1)
            {
                MessageBox.Show("لايوجد حقول لاحقة!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstFetch.Enabled = true;
                prevFetch.Enabled = true;
                lastFetch.Enabled = false;
                nextFetch.Enabled = false;
            }
            else
            {

                Navigate(position);

                firstFetch.Enabled = true;
                prevFetch.Enabled = true;
                lastFetch.Enabled = false;
                nextFetch.Enabled = false;




            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (save.Enabled)
            {
                if (MessageBox.Show(
              "هناك بعض العمليات لم تكتمل ! هل أنت متأكد من الاغلاق؟", "عملية الاغلاق", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    save.Focus();
                }



            }
            else
            {
                this.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (id.Text != string.Empty  && Cus_id.Text != string.Empty && priceText.Text != string.Empty )
                {
                    try
                    {
                        pro.DeleteMoney(Convert.ToInt32(id.Text), Convert.ToInt32(Cus_id.Text), Convert.ToDouble(priceText.Text));
                        MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cus_id.Clear();
                        id.Clear();
                        priceText.Clear();
                        order_id.Clear();
                        ClientName.Clear();
                        NoteText.Clear();
                        date.Value = DateTime.Now;
                        position = pro.ShowAllGetMoney().Rows.Count - 1;
                        Navigate(position);
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

        private void priceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceText_Validating(object sender, CancelEventArgs e)
        {
          /*  if (status == "edit")
            {
                if (Convert.ToDouble(priceText.Text) > prevPrice)
                {
                    MessageBox.Show(" الكمية المدخلة أكبر من المحددة! إذا اردت اضافة كمية لهذا العميل! أضف فاتورة جديدة ! أو قم بتقليل الكمية ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    priceText.Focus();
                    priceText.SelectionStart = 0;
                    priceText.SelectionLength = priceText.Text.Length;
                }*/
        }
    }
}
