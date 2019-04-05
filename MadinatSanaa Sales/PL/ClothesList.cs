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
    public partial class ClothesList : Form
    {
        BL.ClothAddClass clo = new BL.ClothAddClass();
        public ClothesList()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = clo.ShowAll();
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = clo.SearchClothes(searchText.Text);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
        }
    }
}
