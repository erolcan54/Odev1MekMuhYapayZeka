using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1MekMuhYapayZeka
{
    public static class AgirlikDegistir
    {
        public static double[] AgirlikAzalt(double[] xDeger, double[] wDeger, double katsayi)
        {
            double[] degerler=new double[2];
            double w1change = wDeger[0] - (katsayi * xDeger[0]);
            double w2change = wDeger[1] - (katsayi * xDeger[1]);
            degerler[0] = w1change;
            degerler[1] = w2change;
            Console.WriteLine("Ağırlıklar azaltıldı. Yeni ağırlıklar : {0} ve  {1}",w1change,w2change);
            return degerler;
        }

        public static double[] AgirlikArtir(double[] xDeger, double[] wDeger, double katsayi)
        {
            double[] degerler = new double[2];
            double w1change = wDeger[0] + (katsayi * xDeger[0]);
            double w2change = wDeger[1] + (katsayi * xDeger[1]);
            degerler[0] = w1change;
            degerler[1] = w2change;
            Console.WriteLine("Ağırlıklar artırıldı. Yeni ağırlıklar : {0} ve  {1}", w1change, w2change);
            return degerler;
        }
    }
}
