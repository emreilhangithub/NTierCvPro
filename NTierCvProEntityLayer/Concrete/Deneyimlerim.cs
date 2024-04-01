using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCvPro.EntityLayer.Concrete
{
    public class Deneyimlerim
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
    }
}
