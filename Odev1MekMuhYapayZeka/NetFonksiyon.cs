using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1MekMuhYapayZeka
{
    public static class NetFonksiyon
    {
        public static double NetHesapla(double[] xDeger, double[] wDeger)
        {
            return (wDeger[0]*xDeger[0] + wDeger[1]*xDeger[1]);
        }
    }
}
