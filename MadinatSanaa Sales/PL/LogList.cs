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
    public partial class LogList : Form
    {
        BL.AddContract con = new BL.AddContract();
        public LogList()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = con.SearchLogs("");
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = con.SearchLogs(textSearch.Text);
            /*
             +  CONVERT(varchar,[LogDate])+ 
               CONVERT(varchar,[order_id])+ item_id +CONVERT(varchar,[quantity])+ price + CONVERT(varchar,[DisCount])
                + Amount + Total +Notes */

        }
    }
}
