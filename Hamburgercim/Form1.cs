using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgercim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SiparisOlustur siparisOlustur;
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisOlustur = new SiparisOlustur();
            siparisOlustur.MdiParent = this;
            siparisOlustur.Dock = DockStyle.Fill;
            siparisOlustur.Show();
        }

        private void hamburgerYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisOlustur = new SiparisOlustur();
            siparisOlustur.Hide();
            HamburgerEkle hamburgerEkle = new HamburgerEkle();
            hamburgerEkle.MdiParent = this;
            hamburgerEkle.Dock = DockStyle.Fill;
            hamburgerEkle.Show();
            //this.Hide();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisOlustur = new SiparisOlustur();
            siparisOlustur.Hide();
            ExtraMalzemeEkle extraMalzemeEkle = new ExtraMalzemeEkle();
            extraMalzemeEkle.MdiParent = this;
            extraMalzemeEkle.Dock = DockStyle.Fill;
            extraMalzemeEkle.Show();
            //this.Hide();
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
            siparisBilgileri.MdiParent = this;
            siparisBilgileri.Dock = DockStyle.Fill;
            siparisBilgileri.Show();
        }
    }
}
