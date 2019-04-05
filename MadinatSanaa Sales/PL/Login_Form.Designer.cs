namespace MadinatSanaa_Sales.PL
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.pwd_text = new System.Windows.Forms.TextBox();
            this.logCancel_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة السر";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(115, 34);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(258, 20);
            this.id_text.TabIndex = 2;
            this.id_text.Enter += new System.EventHandler(this.id_text_Enter);
            // 
            // pwd_text
            // 
            this.pwd_text.Location = new System.Drawing.Point(115, 66);
            this.pwd_text.Name = "pwd_text";
            this.pwd_text.PasswordChar = '*';
            this.pwd_text.Size = new System.Drawing.Size(258, 20);
            this.pwd_text.TabIndex = 3;
            this.pwd_text.TextChanged += new System.EventHandler(this.pwd_text_TextChanged);
            this.pwd_text.DragEnter += new System.Windows.Forms.DragEventHandler(this.pwd_text_DragEnter);
            this.pwd_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwd_text_KeyDown);
            this.pwd_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwd_text_KeyPress);
            this.pwd_text.MouseEnter += new System.EventHandler(this.pwd_text_MouseEnter);
            // 
            // logCancel_btn
            // 
            this.logCancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.logCancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logCancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logCancel_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.logCancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.logCancel_btn.Location = new System.Drawing.Point(243, 106);
            this.logCancel_btn.Name = "logCancel_btn";
            this.logCancel_btn.Size = new System.Drawing.Size(130, 23);
            this.logCancel_btn.TabIndex = 5;
            this.logCancel_btn.Text = "الغاء";
            this.logCancel_btn.UseVisualStyleBackColor = false;
            this.logCancel_btn.Click += new System.EventHandler(this.logCancel_btn_Click);
            this.logCancel_btn.MouseEnter += new System.EventHandler(this.logCancel_btn_MouseEnter);
            this.logCancel_btn.MouseLeave += new System.EventHandler(this.logCancel_btn_MouseLeave);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.login_btn.Image = global::MadinatSanaa_Sales.Properties.Resources.Host16;
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.login_btn.Location = new System.Drawing.Point(115, 106);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(122, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "دخول";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.MouseEnter += new System.EventHandler(this.login_btn_MouseEnter);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(430, 147);
            this.Controls.Add(this.logCancel_btn);
            this.Controls.Add(this.pwd_text);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نافذة الدخول";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox pwd_text;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button logCancel_btn;
    }
}