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
    public partial class Main_Form : Form
    {
        // this variable is for entring the main form components from the login form
        // note that i have changed the modifiers of some of the main menu to public 
        static Main_Form main;
        // this is for lcosing the static variable

        public static void main_closed(Object sender, FormClosedEventArgs e)
        {
            // we are making it nnull because we may deal with it in another for other rthanthe login  Form
            main = null;
        }
        // this mehtod is to use the current main or create a new one if it = null
        // this method for getting the intialized main in the constructor, better to get a variable using get method 
        public static Main_Form getMain_Form()
        {
          
                if(main == null)
                {
                    main = new Main_Form();
                   // main.FormClosed += new FormClosedEventHandler(main_closed);

                }
                return main;
          
           
        }
        
        public Main_Form()
        {
            InitializeComponent();
            // this is for intializing the main to this
            if (main == null)
                main = this;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.البيعToolStripMenuItem.Enabled = false;
            this.الألبسةوأكسسواراتهاToolStripMenuItem.Enabled = false;
            this.استعادةنسخةسابقةToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.الموردينToolStripMenuItem.Enabled = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "خروج");
           // toolTip1.Show("خروج", pictureBox2);





        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form log = new Login_Form();
            log.ShowDialog();
        }

        private void إضافةلبسإالىالجردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClothAddNew cloth = new ClothAddNew();
            cloth.Show();

        }

        private void إدارةالألبسةالمخزنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowAllClothes().ShowDialog();
        }

        private void إدارةالأصنافالمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Categories().ShowDialog();
        }

        private void إدارةالزبائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.ShowDialog();
        }

        private void إضافةعمليةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.ContractSales con = new ContractSales();
            con.ShowDialog();
        }

        private void إدارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOrdersList().ShowDialog();
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUsers().ShowDialog();
        }

        private void إدارةالمسنخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsersList().ShowDialog();
        }

        private void إنشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BackUp().ShowDialog();

        }

        private void استعادةنسخةسابقةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Restore().ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void دائنومدينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إدارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SubbliersForm().ShowDialog();
        }

        private void سندقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GetMoney().ShowDialog();
        }

        private void ملفToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            /*Color colorfor = System.Drawing.ColorTranslator.FromHtml("#D28E13");
            Color colorback = System.Drawing.ColorTranslator.FromHtml("#FAF1E8");
            this.ملفToolStripMenuItem.ForeColor = colorfor;*/
          //  this.ملفToolStripMenuItem.BackColor = colorback;
            
        }

        private void ملفToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
          //  Color colorfor = System.Drawing.ColorTranslator.FromHtml("#D28E13");
           // Color colorback = System.Drawing.ColorTranslator.FromHtml("#FAF1E8");
          //  this.ملفToolStripMenuItem.ForeColor = colorfor;
         //   this.ملفToolStripMenuItem.BackColor = colorback;
        }

        private void ملفToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
           /* Color colorfor = System.Drawing.ColorTranslator.FromHtml("#FAF1E8");
           // Color colorback = System.Drawing.ColorTranslator.FromHtml("#FAF1E8");
            this.ملفToolStripMenuItem.ForeColor = colorfor;*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
