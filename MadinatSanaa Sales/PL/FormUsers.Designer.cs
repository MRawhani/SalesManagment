namespace MadinatSanaa_Sales.PL
{
    partial class FormUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pwdConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.close);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.userType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pwdConfirm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.user_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(27, 53);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(231, 21);
            this.user_id.TabIndex = 0;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(27, 119);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(231, 21);
            this.pwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة السر";
            // 
            // pwdConfirm
            // 
            this.pwdConfirm.Location = new System.Drawing.Point(27, 148);
            this.pwdConfirm.Name = "pwdConfirm";
            this.pwdConfirm.PasswordChar = '*';
            this.pwdConfirm.Size = new System.Drawing.Size(231, 21);
            this.pwdConfirm.TabIndex = 3;
            this.pwdConfirm.Validated += new System.EventHandler(this.pwdConfirm_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "تأكيد كلمة السر";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(27, 85);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(231, 21);
            this.FullName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "اسمه الكامل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع المستخدم";
            // 
            // userType
            // 
            this.userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "مدير",
            "مستخدم عادي"});
            this.userType.Location = new System.Drawing.Point(27, 183);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(230, 21);
            this.userType.TabIndex = 4;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(144, 261);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 23);
            this.save.TabIndex = 5;
            this.save.Text = "حفظ المستخدم";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(27, 261);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(111, 23);
            this.close.TabIndex = 6;
            this.close.Text = "خروج";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 354);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "المستخدمون";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwdConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label1;
    }
}