namespace MadinatSanaa_Sales.PL
{
    partial class FormOrdersList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تفاصيلالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.اظهارسجلالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.showprintone = new System.Windows.Forms.Button();
            this.deleteCon = new System.Windows.Forms.Button();
            this.AddNEw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 309);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جميع الفواتير";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(813, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلالفاتورةToolStripMenuItem,
            this.تفاصيلالفاتورةToolStripMenuItem,
            this.toolStripSeparator1,
            this.اظهارسجلالفاتورةToolStripMenuItem,
            this.toolStripSeparator2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 82);
            // 
            // تعديلالفاتورةToolStripMenuItem
            // 
            this.تعديلالفاتورةToolStripMenuItem.Name = "تعديلالفاتورةToolStripMenuItem";
            this.تعديلالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.تعديلالفاتورةToolStripMenuItem.Text = "تعديل الفاتورة";
            this.تعديلالفاتورةToolStripMenuItem.Click += new System.EventHandler(this.تعديلالفاتورةToolStripMenuItem_Click);
            // 
            // تفاصيلالفاتورةToolStripMenuItem
            // 
            this.تفاصيلالفاتورةToolStripMenuItem.Name = "تفاصيلالفاتورةToolStripMenuItem";
            this.تفاصيلالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.تفاصيلالفاتورةToolStripMenuItem.Text = "تفاصيل الفاتورة";
            this.تفاصيلالفاتورةToolStripMenuItem.Click += new System.EventHandler(this.تفاصيلالفاتورةToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // اظهارسجلالفاتورةToolStripMenuItem
            // 
            this.اظهارسجلالفاتورةToolStripMenuItem.Name = "اظهارسجلالفاتورةToolStripMenuItem";
            this.اظهارسجلالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.اظهارسجلالفاتورةToolStripMenuItem.Text = "اظهار سجل الفاتورة";
            this.اظهارسجلالفاتورةToolStripMenuItem.Click += new System.EventHandler(this.اظهارسجلالفاتورةToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(319, 49);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(300, 20);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "قم بإدخال كلمة البحث";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(702, 390);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 33);
            this.exit.TabIndex = 7;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // showprintone
            // 
            this.showprintone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showprintone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showprintone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showprintone.Location = new System.Drawing.Point(21, 390);
            this.showprintone.Name = "showprintone";
            this.showprintone.Size = new System.Drawing.Size(141, 33);
            this.showprintone.TabIndex = 6;
            this.showprintone.Text = "طباعة  الفاتورة المحددة";
            this.showprintone.UseVisualStyleBackColor = true;
            this.showprintone.Click += new System.EventHandler(this.showprintone_Click);
            // 
            // deleteCon
            // 
            this.deleteCon.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCon.Location = new System.Drawing.Point(702, 57);
            this.deleteCon.Name = "deleteCon";
            this.deleteCon.Size = new System.Drawing.Size(138, 23);
            this.deleteCon.TabIndex = 8;
            this.deleteCon.Text = "حذف الفاتورة المحددة";
            this.deleteCon.UseVisualStyleBackColor = true;
            this.deleteCon.Click += new System.EventHandler(this.deleteCon_Click);
            // 
            // AddNEw
            // 
            this.AddNEw.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNEw.Location = new System.Drawing.Point(702, 28);
            this.AddNEw.Name = "AddNEw";
            this.AddNEw.Size = new System.Drawing.Size(138, 23);
            this.AddNEw.TabIndex = 9;
            this.AddNEw.Text = "اضافة فاتورة جديدة";
            this.AddNEw.UseVisualStyleBackColor = true;
            this.AddNEw.Click += new System.EventHandler(this.AddNEw_Click);
            // 
            // FormOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 459);
            this.Controls.Add(this.AddNEw);
            this.Controls.Add(this.deleteCon);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.showprintone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Name = "FormOrdersList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قائمة فواتير البيع";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button showprintone;
        private System.Windows.Forms.Button deleteCon;
        private System.Windows.Forms.Button AddNEw;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلالفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem اظهارسجلالفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تفاصيلالفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.TextBox textSearch;
    }
}