﻿using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs butonu");
            }
            else
            {
                Console.WriteLine("degısmedi butonu");
            }
            if (sistemeGirisYapmısMi==true)
            {
                Console.WriteLine("Kullannıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
          
            
         

        }
    }
}
