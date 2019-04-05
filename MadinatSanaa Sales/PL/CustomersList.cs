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
    
    public partial class CustomersList : Form
    {
        BL.CustomersClass cust = new BL.CustomersClass();
        public CustomersList()
        {
            InitializeComponent();
            this.ListGridVeiw.DataSource = cust.ShowAll();
            // this is for hiding the id يعتمد على رتبته في الاجراء المخزن
            this.ListGridVeiw.Columns[0].Visible = false;
        }

        private void ListGridVeiw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListGridVeiw_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cust.SearchCust(searchText.Text);
            this.ListGridVeiw.DataSource = dt;
        }
    }
}
