using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgercim
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Extra> Extra { get; set; }
        public int Adet { get; set; }

        public void Hesapla()
        {

            switch (Boyut)
            {
                case Boyut.Orta: this.Menu.MenuFiyat += 3;
                    break;
                case Boyut.Buyuk: this.Menu.MenuFiyat += 5;
                    break;
            }

            foreach (var item in this.Extra)
            {

            }

        }

        public override string ToString()
        {
            return "";
        }
    }
}
