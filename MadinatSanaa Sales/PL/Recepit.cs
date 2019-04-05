using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace MadinatSanaa_Sales.PL
{
    public partial class Recepit : MaterialForm
    {
        public Recepit()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey400, Primary.Grey800, Primary.Blue400, Accent.Green700, TextShade.WHITE
                );
            this.Text = "سند صرف";
            
        }

        private void Recepit_Load(object sender, EventArgs e)
        {

        }
    }
}
