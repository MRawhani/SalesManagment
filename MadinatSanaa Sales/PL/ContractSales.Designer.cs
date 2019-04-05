namespace MadinatSanaa_Sales.PL
{
    partial class ContractSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Con_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Con_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustChoosBtn = new System.Windows.Forms.Button();
            this.custAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.custPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.custLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.custfirstNAme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.custId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.disCount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.priceafterQ = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالسطرالحاليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosebtn = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveSale = new System.Windows.Forms.Button();
            this.newSale = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.paid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.debit = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Con_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Con_user);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ConNote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ConID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // Con_date
            // 
            this.Con_date.Location = new System.Drawing.Point(48, 148);
            this.Con_date.Name = "Con_date";
            this.Con_date.Size = new System.Drawing.Size(216, 21);
            this.Con_date.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاريخ البيع";
            // 
            // Con_user
            // 
            this.Con_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Con_user.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Con_user.Location = new System.Drawing.Point(48, 186);
            this.Con_user.Name = "Con_user";
            this.Con_user.ReadOnly = true;
            this.Con_user.Size = new System.Drawing.Size(216, 21);
            this.Con_user.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم البائع";
            // 
            // ConNote
            // 
            this.ConNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNote.Location = new System.Drawing.Point(48, 72);
            this.ConNote.Multiline = true;
            this.ConNote.Name = "ConNote";
            this.ConNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConNote.Size = new System.Drawing.Size(216, 56);
            this.ConNote.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "وصف الفاتورة";
            // 
            // ConID
            // 
            this.ConID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConID.Location = new System.Drawing.Point(109, 38);
            this.ConID.Name = "ConID";
            this.ConID.ReadOnly = true;
            this.ConID.Size = new System.Drawing.Size(155, 21);
            this.ConID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustChoosBtn);
            this.groupBox2.Controls.Add(this.custAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.custPhone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.custLastName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.custfirstNAme);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.custId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(403, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // CustChoosBtn
            // 
            this.CustChoosBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustChoosBtn.Location = new System.Drawing.Point(23, 31);
            this.CustChoosBtn.Name = "CustChoosBtn";
            this.CustChoosBtn.Size = new System.Drawing.Size(58, 25);
            this.CustChoosBtn.TabIndex = 0;
            this.CustChoosBtn.Text = "....";
            this.CustChoosBtn.UseVisualStyleBackColor = true;
            this.CustChoosBtn.Click += new System.EventHandler(this.CustChoosBtn_Click);
            // 
            // custAddress
            // 
            this.custAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddress.Location = new System.Drawing.Point(23, 186);
            this.custAddress.Name = "custAddress";
            this.custAddress.ReadOnly = true;
            this.custAddress.Size = new System.Drawing.Size(216, 21);
            this.custAddress.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "عنوانه";
            // 
            // custPhone
            // 
            this.custPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhone.Location = new System.Drawing.Point(23, 148);
            this.custPhone.Name = "custPhone";
            this.custPhone.ReadOnly = true;
            this.custPhone.Size = new System.Drawing.Size(216, 21);
            this.custPhone.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "هاتف";
            // 
            // custLastName
            // 
            this.custLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custLastName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLastName.Location = new System.Drawing.Point(23, 109);
            this.custLastName.Name = "custLastName";
            this.custLastName.ReadOnly = true;
            this.custLastName.Size = new System.Drawing.Size(216, 21);
            this.custLastName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "اسم العائلة";
            // 
            // custfirstNAme
            // 
            this.custfirstNAme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custfirstNAme.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custfirstNAme.Location = new System.Drawing.Point(23, 72);
            this.custfirstNAme.Name = "custfirstNAme";
            this.custfirstNAme.ReadOnly = true;
            this.custfirstNAme.Size = new System.Drawing.Size(216, 21);
            this.custfirstNAme.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "الاسم الاول";
            // 
            // custId
            // 
            this.custId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custId.Location = new System.Drawing.Point(87, 33);
            this.custId.Name = "custId";
            this.custId.ReadOnly = true;
            this.custId.Size = new System.Drawing.Size(155, 21);
            this.custId.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "رقم العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.TotalPrice);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.disCount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.priceafterQ);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.qty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.price);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.id);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.choosebtn);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Lavender;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(670, 21);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(65, 22);
            this.label18.TabIndex = 15;
            this.label18.Text = "اختيار";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPrice
            // 
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPrice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(6, 44);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(95, 21);
            this.TotalPrice.TabIndex = 8;
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 21);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(95, 22);
            this.label17.TabIndex = 13;
            this.label17.Text = "الإجمالي";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disCount
            // 
            this.disCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disCount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disCount.Location = new System.Drawing.Point(101, 44);
            this.disCount.MaxLength = 8;
            this.disCount.Name = "disCount";
            this.disCount.Size = new System.Drawing.Size(84, 21);
            this.disCount.TabIndex = 6;
            this.disCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disCount.TextChanged += new System.EventHandler(this.disCount_TextChanged);
            this.disCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disCount_KeyDown);
            this.disCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disCount_KeyPress);
            this.disCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.disCount_KeyUp);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(101, 21);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(84, 22);
            this.label16.TabIndex = 11;
            this.label16.Text = "الخصم";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceafterQ
            // 
            this.priceafterQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceafterQ.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceafterQ.Location = new System.Drawing.Point(185, 44);
            this.priceafterQ.Name = "priceafterQ";
            this.priceafterQ.ReadOnly = true;
            this.priceafterQ.Size = new System.Drawing.Size(80, 21);
            this.priceafterQ.TabIndex = 22;
            this.priceafterQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(185, 21);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(78, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "المبلغ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qty
            // 
            this.qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(265, 44);
            this.qty.MaxLength = 8;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(66, 21);
            this.qty.TabIndex = 5;
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            this.qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qty_KeyDown);
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_KeyPress);
            this.qty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.qty_KeyUp);
            this.qty.Validating += new System.ComponentModel.CancelEventHandler(this.qty_Validating);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(264, 21);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(66, 22);
            this.label14.TabIndex = 7;
            this.label14.Text = "الكمية";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(331, 44);
            this.price.MaxLength = 10;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(89, 21);
            this.price.TabIndex = 4;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            this.price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.price_KeyDown);
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            this.price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.price_KeyUp);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(331, 21);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(89, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "ثمن الوحدة";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(420, 44);
            this.label.Name = "label";
            this.label.ReadOnly = true;
            this.label.Size = new System.Drawing.Size(176, 21);
            this.label.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(420, 21);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(176, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "اسم البضاعة";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(596, 44);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(75, 21);
            this.id.TabIndex = 2;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(596, 21);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(75, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "معرف البضاعة";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 117);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator2,
            this.حذفالسطرالحاليToolStripMenuItem,
            this.حذفالكلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 82);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // حذفالسطرالحاليToolStripMenuItem
            // 
            this.حذفالسطرالحاليToolStripMenuItem.Name = "حذفالسطرالحاليToolStripMenuItem";
            this.حذفالسطرالحاليToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.حذفالسطرالحاليToolStripMenuItem.Text = "حذف السطر الحالي";
            this.حذفالسطرالحاليToolStripMenuItem.Click += new System.EventHandler(this.حذفالسطرالحاليToolStripMenuItem_Click);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // choosebtn
            // 
            this.choosebtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosebtn.Location = new System.Drawing.Point(669, 43);
            this.choosebtn.Name = "choosebtn";
            this.choosebtn.Size = new System.Drawing.Size(66, 23);
            this.choosebtn.TabIndex = 1;
            this.choosebtn.Text = "....";
            this.choosebtn.UseVisualStyleBackColor = true;
            this.choosebtn.Click += new System.EventHandler(this.choosebtn_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Enabled = false;
            this.deleteItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.Location = new System.Drawing.Point(41, 447);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(134, 25);
            this.deleteItem.TabIndex = 1;
            this.deleteItem.Text = "حذف السطر المحدد";
            this.deleteItem.UseVisualStyleBackColor = true;
            // 
            // Total
            // 
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(376, 445);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(95, 21);
            this.Total.TabIndex = 18;
            this.Total.Text = " ";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "المجموع";
            // 
            // SaveSale
            // 
            this.SaveSale.Enabled = false;
            this.SaveSale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSale.Location = new System.Drawing.Point(275, 498);
            this.SaveSale.Name = "SaveSale";
            this.SaveSale.Size = new System.Drawing.Size(95, 44);
            this.SaveSale.TabIndex = 3;
            this.SaveSale.Text = "حفظ البيع";
            this.SaveSale.UseVisualStyleBackColor = true;
            this.SaveSale.Click += new System.EventHandler(this.SaveSale_Click);
            // 
            // newSale
            // 
            this.newSale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSale.Location = new System.Drawing.Point(172, 498);
            this.newSale.Name = "newSale";
            this.newSale.Size = new System.Drawing.Size(97, 44);
            this.newSale.TabIndex = 15;
            this.newSale.Text = "بيع جديد";
            this.newSale.UseVisualStyleBackColor = true;
            this.newSale.Click += new System.EventHandler(this.newSale_Click);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(376, 498);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(91, 44);
            this.Print.TabIndex = 4;
            this.Print.Text = "طباعة الفاتورة";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(475, 498);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(72, 44);
            this.exit.TabIndex = 22;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // paid
            // 
            this.paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid.Location = new System.Drawing.Point(516, 446);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(95, 21);
            this.paid.TabIndex = 24;
            this.paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paid.TextChanged += new System.EventHandler(this.paid_TextChanged);
            this.paid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.paid_KeyDown);
            this.paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_KeyPress);
            this.paid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.paid_KeyUp);
            this.paid.Validating += new System.ComponentModel.CancelEventHandler(this.paid_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(487, 448);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "نقد";
            // 
            // debit
            // 
            this.debit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debit.Location = new System.Drawing.Point(653, 447);
            this.debit.Name = "debit";
            this.debit.ReadOnly = true;
            this.debit.Size = new System.Drawing.Size(95, 21);
            this.debit.TabIndex = 26;
            this.debit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.debit.TextChanged += new System.EventHandler(this.debit_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(619, 449);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "آجل";
            // 
            // ContractSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 556);
            this.Controls.Add(this.debit);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.newSale);
            this.Controls.Add(this.SaveSale);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ContractSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة بيع";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox custAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox custPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox custLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox custfirstNAme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox disCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox priceafterQ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.DateTimePicker Con_date;
        public System.Windows.Forms.TextBox Con_user;
        public System.Windows.Forms.TextBox ConNote;
        public System.Windows.Forms.TextBox ConID;
        public System.Windows.Forms.TextBox custId;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox Total;
        public System.Windows.Forms.Button SaveSale;
        public System.Windows.Forms.Button newSale;
        public System.Windows.Forms.Button Print;
        public System.Windows.Forms.Button choosebtn;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem حذفالسطرالحاليToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
        public System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox debit;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Button CustChoosBtn;
    }
}