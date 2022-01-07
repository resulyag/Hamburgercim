using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hamburgercim;

namespace Hamburgercim
{
    public partial class HamburgerEkle : Form
    {
        public HamburgerEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            newMenu.MenuAd = txtMenuAd.Text;
            newMenu.MenuFiyat =(double)numericUpDownFiyat.Value;
            SiparisOlustur.AddMenu(newMenu);

            MessageBox.Show(newMenu.MenuAd + " Eklendi!");
            this.Hide();
        }
    }
}
