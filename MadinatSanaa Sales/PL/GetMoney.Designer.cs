﻿namespace MadinatSanaa_Sales.PL
{
    partial class GetMoney
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
            this.Cus_id = new System.Windows.Forms.TextBox();
            this.chooseOrder = new System.Windows.Forms.Button();
            this.order_id = new System.Windows.Forms.TextBox();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choosCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.TextBox();
            this.firstFetch = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.lastFetch = new System.Windows.Forms.Button();
            this.nextFetch = new System.Windows.Forms.Button();
            this.prevFetch = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.Cus_id);
            this.groupBox1.Controls.Add(this.chooseOrder);
            this.groupBox1.Controls.Add(this.order_id);
            this.groupBox1.Controls.Add(this.NoteText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.choosCust);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.priceText);
            this.groupBox1.Controls.Add(this.ClientName);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات السند";
            // 
            // Cus_id
            // 
            this.Cus_id.Enabled = false;
            this.Cus_id.Location = new System.Drawing.Point(427, 112);
            this.Cus_id.Name = "Cus_id";
            this.Cus_id.Size = new System.Drawing.Size(92, 21);
            this.Cus_id.TabIndex = 11;
            this.Cus_id.TextChanged += new System.EventHandler(this.Cus_id_TextChanged);
            // 
            // chooseOrder
            // 
            this.chooseOrder.BackColor = System.Drawing.SystemColors.Menu;
            this.chooseOrder.Enabled = false;
            this.chooseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseOrder.Location = new System.Drawing.Point(69, 193);
            this.chooseOrder.Name = "chooseOrder";
            this.chooseOrder.Size = new System.Drawing.Size(129, 27);
            this.chooseOrder.TabIndex = 10;
            this.chooseOrder.Text = "اختيار فاتورة مدين";
            this.chooseOrder.UseVisualStyleBackColor = false;
            // 
            // order_id
            // 
            this.order_id.Location = new System.Drawing.Point(69, 219);
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Size = new System.Drawing.Size(129, 21);
            this.order_id.TabIndex = 9;
            // 
            // NoteText
            // 
            this.NoteText.Enabled = false;
            this.NoteText.Location = new System.Drawing.Point(204, 194);
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteText.Size = new System.Drawing.Size(315, 46);
            this.NoteText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ملاحظة";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "المبلغ المقبوض";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // choosCust
            // 
            this.choosCust.BackColor = System.Drawing.SystemColors.Menu;
            this.choosCust.Enabled = false;
            this.choosCust.Location = new System.Drawing.Point(525, 110);
            this.choosCust.Name = "choosCust";
            this.choosCust.Size = new System.Drawing.Size(100, 23);
            this.choosCust.TabIndex = 5;
            this.choosCust.Text = "اختيار عميل";
            this.choosCust.UseVisualStyleBackColor = false;
            this.choosCust.Click += new System.EventHandler(this.choosCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "رقم السند";
            // 
            // priceText
            // 
            this.priceText.Enabled = false;
            this.priceText.Location = new System.Drawing.Point(69, 153);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(450, 21);
            this.priceText.TabIndex = 3;
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            this.priceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceText_KeyPress);
            this.priceText.Validating += new System.ComponentModel.CancelEventHandler(this.priceText_Validating);
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(69, 110);
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Size = new System.Drawing.Size(339, 21);
            this.ClientName.TabIndex = 2;
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(69, 55);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(233, 21);
            this.date.TabIndex = 1;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(403, 55);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(116, 21);
            this.id.TabIndex = 0;
            // 
            // firstFetch
            // 
            this.firstFetch.BackColor = System.Drawing.SystemColors.Menu;
            this.firstFetch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFetch.Location = new System.Drawing.Point(2, 291);
            this.firstFetch.Name = "firstFetch";
            this.firstFetch.Size = new System.Drawing.Size(70, 35);
            this.firstFetch.TabIndex = 11;
            this.firstFetch.Text = "السند الأول";
            this.firstFetch.UseVisualStyleBackColor = false;
            this.firstFetch.Click += new System.EventHandler(this.firstFetch_Click);
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.newbtn.Location = new System.Drawing.Point(327, 291);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(54, 35);
            this.newbtn.TabIndex = 13;
            this.newbtn.Text = "جديد";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // lastFetch
            // 
            this.lastFetch.BackColor = System.Drawing.SystemColors.Menu;
            this.lastFetch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFetch.Location = new System.Drawing.Point(199, 291);
            this.lastFetch.Name = "lastFetch";
            this.lastFetch.Size = new System.Drawing.Size(71, 35);
            this.lastFetch.TabIndex = 14;
            this.lastFetch.Text = "السند الأخير";
            this.lastFetch.UseVisualStyleBackColor = false;
            this.lastFetch.Click += new System.EventHandler(this.lastFetch_Click);
            // 
            // nextFetch
            // 
            this.nextFetch.BackColor = System.Drawing.SystemColors.Menu;
            this.nextFetch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextFetch.Location = new System.Drawing.Point(140, 291);
            this.nextFetch.Name = "nextFetch";
            this.nextFetch.Size = new System.Drawing.Size(60, 35);
            this.nextFetch.TabIndex = 15;
            this.nextFetch.Text = "التالي";
            this.nextFetch.UseVisualStyleBackColor = false;
            this.nextFetch.Click += new System.EventHandler(this.nextFetch_Click);
            // 
            // prevFetch
            // 
            this.prevFetch.BackColor = System.Drawing.SystemColors.Menu;
            this.prevFetch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevFetch.Location = new System.Drawing.Point(71, 291);
            this.prevFetch.Name = "prevFetch";
            this.prevFetch.Size = new System.Drawing.Size(70, 35);
            this.prevFetch.TabIndex = 16;
            this.prevFetch.Text = "السابق";
            this.prevFetch.UseVisualStyleBackColor = false;
            this.prevFetch.Click += new System.EventHandler(this.prevFetch_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.Menu;
            this.edit.Location = new System.Drawing.Point(382, 291);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(54, 35);
            this.edit.TabIndex = 17;
            this.edit.Text = "تعديل";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.button3_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Menu;
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(439, 291);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(54, 35);
            this.save.TabIndex = 18;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button8_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Menu;
            this.exit.Location = new System.Drawing.Point(609, 291);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 35);
            this.exit.TabIndex = 19;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(277, 303);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(36, 17);
            this.labelPosition.TabIndex = 12;
            this.labelPosition.Text = "0 / 0";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Menu;
            this.delete.Location = new System.Drawing.Point(499, 291);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(54, 35);
            this.delete.TabIndex = 20;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // GetMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 328);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.prevFetch);
            this.Controls.Add(this.nextFetch);
            this.Controls.Add(this.lastFetch);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.firstFetch);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GetMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند قيض";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button choosCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chooseOrder;
        private System.Windows.Forms.TextBox order_id;
        private System.Windows.Forms.TextBox NoteText;
        private System.Windows.Forms.Button firstFetch;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button lastFetch;
        private System.Windows.Forms.Button nextFetch;
        private System.Windows.Forms.Button prevFetch;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox Cus_id;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button delete;
    }
}