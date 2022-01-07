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
    public partial class ExtraMalzemeEkle : Form
    {
        public ExtraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Extra newExtra = new Extra();
            newExtra.ExtraAd = txtAd.Text;
            newExtra.ExtraFiyat = (double)numericUpDownFiyat.Value;
            SiparisOlustur.AddExtra(newExtra);
            MessageBox.Show(newExtra.ExtraAd + " Eklendi!");
            this.Hide();
        }
    }
}
