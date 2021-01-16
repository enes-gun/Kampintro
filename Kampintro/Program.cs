using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapilmisMi= true ;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                    Console.WriteLine("azalış butonu ");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");

            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisYapilmisMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu "); 

            }
        
                  
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
