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
    }
}
