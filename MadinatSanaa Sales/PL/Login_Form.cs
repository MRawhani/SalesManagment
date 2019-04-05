using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadinatSanaa_Sales.PL
{
    public partial class Login_Form : Form
    {
        

        BL.Login_class log;
        Color colorfor = ColorTranslator.FromHtml("#FAF1E8");
        Color colorback = ColorTranslator.FromHtml("#AB7143");
        Color colorbackhover = ColorTranslator.FromHtml("#D28E13");
        public Login_Form()
        {
            InitializeComponent();
            login_btn.MouseEnter += OnMouseEnterButton1;
            login_btn.MouseLeave += OnMouseLeaveButton1;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
           
            //  this.login_btn.ForeColor = colorfor;
               this.login_btn.BackColor = colorbackhover;
           // this.logCancel_btn.BackColor = colorback;
            // login_btn.BackColor = SystemColors.ButtonHighlight; // or Color.Red or whatever you want
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
           
            this.login_btn.ForeColor = colorfor;
            this.login_btn.BackColor = colorback;
           
            //  login_btn.BackColor = SystemColors.ButtonFace;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logCancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
           log = new BL.Login_class();
            DataTable dt = log.Login(id_text.Text, pwd_text.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "مدير")
                {
                    Main_Form.getMain_Form().إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().المستخدمينToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().البيعToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().العملاءToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().الألبسةوأكسسواراتهاToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().استعادةنسخةسابقةToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().الموردينToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().المستخدمينToolStripMenuItem.Visible = true;
                    Main_Form.getMain_Form().الألبسةوأكسسواراتهاToolStripMenuItem.Visible = true;
                    Main_Form.getMain_Form().الموردينToolStripMenuItem.Visible = true;
                    Program.SalesMan = dt.Rows[0]["Full Name"].ToString();
                    this.Close();
                }
                else if (dt.Rows[0][2].ToString() == "مستخدم عادي")
                {
                    Main_Form.getMain_Form().إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().المستخدمينToolStripMenuItem.Visible = false;
                    Main_Form.getMain_Form().البيعToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().العملاءToolStripMenuItem.Enabled = true;
                    Main_Form.getMain_Form().الألبسةوأكسسواراتهاToolStripMenuItem.Visible = false;
                    Main_Form.getMain_Form().الموردينToolStripMenuItem.Visible = false;
                    Main_Form.getMain_Form().استعادةنسخةسابقةToolStripMenuItem.Enabled = true;
                    Program.SalesMan = dt.Rows[0]["Full Name"].ToString();
                    this.Close();
                }
                
                
            }
            else
                MessageBox.Show("Login faild");
        }

        private void id_text_Enter(object sender, EventArgs e)
        {
           
        }

        private void pwd_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_text_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pwd_text_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pwd_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pwd_text_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login_btn_Click(sender, e);
            }
        }

        private void logCancel_btn_MouseEnter(object sender, EventArgs e)
        {
          //  Color colorfor = System.Drawing.ColorTranslator.FromHtml("#FAF1E8");
           // Color colorback = System.Drawing.ColorTranslator.FromHtml("#D28E13");
            //  this.login_btn.ForeColor = colorfor;
            this.logCancel_btn.BackColor = colorbackhover;
        }

        private void logCancel_btn_MouseLeave(object sender, EventArgs e)
        {
            this.logCancel_btn.ForeColor = colorfor;
            this.logCancel_btn.BackColor = colorback;
        }

        private void login_btn_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
