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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }
        //var List<tumSiparisler> = SiparisOlustur.GetSiparis();
        public List<Siparis> tumSiparisler { get; set; }
        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            tumSiparisler = SiparisOlustur.GetSiparis();
            foreach (var siparis in tumSiparisler)
            {
                lsBoxTumSiparisler.Items.Add(siparis.Menu.MenuAd + " , " + siparis.Adet + " Adet , " + siparis.Boyut + " Boy , " + siparis.Menu.MenuFiyat + " TL");
            }   
            labelCiro.Text = SiparisOlustur.GetToplamFiyat().ToString() + " TL";
            labelToplamSiparisSayisi.Text = tumSiparisler.Count.ToString();
            labelExtraMalzemeGeliri.Text = SiparisOlustur.GetToplamExtraArtanFiyat().ToString() + " TL";
            labelSatilanUrunAdedi.Text = SiparisOlustur.GetToplamSatilanUrunAdedi().ToString();
        }
    }
}
