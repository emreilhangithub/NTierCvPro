using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCvPro.EntityLayer.Concrete
{
    public class SosyalMedya
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Link { get; set; }
        public string Ikon { get; set; }
        public bool Durum { get; set; }
    }
}
