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
    public partial class SiparisOlustur : Form
    {
        static List<Menu> menus = new List<Menu>()
        {
            new Menu()
            {
                MenuAd="Cheese Burger Menu",
                MenuFiyat=15.0
            },
            new Menu()
            {
                MenuAd="Whopper Burger Menu",
                MenuFiyat=12.0
            }
        };
        static List<Extra> extras = new List<Extra>()
        {
            new Extra()
            {
                ExtraAd="Hardal",
                ExtraFiyat=2.0
            },
            new Extra()
            {
                ExtraAd="BBQ",
                ExtraFiyat=1.0
            },
            new Extra()
            {
                ExtraAd="Ketçap",
                ExtraFiyat=3.0
            },
            new Extra()
            {
                ExtraAd="Mayonez",
                ExtraFiyat=3.5
            }
        };

        public SiparisOlustur()
        {
            InitializeComponent();
        }
        public static void AddMenu(Menu menu)
        {
            menus.Add(menu);
        }
        public static void AddExtra(Extra extra)
        {
            extras.Add(extra);
        }

        int x = 13;
        int y = 28;
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            lsBoxDoldur();
            toplamFiyatDoldur();
            CmBoxMenuFill();

            checkBoxExtraFillFlow();
            //checkBoxExtraFill();
        }

        //private void checkBoxExtraFill()
        //{
        //    for (int i = 0; i < extras.Count; i++)
        //    {
        //        CheckBox checkBox = new CheckBox();
        //        checkBox.Text = extras[i].ExtraAd;
        //        groupBoxExtra.Controls.Add(checkBox);
        //        checkBox.Location = new Point(x, y);
        //        y += 22;
        //    }
        //}
        private void checkBoxExtraFillFlow()
        {
            for (int i = 0; i < extras.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = extras[i].ExtraAd;
                flowLayoutPanel1.Controls.Add(checkBox);
            }
        }

        private void CmBoxMenuFill()
        {
            foreach (var menu in menus)
            {
                cmBoxMenu.Items.Add(menu.MenuAd);
            }
            cmBoxMenu.SelectedIndex = 0;
        }

        static List<Siparis> siparisler = new List<Siparis>();
        public static List<Siparis> GetSiparis()
        {
            return siparisler;
        }
        List<Extra> secExtra = new List<Extra>();
        Menu secilenMenu;
        double extraArtanFiyat = 0;
        Boyut secBoyut;
        int adet = 1;
        static double toplamFiyat = 0;
        static double toplamExtraArtanFiyat = 0;
        static int toplamSatilanUrunAdedi = 0;
        public static double GetToplamExtraArtanFiyat()
        {
            return toplamExtraArtanFiyat;
        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            var secilen = cmBoxMenu.SelectedItem.ToString();
            foreach (var menu in menus)
            {
                if (menu.MenuAd == secilen)
                {
                    secilenMenu = new Menu();
                    secilenMenu.MenuAd = menu.MenuAd;
                    secilenMenu.MenuFiyat = menu.MenuFiyat;
                }
            }
            //siparis.Add(new Siparis(secilenMenu)
            //{

            //});

            if (radioButtonKucuk.Checked)
            {
                secBoyut = Boyut.Kucuk;
            }
            else if (radioButtonOrta.Checked)
            {
                secBoyut = Boyut.Orta;
                secilenMenu.MenuFiyat = secilenMenu.MenuFiyat + 3;
            }
            else if (radioButtonBuyuk.Checked)
            {
                secBoyut = Boyut.Buyuk;
                secilenMenu.MenuFiyat += 5;
            }



            foreach (CheckBox box in flowLayoutPanel1.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                {
                    secExtra.Add(extras[box.TabIndex]);
                    extraArtanFiyat += extras[box.TabIndex].ExtraFiyat;
                    toplamExtraArtanFiyat += extras[box.TabIndex].ExtraFiyat;
                }
            }
            secilenMenu.MenuFiyat += extraArtanFiyat;
            extraArtanFiyat = 0;
            adet = Convert.ToInt32(numericUpDownAdet.Value);
            toplamSatilanUrunAdedi += adet;
            secilenMenu.MenuFiyat *= adet;

            siparisler.Add(new Siparis()
            {
                Menu = secilenMenu,
                Boyut = secBoyut,
                Extra = secExtra,
                Adet = adet
            });



            lsBoxDoldur();



            toplamFiyatDoldur();
        }

        private void toplamFiyatDoldur()
        {
            toplamFiyat = 0;
            foreach (var siparis in siparisler)
            {
                toplamFiyat += siparis.Menu.MenuFiyat;
            }
            txtToplamFiyat.Text = toplamFiyat.ToString();
        }
        public static int GetToplamSatilanUrunAdedi()
        {
            return toplamSatilanUrunAdedi;
        }
        public static double GetToplamFiyat()
        {
            toplamFiyat = 0;
            foreach (var siparis in siparisler)
            {
                toplamFiyat += siparis.Menu.MenuFiyat;
            }
            return toplamFiyat;
        }

        private void lsBoxDoldur()
        {
            listBoxSepet.Items.Clear();
            foreach (var siparis in siparisler)
            {
                listBoxSepet.Items.Add(siparis.Menu.MenuAd + " , "+ siparis.Adet +" Adet , "+ siparis.Boyut + " Boy , "+ /*ExtraBas(siparis.Extra) +   Bakılacak hata var    */ siparis.Menu.MenuFiyat + " TL");
            }
        }
        string ExtraBas(List<Extra> extras) //  Bakılacak hata var 
        {
            string bas = "";
            foreach (var extra in extras)
            {
                bas += extra.ExtraAd + " ";  
            }
            return bas;
        }

    }
}
