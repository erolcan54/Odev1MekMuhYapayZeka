// See https://aka.ms/new-console-template for more information
using Odev1MekMuhYapayZeka;

Console.WriteLine("Hello, World!");

int iterasyon = 0;
double[] ornek1 = { 1, 2, 0 };
double[] ornek2 = { 1, 5, 1 };
double[] ornek3 = { 1, 56, 1 };
double[] agirlik = { -1, 2 };
double EsikDeger = 0.5;
double OgrenmeKatsayi = 0.6;

double[][] ornekler = { ornek1, ornek2, ornek3 };


for (int i = 0; i < 3; i++)
{
    Baslangic:
    iterasyon++;
    double Net = NetFonksiyon.NetHesapla(ornekler[i], agirlik);
    Console.WriteLine("Bulunan NET değeri : {0}", Net);
    Console.WriteLine("Bulunması gereken değer : {0}", ornekler[i][2]);
    Console.WriteLine("Ağırlıklar : {0} ve {1}", agirlik[0], agirlik[1]);
    if (Net != ornekler[i][2])
    {
        if (Net < EsikDeger)
        {
            agirlik = AgirlikDegistir.AgirlikArtir(ornekler[i], agirlik, OgrenmeKatsayi);
        }

        if (Net > EsikDeger)
        {
            agirlik = AgirlikDegistir.AgirlikAzalt(ornekler[i], agirlik, OgrenmeKatsayi);
        }
        if(i==2)
        {
            i = 0;
            goto Baslangic;
        }
    }
    else
    {
        if (i < 3)
        {
            i++;
            goto Baslangic;
        }
        else
            break;
    }
    Console.WriteLine(iterasyon.ToString() + " .iterasyon " + ornekler[i][0] + " ve " + ornekler[i][1] + " x değerleri kullanıldı.");
    Console.WriteLine(iterasyon.ToString() + " .iterasyon " + agirlik[0] + " ve " + agirlik[1] + " w değerleri kullanıldı.");

}

Console.ReadKey();