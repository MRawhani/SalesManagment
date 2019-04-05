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
    public partial class OrderDetailsForm : Form
    {
        BL.AddContract cons = new BL.AddContract();
        public OrderDetailsForm()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cons.SearchOrderDetails("");
           
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cons.SearchOrderDetails(searchText.Text);
        }
    }
}
