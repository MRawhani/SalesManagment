namespace MadinatSanaa_Sales.PL
{
    partial class Restore
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
            this.FileName = new System.Windows.Forms.TextBox();
            this.CreateBakcup = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "الرجاء اختيار المكان الذي تريد استعادة النسخة منه";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(41, 92);
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Size = new System.Drawing.Size(510, 21);
            this.FileName.TabIndex = 8;
            // 
            // CreateBakcup
            // 
            this.CreateBakcup.Location = new System.Drawing.Point(378, 154);
            this.CreateBakcup.Name = "CreateBakcup";
            this.CreateBakcup.Size = new System.Drawing.Size(160, 23);
            this.CreateBakcup.TabIndex = 7;
            this.CreateBakcup.Text = "استعادة";
            this.CreateBakcup.UseVisualStyleBackColor = true;
            this.CreateBakcup.Click += new System.EventHandler(this.CreateBakcup_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(559, 89);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(87, 23);
            this.browse.TabIndex = 5;
            this.browse.Text = ".....";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(559, 154);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "الغاء";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(705, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.CreateBakcup);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.exit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Restore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعادة نسخة احتياطية";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button CreateBakcup;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}