namespace MadinatSanaa_Sales.PL
{
    partial class CustomersList
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
            this.ListGridVeiw = new System.Windows.Forms.DataGridView();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridVeiw)).BeginInit();
            this.SuspendLayout();
            // 
            // ListGridVeiw
            // 
            this.ListGridVeiw.AllowUserToDeleteRows = false;
            this.ListGridVeiw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListGridVeiw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListGridVeiw.Location = new System.Drawing.Point(0, 27);
            this.ListGridVeiw.Name = "ListGridVeiw";
            this.ListGridVeiw.ReadOnly = true;
            this.ListGridVeiw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListGridVeiw.Size = new System.Drawing.Size(593, 346);
            this.ListGridVeiw.TabIndex = 0;
            this.ListGridVeiw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListGridVeiw_CellContentClick);
            this.ListGridVeiw.DoubleClick += new System.EventHandler(this.ListGridVeiw_DoubleClick);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(334, 3);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(255, 20);
            this.searchText.TabIndex = 9;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "إبحث هنا :";
            // 
            // CustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 373);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListGridVeiw);
            this.Name = "CustomersList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة جميع العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.ListGridVeiw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ListGridVeiw;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label5;
    }
}