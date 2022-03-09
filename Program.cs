using System;

namespace staticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir sinif icerisindeki static olmayan fieldlara methodlara özelliklere o siniftan olusturdugumuz nesne aracıgıyla erisim saglıyoruz
            //static olanlara ise o sınıfın adıyla erisim sglıyoruz 
            // nesne olusturamayız 
            // static olmayan herhangi bir property kullanamayız tanımlamayız
            // static sınıflardan kalıtım ıslemi kullanamayız static sınıflara
            Console.WriteLine("Calısan Sayısı: {0}",Calisan.CalisanSayisi);

            // calısan sınıfından bir nesne yaratmak ıstıyorum cunku static olmayanları setlemek istiyorum.
            Calisan calisan = new Calisan("Ayse","Yılmaz","IK");
            Console.WriteLine("Calısan Sayısı: {0}",Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Ferhan","Abacı","ITE");
            Calisan calisan3 = new Calisan("Sıla","BURAK","IK");

            //nesnesi olmadan direk nesnesi ile eristik
            Console.WriteLine("Calısan Sayısı:{0}",Islemler.Topla(100,200));
            Console.WriteLine("Calısan Sayısı:{0}",Islemler.Cikar(400,50));

            

        }
        // static olmayan normal bir class olusturalım
        class Calisan
        {

            //static olanlar o sınıfa özgü olur  
            // burda normal bir class tanımladım
            // ve asagıda bir tane kurucusu var 
            // peki static kurucu yaramazmıyım
            private static int calisanSayisi;

            public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

            private string Isim;
            private string Soyisim;
            private string Departman;
            
            static Calisan(){
                //static kurucu 
                // static kurucunun erisim belirtici yoktur
                // calısanları nasıl belirliyordum kurucular aracıgıyla belirliyordum
                calisanSayisi=0;




            }

            public Calisan(string isim,string soyisim,string departman){
                //nesnesi yaratırlırken bu alanları setlemis oldum fieldlemis oldum 
                this.Isim=isim;
                this.Departman=departman;
                this.Soyisim=soyisim;
                calisanSayisi ++;


            }

        }

        static class Islemler{
            public static long Topla(int sayi1,int sayi2)
            {
                return sayi1 +sayi2;

            }
            public static long Cikar(int sayi1,int sayi2)
            {
                return sayi1 -sayi2;

            }

        }
    }
}
