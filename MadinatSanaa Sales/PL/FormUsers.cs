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
    public partial class FormUsers : Form
    {
        BL.UseresClass user = new BL.UseresClass();
        public FormUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(user_id.Text !=string.Empty && pwd.Text != string.Empty && pwdConfirm.Text != string.Empty && FullName.Text != string.Empty && userType.Text !=string.Empty)
            {
                if (pwd.Text != pwdConfirm.Text)
                {
                    MessageBox.Show("كلمة السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    pwd.Focus();
                    return;
                }
                try
                {

                    user.Add_user(user_id.Text, pwd.Text, userType.Text, FullName.Text);
                    MessageBox.Show("تم اضافة المستخدم", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            else
            {
                MessageBox.Show("أدخل الحقول الفارغة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            user_id.Clear();
            pwd.Clear();
            pwdConfirm.Clear();
            FullName.Clear();
            user_id.Focus();
        }

        private void pwdConfirm_Validated(object sender, EventArgs e)
        {
            if(pwd.Text != pwdConfirm.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                pwd.Focus();
            }
        }
    }
}
