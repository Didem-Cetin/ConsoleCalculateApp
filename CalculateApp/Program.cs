namespace CalculateApp
{
    internal class Program
    {
            static void Main(string[] args)
            {
                string secim = "";

                do
                {
                    MenuYaz();

                    secim = Console.ReadLine();

                    secim = IslemBaslat(secim);
                    Console.Clear();


                } while (secim == "0" || secim == "1" || secim == "2" || secim == "3" || secim == "4" || secim == "5");


            }


            static void MenuYaz()
            {
                Console.Clear();

                Console.WriteLine("[1]-Toplama ");
                Console.WriteLine("[2]-Çıkarma ");
                Console.WriteLine("[3]-Bölme ");
                Console.WriteLine("[4]- Çarpma ");
                Console.WriteLine("[5]-Çıkış");
                Console.WriteLine(" ");
                Console.Write("Lütfen işlem numarasını giriniz : ");


            }




            static string IslemBaslat(string secim)
            {
                switch (secim)
                {
                    case "1":
                        ToplamaYap();
                        break;
                    case "2":
                        CikarmaYap();
                        break;
                    case "3":
                        BolmeYap();
                        break;
                    case "4":
                        CarpmaYap();
                        break;
                    case "5":
                        secim = CikisYap();
                        break;

                    default:
                        MenuYaz();
                        secim = "0";
                        break;
                }

                return secim;
            }

            static string CikisYap()
            {
                return "6";


            }

            static void SonucYaz(string sonucMetni)
            {
                Console.WriteLine("");
                Console.WriteLine("Sonuç : " + sonucMetni);

                Console.WriteLine("");
                Console.WriteLine("Devam etmek için bir tuşa basınız : ");
                Console.ReadKey();
            }


            static void IslemBasligiYaz(string baslik)
            {
                Console.Clear();

                Console.WriteLine(baslik);

                for (int i = 0; i < baslik.Length; i++)
                {
                    Console.Write("=");
                }

                Console.WriteLine("");
                Console.WriteLine("");

            }

            static void ToplamaYap()
            {
                IslemBasligiYaz("TOPLAMA İŞLEMİ : ");


                Console.Write("1.Sayıyı giriniz : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2.Sayıyı giriniz : ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 + sayi2;

                SonucYaz(sonuc.ToString());

            }

            static void CikarmaYap()
            {
                IslemBasligiYaz("ÇIKARMA İŞLEMİ : ");

                Console.Write("1.Sayıyı giriniz : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2.Sayıyı giriniz : ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 - sayi2;
                SonucYaz(sonuc.ToString());



            }

            static void BolmeYap()
            {

                IslemBasligiYaz("BÖLME İŞLEMİ : ");

                Console.Write("1.Sayıyı giriniz : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2.Sayıyı giriniz : ");

                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 / sayi2;
                SonucYaz(sonuc.ToString());



            }


            static void CarpmaYap()
            {
                IslemBasligiYaz("ÇARPMA İŞLEMİ : ");

                Console.Write("1.Sayıyı giriniz : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2.Sayıyı giriniz : ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 * sayi2;
                SonucYaz(sonuc.ToString());

            }



        }
    }
