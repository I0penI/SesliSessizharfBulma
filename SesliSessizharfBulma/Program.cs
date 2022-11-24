namespace SesliSessizharfBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Kelime: ");
            string kelime = Console.ReadLine().ToLower(); ;
            Console.Write("Sesli mi (1), Sessiz mi (2)? ");
            string sesliSessiz = Console.ReadLine();
            string sonuc = "";
            string[] sesliHarfler = new string[8]
            {
                "a", "e", "ı", "i", "o", "ö", "u", "ü"
            };
            if (sesliSessiz == "1")
                sonuc = SesliBul(kelime, sesliHarfler);
            else
                sonuc = SessizBul(kelime, sesliHarfler);
            Console.WriteLine(sonuc);

        }

        static string SesliBul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            int sayac = 0;
            foreach (char kelimeKarakter in kelime)
            {
                foreach (string sesli in sesliler)
                {
                    if (kelimeKarakter.ToString() == sesli)
                    {
                        sayac++;
                        if (!sonuc.Contains(kelimeKarakter))
                        {
                            sonuc += kelimeKarakter;
                        }
                        break;
                    }
                }
            }
            return sonuc + " (" + sayac + ")";

        }
        static string SessizBul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            int sayac = 0;
            bool sessizBulundu;
            foreach (char kelimeKarakter in kelime)
            {
                sessizBulundu = true;
                foreach (string sesli in sesliler)
                {
                    if (kelimeKarakter.ToString() == sesli)
                    {
                        sessizBulundu = false;
                        break;
                    }
                }
                if (sessizBulundu)
                {

                    sayac++;
                    if (!sonuc.Contains(kelimeKarakter))

                        sonuc += kelimeKarakter;
                }
                
            }
            return sonuc + " (" + sayac + ")";
        }

    }
}