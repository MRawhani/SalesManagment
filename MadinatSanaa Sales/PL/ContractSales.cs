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
    public partial class ContractSales : Form
    {
        BL.AddContract con = new BL.AddContract();
        DataTable dt = new DataTable();
        DataTable dtOfUpdate;
        public string ConState = "add";
        public Boolean closed = false;
        public double PricePrev;
        int updateQty;
        public ContractSales()
        {
            InitializeComponent();
            CreateDatatabel();
            ReSizeDGV();
            this.Con_user.Text = Program.SalesMan;
            if (ConState == "edit")
            {
                Total.Text = "";
                paid.Text = Convert.ToString(Convert.ToDouble(Total.Text) - Convert.ToDouble(debit.Text));
            }
           // Intial();
        }
        /// <summary>
        /// ///// Get Data Table Of Updates
        /// </summary>
        public void SetDatatableForUpdate(DataTable dtU)
        {
            dtOfUpdate = dtU;
        }
        void Intial()
        {
            ClearBoxes();
            disCount.Text = "0";
            qty.Text = "1";
            CAlculatepriceAfterQ();
            CAlculateTtotal();
        }
        void CreateDatatabel()
        {

            dt.Columns.Add("معرف البضاعة");
            dt.Columns.Add("اسم البضاعة");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("الخصم");
            dt.Columns.Add("الإجمالي");
            this.dataGridView1.DataSource = dt;
        }
        void ReSizeDGV()
        {
            this.dataGridView1.RowHeadersWidth = 64;
            this.dataGridView1.Columns[0].Width = 75;
            this.dataGridView1.Columns[1].Width = 176;
            this.dataGridView1.Columns[2].Width = 89;
            this.dataGridView1.Columns[3].Width = 66;
            this.dataGridView1.Columns[4].Width = 80;
            this.dataGridView1.Columns[5].Width = 84;
            this.dataGridView1.Columns[6].Width = 95;


        }
        void ClearBoxes()
        {
            id.Clear();
            label.Clear();
            price.Clear();
            qty.Clear();
            priceafterQ.Clear();
            disCount.Clear();
            TotalPrice.Clear();
            choosebtn.Focus();

        }
        void ClearData()
        {
            ConID.Clear();
            ConNote.Clear();
           // Con_user.Clear();
            Con_date.ResetText();
            custId.Clear();
            custLastName.Clear();
            custfirstNAme.Clear();
            custPhone.Clear();
            custAddress.Clear();
            ClearBoxes();
            dt.Clear();
            dataGridView1.DataSource = null;
            //Total.Text="0";

            if(ConState == "add")
            {
                newSale.Enabled = true;
                Print.Enabled = true;
            }
          
            SaveSale.Enabled = false;
           


        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        void CAlculatepriceAfterQ()
        {
            try
            {
                if (price.Text != string.Empty && qty.Text != string.Empty)
                {
                    priceafterQ.Text = (Convert.ToDouble(price.Text) * Convert.ToInt32(qty.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("أدخل الارقام بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        void CAlculateTtotal()
        {
            try
            {
                if (priceafterQ.Text != string.Empty && disCount.Text != string.Empty)
                {
                    TotalPrice.Text = (Convert.ToDouble(priceafterQ.Text) - Convert.ToDouble(disCount.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("أدخل الارقام بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void newSale_Click(object sender, EventArgs e)
        {
            // focus!!!! here we want the first colomn, so we put [0]

            ConID.Text = con.GetConId().Rows[0][0].ToString();
            ConNote.Focus();
            SaveSale.Enabled = true;
            // choosebtn.Enabled = true;
            newSale.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (SaveSale.Enabled)
            {
                if (MessageBox.Show(
              "هناك بعض العمليات لم تكتمل ! هل أنت متأكد من الاغلاق؟", "عملية الاغلاق", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                    closed = true;
                }
                else
                {
                    SaveSale.Focus();
                }



            }
            else
            {
                this.Close();
                closed = true;
            }

        }

        private void CustChoosBtn_Click(object sender, EventArgs e)
        {
            PL.CustomersList cu = new CustomersList();
            cu.ShowDialog();
            // first show the dialoge and doubleClick(Event was set in the list form)
            // then the form will close and here we fech data
            // the closing is just for the user
            this.custId.Text = cu.ListGridVeiw.CurrentRow.Cells[0].Value.ToString();
            this.custfirstNAme.Text = cu.ListGridVeiw.CurrentRow.Cells[1].Value.ToString();
            this.custLastName.Text = cu.ListGridVeiw.CurrentRow.Cells[2].Value.ToString();
            this.custPhone.Text = cu.ListGridVeiw.CurrentRow.Cells[3].Value.ToString();
            this.custAddress.Text = cu.ListGridVeiw.CurrentRow.Cells[4].Value.ToString();

        }

        private void choosebtn_Click(object sender, EventArgs e)
        {
            if (id.Text != string.Empty)
            {
                if(MessageBox.Show("هناك مسبقا عناصر يتم تعديلها أو اضافتها! هل تريد المواصلة على أي حال ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    PL.ClothesList clo = new ClothesList();
                    Intial();
                    clo.ShowDialog();
                    this.id.Text = clo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.label.Text = clo.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                   // this.price.Text = clo.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    //  this.qty.Text = clo.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    
                    CAlculatepriceAfterQ();
                    CAlculateTtotal();
                    this.price.Focus();
                }
                else
                {
                    return;
                }
            }
            else
            {
                PL.ClothesList clo = new ClothesList();
                Intial();
                clo.ShowDialog();
                this.id.Text = clo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.label.Text = clo.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //this.price.Text = clo.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //  this.qty.Text = clo.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.price.Focus();
                CAlculatepriceAfterQ();
                CAlculateTtotal();
            }
            




        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && price.Text != string.Empty)
            {
                qty.Focus();
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && qty.Text != "")
            {
                disCount.Focus();
            }
        }

        private void price_KeyUp(object sender, KeyEventArgs e)
        {
            CAlculatepriceAfterQ();
            CAlculateTtotal();
        }

        private void qty_KeyUp(object sender, KeyEventArgs e)
        {
            CAlculatepriceAfterQ();
            CAlculateTtotal();
        }

        private void disCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void disCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && disCount.Text != string.Empty && price.Text != string.Empty && qty.Text != string.Empty && label.Text != string.Empty && id.Text != string.Empty)
            {
                
                if(ConState == "add")
                {
                    if (con.VerifyQty(id.Text, Convert.ToInt32(qty.Text)).Rows.Count < 1)
                    {
                        MessageBox.Show("الكمية المدخلة غير متاحة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        qty.Focus();
                        return;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id.Text)
                        {
                            MessageBox.Show("هذه البضاعة موجوده مسبقاً", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            choosebtn.Focus();
                            return;

                        }

                    }
                    DataRow r = dt.NewRow();
                    // the indexes are indexes of columns
                    r[0] = id.Text;
                    r[1] = label.Text;
                    r[2] = price.Text;
                    r[3] = qty.Text;
                    r[4] = priceafterQ.Text;
                    r[5] = disCount.Text;
                    r[6] = TotalPrice.Text;
                    dt.Rows.Add(r); // adding the whole row with columns we inserted
                                    // updating the dGV to show the user
                    this.dataGridView1.DataSource = dt;

                    ClearBoxes();
                    //this a LINq way to calculate the sum
                    // i know nothing abt it .... from net V.50 SAdani
                    GetSum();
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id.Text)
                        {
                            MessageBox.Show("هذه البضاعة موجوده مسبقاً", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            choosebtn.Focus();
                            return;

                        }

                    }
                    DataRow r = dtOfUpdate.NewRow();
                    // the indexes are indexes of columns
                    r[0] = id.Text;
                    r[1] = label.Text;
                    r[2] = price.Text;
                    r[3] = qty.Text;
                    r[4] = priceafterQ.Text;
                    r[5] = disCount.Text;
                    r[6] = TotalPrice.Text;
                    dtOfUpdate.Rows.Add(r); // adding the whole row with columns we inserted
                                    // updating the dGV to show the user
                    this.dataGridView1.DataSource = dtOfUpdate;

                    ClearBoxes();
                    //this a LINq way to calculate the sum
                    // i know nothing abt it .... from net V.50 SAdani
                   GetSum();
                }
                
            }
        }

        private void disCount_KeyUp(object sender, KeyEventArgs e)
        {
            CAlculateTtotal();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(id.Text == string.Empty) {
                try
                {
                    this.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.label.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    this.price.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    this.qty.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    updateQty = Convert.ToInt32(qty.Text);
                    this.priceafterQ.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    this.disCount.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    this.TotalPrice.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
                    qty.Focus();
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("هناك مسبقا عناصر يتم تعديلها أو اضافتها!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                qty.Focus();
            }
           
           
        }
        void GetSum()
        {
            if (dataGridView1.Rows.Count > 1)
            {
                Total.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[6].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
          

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            GetSum();

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // same event as thedouble click
            dataGridView1_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dataGridView1.Refresh();
            }
            catch
            {
                return;
            }
          
        }

        private void SaveSale_Click(object sender, EventArgs e)
        {
           
            if (ConID.Text == string.Empty  )
            {
                MessageBox.Show(" رقم الفاتورة غير موجود  ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newSale.Focus();
                return;
            }
            if (ConNote.Text == string.Empty)
            {
                MessageBox.Show(" ادخل وصف للفاتورة  ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConNote.Focus();
                return;
            }

            if (custId.Text == string.Empty)
            {
                MessageBox.Show(" رقم الزبون غير موجود  ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CustChoosBtn.Focus();
                return;
            }
            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show(" لايوجد بيانات مدخلة لبيعها  ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                choosebtn.Focus();
                return;
            }
            if (Total.Text == string.Empty || Total.Text=="0")
            {
                MessageBox.Show(" تحقق من البيانات! لايوجد مجموع!  ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                choosebtn.Focus();
                return;
            }

            if (Convert.ToDouble(Total.Text) < 0)
            {
                MessageBox.Show("لايمكن أن يكون المجموع سالباً   ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                choosebtn.Focus();
                return;
            }
            if (Convert.ToDouble(paid.Text) > Convert.ToDouble(Total.Text))
            {
                MessageBox.Show("لايمكن ان يكون النقد أكبر من المجموع  ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                paid.Focus();
                paid.SelectionStart = 0;
                paid.SelectionLength = paid.Text.Length;
            }
            if (Convert.ToDouble(debit.Text) > Convert.ToDouble(Total.Text))
            {
                MessageBox.Show("لايمكن ان يكون الآجل أكبر من المجموع  ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                paid.Focus();
                paid.SelectionStart = 0;
                paid.SelectionLength = paid.Text.Length;
            }

            /////////// add Contract
            if (ConState == "add")
            {
                if (MessageBox.Show("? هل تريد الحفظ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (id.Text == string.Empty && label.Text == string.Empty)
                    {
                        try
                        {
                            // VAlue gives a type Date
                            //aDD_oRDER
                            con.Add_Order(Convert.ToInt32(ConID.Text), ConNote.Text,
                                Con_date.Value, Con_user.Text, Convert.ToInt32(custId.Text), Convert.ToDouble(Total.Text), Convert.ToDouble(debit.Text));
                            // ADD ORDER dETAILS
                            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
                            {
                                con.OrderDetails(this.dataGridView1.Rows[i].Cells[0].Value.ToString()
                                    , Convert.ToInt32(ConID.Text), Convert.ToInt32(this.dataGridView1.Rows[i].Cells[3].Value.ToString()), this.dataGridView1.Rows[i].Cells[2].Value.ToString()
                                    , Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString()), this.dataGridView1.Rows[i].Cells[4].Value.ToString()
                                    , this.dataGridView1.Rows[i].Cells[6].Value.ToString());
                                /// Add To Log
                                con.OrderDetailsLog(Con_date.Value, Convert.ToInt32(ConID.Text), this.dataGridView1.Rows[i].Cells[0].Value.ToString()
                                    , Convert.ToInt32(this.dataGridView1.Rows[i].Cells[3].Value.ToString()), this.dataGridView1.Rows[i].Cells[2].Value.ToString()
                                    , Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString()), this.dataGridView1.Rows[i].Cells[4].Value.ToString()
                                    , this.dataGridView1.Rows[i].Cells[6].Value.ToString(), "الأصل");


                            }
                            /// Add Profits To Profit
                         
                            BL.ProfitsClass pro = new BL.ProfitsClass();
                            int profId = Convert.ToInt32(pro.GetLastProfitsId().Rows[0][0].ToString());
                            pro.AddProfit(profId, this.Con_date.Value,Convert.ToDouble(paid.Text), Convert.ToInt32(custId.Text), Convert.ToInt32(ConID.Text), ConNote.Text);
                          
                                //add DEbit
                                BL.DebitsClass deb = new BL.DebitsClass();
                                int debId = Convert.ToInt32(deb.GetLastDebitId().Rows[0][0].ToString());
                                deb.AddDebit(debId, this.Con_date.Value, Convert.ToDouble(debit.Text), Convert.ToInt32(custId.Text), Convert.ToInt32(ConID.Text), ConNote.Text);

                            

                            MessageBox.Show("تمت العملية بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearData();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString() + " أخفقت العملية ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" عذراُ لايمكنك الحفظ .. هناك بيانات لم يتم حفظها ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                } else
                {
                    return;
                }


              

            }
            //// update
            else
            {
                if (MessageBox.Show("? هل تريد التعديل", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        if (id.Text == string.Empty && label.Text == string.Empty)
                        {

                            // VAlue gives a type Date
                            //update_oRDER
                            con.Update_Order(Convert.ToInt32(ConID.Text), Con_date.Value, ConNote.Text,
                               Convert.ToInt32(custId.Text), Convert.ToDouble(Total.Text), Convert.ToDouble(debit.Text));
                            // update ORDER dETAILS

                            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
                            {
                                int QtyAfterUpdates = updateQty - Convert.ToInt32(this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                                con.UpdateOrderDetails(this.dataGridView1.Rows[i].Cells[0].Value.ToString()
                                    , Convert.ToInt32(ConID.Text), Convert.ToInt32(this.dataGridView1.Rows[i].Cells[3].Value.ToString()), this.dataGridView1.Rows[i].Cells[2].Value.ToString()
                                    , Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString()), this.dataGridView1.Rows[i].Cells[4].Value.ToString()
                                    , this.dataGridView1.Rows[i].Cells[6].Value.ToString(), QtyAfterUpdates);
                                /// Add To Log
                                con.OrderDetailsLog(DateTime.Now, Convert.ToInt32(ConID.Text), this.dataGridView1.Rows[i].Cells[0].Value.ToString()
                                    , Convert.ToInt32(this.dataGridView1.Rows[i].Cells[3].Value.ToString()), this.dataGridView1.Rows[i].Cells[2].Value.ToString()
                                    , Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString()), this.dataGridView1.Rows[i].Cells[4].Value.ToString()
                                    , this.dataGridView1.Rows[i].Cells[6].Value.ToString(), "معدل");


                            }

                            /// update Profits To Profit

                            BL.ProfitsClass pro = new BL.ProfitsClass();
                          //  double PrevPrice = Convert.ToDouble(pro.GetProfitPeforeUpdating(Convert.ToInt32(ConID.Text)).Rows[0][0].ToString());
                            pro.UpdateProfit(this.Con_date.Value, Convert.ToDouble(paid.Text),  Convert.ToInt32(ConID.Text), ConNote.Text);
                          
                                //update DEbit
                                BL.DebitsClass deb = new BL.DebitsClass();
                                int debId = Convert.ToInt32(deb.GetLastDebitId().Rows[0][0].ToString());
                                deb.UpdateDepit( this.Con_date.Value, Convert.ToDouble(debit.Text), Convert.ToInt32(custId.Text), Convert.ToInt32(ConID.Text), ConNote.Text, PricePrev);

                            

                            MessageBox.Show("تمت العملية بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearData();




                        }
                        else
                        {
                            MessageBox.Show(" عذراُ لايمكنك الحفظ .. هناك بيانات لم يتم حفظها ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + " أخفقت العملية ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }

           
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // newSale.Enabled = true;
            int id = Convert.ToInt32(con.GetLastorderIdForPrint().Rows[0][0].ToString());
            Reports.ContractReport report = new Reports.ContractReport();
            Reports.ClothesReport frm = new Reports.ClothesReport();
            report.SetDataSource(con.GetOrderDetails(id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }

        private void qty_Validating(object sender, CancelEventArgs e)
        {
            if (ConState == "edit")
            {
                if (Convert.ToInt32(qty.Text) > updateQty)
                {
                    MessageBox.Show(" الكمية المدخلة أكبر من المحددة! إذا اردت اضافة كمية لهذا العميل! أضف فاتورة جديدة ! أو قم بتقليل الكمية ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    qty.Focus();
                    qty.SelectionStart = 0;
                    qty.SelectionLength = qty.Text.Length;
                }
                if (qty.Text==null)
                {
                    qty.Text = "0";
                    qty.Focus();
                    qty.SelectionStart = 0;
                    qty.SelectionLength = qty.Text.Length;
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {
            if (Total.Text != string.Empty)
            {
                paid.Text = Total.Text;

            }
            else
            {
                paid.Text = "0";


            }
        }

        private void disCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void debit_TextChanged(object sender, EventArgs e)
        {
        }

        private void paid_TextChanged(object sender, EventArgs e)
        {
            if (paid.Text != string.Empty)
            {
                debit.Text = Convert.ToString(Convert.ToDouble(Total.Text) - Convert.ToDouble(paid.Text));

            }
            else
            {
                debit.Text = "0";


            }

        }

        private void paid_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void paid_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void paid_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDouble(paid.Text) > Convert.ToDouble(Total.Text))
            {
                MessageBox.Show("لايمكن ان يكون النق أكبر من المجموع  ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                paid.Focus();
                paid.SelectionStart = 0;
                paid.SelectionLength = paid.Text.Length;
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
