using System;
using System.Collections.Generic;

namespace Generic
{
    class program
    {
        static void Main(string[] args)
        {
            //List<T> class
            // System.collections.Generic
            // T-> object türündedir.

            List <int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renklistesi = new List<string>();
            renklistesi.Add("Kirmizi");
            renklistesi.Add("Mavi");
            renklistesi.Add("Turuncu");
            renklistesi.Add("Sari");
            renklistesi.Add("Yesil");

            //Count
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach Ve List.Foreach ile elemanlara erişim 
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renklistesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma 
            sayiListesi.Remove(4);
            renklistesi.Remove("Yesil");

            sayiListesi.RemoveAt(0);
            renklistesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste İçerisinden Arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste İçerisinden Bulundu!");

            // Eleman İle İndex'e erişme
            Console.WriteLine(renklistesi.BinarySearch("sari"));  

            //Diziyi List'e çevirme
            string[] hayvanlar ={"kedi","köpek","kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ceyhun";
            kullanıcı1.Soyisim1 = "kılıç";
            kullanıcı1.Yas = 16;

             Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Abdullah";
            kullanıcı2.Soyisim1 = "yılmaz";
            kullanıcı2.Yas = 15;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar(){ 
                Isim="Deniz",
                Soyisim1="Arda",
                Yas=24
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:"+ kullanıcı.Soyisim1);
                Console.WriteLine("Kullanıcı yas:" + kullanıcı.Yas);  
            }
            yeniListe.Clear();


        }
    }


    public class Kullanıcılar
    {
        private string isim;

        private string Soyisim;
        private int yas;


        public string Isim { get => isim; set => isim = value; }

        

        public int Yas { get => yas; set => yas = value; }
        public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
    }
}       