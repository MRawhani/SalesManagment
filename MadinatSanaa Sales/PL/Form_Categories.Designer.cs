namespace MadinatSanaa_Sales.PL
{
    partial class Form_Categories
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteCAt = new System.Windows.Forms.Button();
            this.updateCat = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.newCat = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.fetchlast = new System.Windows.Forms.Button();
            this.fetchnext = new System.Windows.Forms.Button();
            this.fetchprev = new System.Windows.Forms.Button();
            this.fetchFirst = new System.Windows.Forms.Button();
            this.desk_cat = new System.Windows.Forms.TextBox();
            this.id_cat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.printOne = new System.Windows.Forms.Button();
            this.printAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Controls.Add(this.fetchlast);
            this.groupBox1.Controls.Add(this.fetchnext);
            this.groupBox1.Controls.Add(this.fetchprev);
            this.groupBox1.Controls.Add(this.fetchFirst);
            this.groupBox1.Controls.Add(this.desk_cat);
            this.groupBox1.Controls.Add(this.id_cat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.deleteCAt);
            this.groupBox2.Controls.Add(this.updateCat);
            this.groupBox2.Controls.Add(this.addCat);
            this.groupBox2.Controls.Add(this.newCat);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // deleteCAt
            // 
            this.deleteCAt.Location = new System.Drawing.Point(8, 119);
            this.deleteCAt.Name = "deleteCAt";
            this.deleteCAt.Size = new System.Drawing.Size(75, 32);
            this.deleteCAt.TabIndex = 3;
            this.deleteCAt.Text = "حذف";
            this.deleteCAt.UseVisualStyleBackColor = true;
            this.deleteCAt.Click += new System.EventHandler(this.deleteCAt_Click);
            // 
            // updateCat
            // 
            this.updateCat.Location = new System.Drawing.Point(8, 87);
            this.updateCat.Name = "updateCat";
            this.updateCat.Size = new System.Drawing.Size(75, 32);
            this.updateCat.TabIndex = 2;
            this.updateCat.Text = "تعديل";
            this.updateCat.UseVisualStyleBackColor = true;
            this.updateCat.Click += new System.EventHandler(this.updateCat_Click);
            // 
            // addCat
            // 
            this.addCat.Enabled = false;
            this.addCat.Location = new System.Drawing.Point(8, 54);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(75, 32);
            this.addCat.TabIndex = 1;
            this.addCat.Text = "إضافة";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // newCat
            // 
            this.newCat.Location = new System.Drawing.Point(8, 21);
            this.newCat.Name = "newCat";
            this.newCat.Size = new System.Drawing.Size(75, 32);
            this.newCat.TabIndex = 0;
            this.newCat.Text = "جديد";
            this.newCat.UseVisualStyleBackColor = true;
            this.newCat.Click += new System.EventHandler(this.newCat_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(387, 175);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(35, 13);
            this.labelPosition.TabIndex = 8;
            this.labelPosition.Text = "label3";
            // 
            // fetchlast
            // 
            this.fetchlast.Location = new System.Drawing.Point(249, 170);
            this.fetchlast.Name = "fetchlast";
            this.fetchlast.Size = new System.Drawing.Size(46, 23);
            this.fetchlast.TabIndex = 7;
            this.fetchlast.Text = ">>||";
            this.fetchlast.UseVisualStyleBackColor = true;
            this.fetchlast.Click += new System.EventHandler(this.fetchlast_Click);
            // 
            // fetchnext
            // 
            this.fetchnext.Location = new System.Drawing.Point(300, 170);
            this.fetchnext.Name = "fetchnext";
            this.fetchnext.Size = new System.Drawing.Size(51, 23);
            this.fetchnext.TabIndex = 6;
            this.fetchnext.Text = ">>";
            this.fetchnext.UseVisualStyleBackColor = true;
            this.fetchnext.Click += new System.EventHandler(this.fetchnext_Click);
            // 
            // fetchprev
            // 
            this.fetchprev.Location = new System.Drawing.Point(451, 170);
            this.fetchprev.Name = "fetchprev";
            this.fetchprev.Size = new System.Drawing.Size(57, 23);
            this.fetchprev.TabIndex = 5;
            this.fetchprev.Text = "<<";
            this.fetchprev.UseVisualStyleBackColor = true;
            this.fetchprev.Click += new System.EventHandler(this.fetchprev_Click);
            // 
            // fetchFirst
            // 
            this.fetchFirst.Location = new System.Drawing.Point(513, 170);
            this.fetchFirst.Name = "fetchFirst";
            this.fetchFirst.Size = new System.Drawing.Size(48, 23);
            this.fetchFirst.TabIndex = 4;
            this.fetchFirst.Text = "||<<";
            this.fetchFirst.UseVisualStyleBackColor = true;
            this.fetchFirst.Click += new System.EventHandler(this.fetchFirst_Click);
            // 
            // desk_cat
            // 
            this.desk_cat.Location = new System.Drawing.Point(249, 96);
            this.desk_cat.Multiline = true;
            this.desk_cat.Name = "desk_cat";
            this.desk_cat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.desk_cat.Size = new System.Drawing.Size(311, 52);
            this.desk_cat.TabIndex = 3;
            // 
            // id_cat
            // 
            this.id_cat.Location = new System.Drawing.Point(406, 45);
            this.id_cat.Name = "id_cat";
            this.id_cat.ReadOnly = true;
            this.id_cat.Size = new System.Drawing.Size(154, 20);
            this.id_cat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف الصنف";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "معرف الصنف";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(42, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 224);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عرض الأصناف";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(486, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.exit);
            this.groupBox4.Controls.Add(this.printOne);
            this.groupBox4.Controls.Add(this.printAll);
            this.groupBox4.Location = new System.Drawing.Point(570, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(81, 193);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "العمليات";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(6, 127);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(69, 29);
            this.exit.TabIndex = 8;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button7_Click);
            // 
            // printOne
            // 
            this.printOne.Location = new System.Drawing.Point(6, 36);
            this.printOne.Name = "printOne";
            this.printOne.Size = new System.Drawing.Size(69, 41);
            this.printOne.TabIndex = 7;
            this.printOne.Text = "طباعة صنف واحد";
            this.printOne.UseVisualStyleBackColor = true;
            this.printOne.Click += new System.EventHandler(this.printOne_Click);
            // 
            // printAll
            // 
            this.printAll.Location = new System.Drawing.Point(6, 83);
            this.printAll.Name = "printAll";
            this.printAll.Size = new System.Drawing.Size(69, 39);
            this.printAll.TabIndex = 6;
            this.printAll.Text = "طباعة الكل";
            this.printAll.UseVisualStyleBackColor = true;
            this.printAll.Click += new System.EventHandler(this.printAll_Click);
            // 
            // Form_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض الأصناف";
            this.Load += new System.EventHandler(this.Form_Categories_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteCAt;
        private System.Windows.Forms.Button updateCat;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Button newCat;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button fetchlast;
        private System.Windows.Forms.Button fetchnext;
        private System.Windows.Forms.Button fetchprev;
        private System.Windows.Forms.Button fetchFirst;
        private System.Windows.Forms.TextBox desk_cat;
        private System.Windows.Forms.TextBox id_cat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button printOne;
        private System.Windows.Forms.Button printAll;
    }
}