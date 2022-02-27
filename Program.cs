using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı");
                System.Console.WriteLine(outSayi);
            }
            else
            {
                System.Console.WriteLine("Başarısız");
            }

            Methodlar instance = new Methodlar();
            instance.Topla(4,5, out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);

            //method aşırı yükleme
            int ifade = 999;
            instance.EkranaYazdir(ifade);
        }

    
    }

    class Methodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine(veri);
        }
    }
}
