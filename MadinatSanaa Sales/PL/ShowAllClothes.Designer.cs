namespace MadinatSanaa_Sales.PL
{
    partial class ShowAllClothes
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showExit = new System.Windows.Forms.Button();
            this.showexportexcell = new System.Windows.Forms.Button();
            this.showPrintAll = new System.Windows.Forms.Button();
            this.showprintone = new System.Windows.Forms.Button();
            this.showImage = new System.Windows.Forms.Button();
            this.showedit = new System.Windows.Forms.Button();
            this.Showdelete = new System.Windows.Forms.Button();
            this.showAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "قم بإدخال كلمة البحث";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(133, 12);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(253, 20);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة البضائع";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(718, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.showExit);
            this.groupBox2.Controls.Add(this.showexportexcell);
            this.groupBox2.Controls.Add(this.showPrintAll);
            this.groupBox2.Controls.Add(this.showprintone);
            this.groupBox2.Controls.Add(this.showImage);
            this.groupBox2.Controls.Add(this.showedit);
            this.groupBox2.Controls.Add(this.Showdelete);
            this.groupBox2.Controls.Add(this.showAdd);
            this.groupBox2.Location = new System.Drawing.Point(21, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عمليات على البيانات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // showExit
            // 
            this.showExit.Location = new System.Drawing.Point(7, 62);
            this.showExit.Name = "showExit";
            this.showExit.Size = new System.Drawing.Size(114, 33);
            this.showExit.TabIndex = 7;
            this.showExit.Text = "خروج";
            this.showExit.UseVisualStyleBackColor = true;
            this.showExit.Click += new System.EventHandler(this.showExit_Click);
            // 
            // showexportexcell
            // 
            this.showexportexcell.Location = new System.Drawing.Point(384, 62);
            this.showexportexcell.Name = "showexportexcell";
            this.showexportexcell.Size = new System.Drawing.Size(166, 33);
            this.showexportexcell.TabIndex = 6;
            this.showexportexcell.Text = "عرض عمليات الشراء للبضاعة";
            this.showexportexcell.UseVisualStyleBackColor = true;
            this.showexportexcell.Click += new System.EventHandler(this.showexportexcell_Click);
            // 
            // showPrintAll
            // 
            this.showPrintAll.Location = new System.Drawing.Point(122, 62);
            this.showPrintAll.Name = "showPrintAll";
            this.showPrintAll.Size = new System.Drawing.Size(114, 33);
            this.showPrintAll.TabIndex = 5;
            this.showPrintAll.Text = "طباعة الكل";
            this.showPrintAll.UseVisualStyleBackColor = true;
            this.showPrintAll.Click += new System.EventHandler(this.showPrintAll_Click);
            // 
            // showprintone
            // 
            this.showprintone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showprintone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showprintone.Location = new System.Drawing.Point(242, 62);
            this.showprintone.Name = "showprintone";
            this.showprintone.Size = new System.Drawing.Size(136, 33);
            this.showprintone.TabIndex = 4;
            this.showprintone.Text = "طباعة البضاعة المحددة";
            this.showprintone.UseVisualStyleBackColor = true;
            this.showprintone.Click += new System.EventHandler(this.showprintone_Click);
            // 
            // showImage
            // 
            this.showImage.Location = new System.Drawing.Point(180, 19);
            this.showImage.Name = "showImage";
            this.showImage.Size = new System.Drawing.Size(126, 33);
            this.showImage.TabIndex = 3;
            this.showImage.Text = "صورة البضاعة المخزنة";
            this.showImage.UseVisualStyleBackColor = true;
            this.showImage.Click += new System.EventHandler(this.showImage_Click);
            // 
            // showedit
            // 
            this.showedit.Location = new System.Drawing.Point(450, 19);
            this.showedit.Name = "showedit";
            this.showedit.Size = new System.Drawing.Size(129, 33);
            this.showedit.TabIndex = 2;
            this.showedit.Text = "تعديل البضاعة المحدده";
            this.showedit.UseVisualStyleBackColor = true;
            this.showedit.Click += new System.EventHandler(this.showedit_Click);
            // 
            // Showdelete
            // 
            this.Showdelete.Location = new System.Drawing.Point(310, 19);
            this.Showdelete.Name = "Showdelete";
            this.Showdelete.Size = new System.Drawing.Size(136, 33);
            this.Showdelete.TabIndex = 1;
            this.Showdelete.Text = "حذف البضاعة المحدده";
            this.Showdelete.UseVisualStyleBackColor = true;
            this.Showdelete.Click += new System.EventHandler(this.Showdelete_Click);
            // 
            // showAdd
            // 
            this.showAdd.Location = new System.Drawing.Point(583, 19);
            this.showAdd.Name = "showAdd";
            this.showAdd.Size = new System.Drawing.Size(125, 33);
            this.showAdd.TabIndex = 0;
            this.showAdd.Text = "إضافة بضاعة جديده";
            this.showAdd.UseVisualStyleBackColor = true;
            this.showAdd.Click += new System.EventHandler(this.showAdd_Click);
            // 
            // ShowAllClothes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ShowAllClothes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة البضائع";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showedit;
        private System.Windows.Forms.Button Showdelete;
        private System.Windows.Forms.Button showAdd;
        private System.Windows.Forms.Button showExit;
        private System.Windows.Forms.Button showexportexcell;
        private System.Windows.Forms.Button showPrintAll;
        private System.Windows.Forms.Button showprintone;
        private System.Windows.Forms.Button showImage;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textSearch;
    }
}