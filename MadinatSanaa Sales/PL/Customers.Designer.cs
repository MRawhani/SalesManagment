namespace MadinatSanaa_Sales.PL
{
    partial class Customers
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
            this.Searchbrn = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DebtText = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.labelposition = new System.Windows.Forms.Label();
            this.fetchnext = new System.Windows.Forms.Button();
            this.fetchlast = new System.Windows.Forms.Button();
            this.fetchprev = new System.Windows.Forms.Button();
            this.fetchfirst = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveEdit = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebrn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضفواتيرهذاالمستخدمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Searchbrn);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(431, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كل العملاء";
            // 
            // Searchbrn
            // 
            this.Searchbrn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbrn.Location = new System.Drawing.Point(6, 29);
            this.Searchbrn.Name = "Searchbrn";
            this.Searchbrn.Size = new System.Drawing.Size(89, 27);
            this.Searchbrn.TabIndex = 9;
            this.Searchbrn.Text = "بحث";
            this.Searchbrn.UseVisualStyleBackColor = true;
            this.Searchbrn.Click += new System.EventHandler(this.Searchbrn_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(111, 32);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(255, 20);
            this.searchText.TabIndex = 8;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyDown);
            this.searchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "إبحث هنا :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(501, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DebtText);
            this.groupBox2.Controls.Add(this.labe);
            this.groupBox2.Controls.Add(this.labelposition);
            this.groupBox2.Controls.Add(this.fetchnext);
            this.groupBox2.Controls.Add(this.fetchlast);
            this.groupBox2.Controls.Add(this.fetchprev);
            this.groupBox2.Controls.Add(this.fetchfirst);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.lastname);
            this.groupBox2.Controls.Add(this.firstname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // DebtText
            // 
            this.DebtText.Location = new System.Drawing.Point(40, 151);
            this.DebtText.Name = "DebtText";
            this.DebtText.ReadOnly = true;
            this.DebtText.Size = new System.Drawing.Size(271, 20);
            this.DebtText.TabIndex = 8;
            this.DebtText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.DebtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DebtText_KeyPress);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(346, 152);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(53, 13);
            this.labe.TabIndex = 15;
            this.labe.Text = "آجل عليه";
            this.labe.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelposition
            // 
            this.labelposition.AutoSize = true;
            this.labelposition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelposition.Location = new System.Drawing.Point(199, 197);
            this.labelposition.Name = "labelposition";
            this.labelposition.Size = new System.Drawing.Size(33, 13);
            this.labelposition.TabIndex = 14;
            this.labelposition.Text = "6 / 7";
            // 
            // fetchnext
            // 
            this.fetchnext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchnext.ForeColor = System.Drawing.Color.DarkCyan;
            this.fetchnext.Location = new System.Drawing.Point(115, 190);
            this.fetchnext.Name = "fetchnext";
            this.fetchnext.Size = new System.Drawing.Size(66, 27);
            this.fetchnext.TabIndex = 13;
            this.fetchnext.Text = ">>";
            this.fetchnext.UseVisualStyleBackColor = true;
            this.fetchnext.Click += new System.EventHandler(this.fetchnext_Click);
            // 
            // fetchlast
            // 
            this.fetchlast.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchlast.ForeColor = System.Drawing.Color.DarkCyan;
            this.fetchlast.Location = new System.Drawing.Point(43, 190);
            this.fetchlast.Name = "fetchlast";
            this.fetchlast.Size = new System.Drawing.Size(66, 27);
            this.fetchlast.TabIndex = 12;
            this.fetchlast.Text = ">>||";
            this.fetchlast.UseVisualStyleBackColor = true;
            this.fetchlast.Click += new System.EventHandler(this.fetchlast_Click);
            // 
            // fetchprev
            // 
            this.fetchprev.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchprev.ForeColor = System.Drawing.Color.DarkCyan;
            this.fetchprev.Location = new System.Drawing.Point(260, 190);
            this.fetchprev.Name = "fetchprev";
            this.fetchprev.Size = new System.Drawing.Size(66, 27);
            this.fetchprev.TabIndex = 11;
            this.fetchprev.Text = "<<";
            this.fetchprev.UseVisualStyleBackColor = true;
            this.fetchprev.Click += new System.EventHandler(this.fetchprev_Click);
            // 
            // fetchfirst
            // 
            this.fetchfirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchfirst.ForeColor = System.Drawing.Color.DarkCyan;
            this.fetchfirst.Location = new System.Drawing.Point(332, 190);
            this.fetchfirst.Name = "fetchfirst";
            this.fetchfirst.Size = new System.Drawing.Size(66, 27);
            this.fetchfirst.TabIndex = 10;
            this.fetchfirst.Text = "||<<";
            this.fetchfirst.UseVisualStyleBackColor = true;
            this.fetchfirst.Click += new System.EventHandler(this.fetchfirst_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(40, 119);
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(271, 20);
            this.address.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(40, 86);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Size = new System.Drawing.Size(271, 20);
            this.phone.TabIndex = 6;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(40, 55);
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Size = new System.Drawing.Size(271, 20);
            this.lastname.TabIndex = 5;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(40, 24);
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Size = new System.Drawing.Size(271, 20);
            this.firstname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " رقم التلفون";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الأخير";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم الأول";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Controls.Add(this.SaveEdit);
            this.groupBox3.Controls.Add(this.newbtn);
            this.groupBox3.Controls.Add(this.exitbtn);
            this.groupBox3.Controls.Add(this.deletebtn);
            this.groupBox3.Controls.Add(this.updatebrn);
            this.groupBox3.Controls.Add(this.addbtn);
            this.groupBox3.Location = new System.Drawing.Point(3, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات";
            // 
            // SaveEdit
            // 
            this.SaveEdit.Enabled = false;
            this.SaveEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEdit.Location = new System.Drawing.Point(154, 13);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(78, 40);
            this.SaveEdit.TabIndex = 19;
            this.SaveEdit.Text = "حفظ التعديل";
            this.SaveEdit.UseVisualStyleBackColor = true;
            this.SaveEdit.Click += new System.EventHandler(this.SaveEdit_Click);
            // 
            // newbtn
            // 
            this.newbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.Location = new System.Drawing.Point(349, 13);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(66, 40);
            this.newbtn.TabIndex = 18;
            this.newbtn.Text = "جديد";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(3, 13);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(58, 40);
            this.exitbtn.TabIndex = 17;
            this.exitbtn.Text = "خروج";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(93, 13);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(61, 40);
            this.deletebtn.TabIndex = 16;
            this.deletebtn.Text = "حذف";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebrn
            // 
            this.updatebrn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebrn.Location = new System.Drawing.Point(231, 13);
            this.updatebrn.Name = "updatebrn";
            this.updatebrn.Size = new System.Drawing.Size(59, 40);
            this.updatebrn.TabIndex = 15;
            this.updatebrn.Text = "تعديل";
            this.updatebrn.UseVisualStyleBackColor = true;
            this.updatebrn.Click += new System.EventHandler(this.updatebrn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Enabled = false;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(290, 13);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(60, 40);
            this.addbtn.TabIndex = 14;
            this.addbtn.Text = "إضافة";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضفواتيرهذاالمستخدمToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 48);
            // 
            // عرضفواتيرهذاالمستخدمToolStripMenuItem
            // 
            this.عرضفواتيرهذاالمستخدمToolStripMenuItem.Name = "عرضفواتيرهذاالمستخدمToolStripMenuItem";
            this.عرضفواتيرهذاالمستخدمToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.عرضفواتيرهذاالمستخدمToolStripMenuItem.Text = "عرض فواتير هذا المستخدم";
            this.عرضفواتيرهذاالمستخدمToolStripMenuItem.Click += new System.EventHandler(this.عرضفواتيرهذاالمستخدمToolStripMenuItem_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 322);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة الزبائن";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Searchbrn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelposition;
        private System.Windows.Forms.Button fetchnext;
        private System.Windows.Forms.Button fetchlast;
        private System.Windows.Forms.Button fetchprev;
        private System.Windows.Forms.Button fetchfirst;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebrn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button SaveEdit;
        private System.Windows.Forms.TextBox DebtText;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عرضفواتيرهذاالمستخدمToolStripMenuItem;
    }
}