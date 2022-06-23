using System;

namespace Turbo.az
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool tocontunie = false;

            Console.WriteLine("=======================================================");
            Console.WriteLine("    Turbo.AZ Console Versiyasina xos gelmisiniz !    ");
            Console.WriteLine("=======================================================");

            Console.WriteLine("Administarotrun nezerine catdiraq ki , eger elan haqqinda melumat etmek isteseniz , proqrami yeniden basladib istifadeci olaraq davam etmelidir .");

            Console.WriteLine("Eger Administratorsunuzsa , sifreyi daxil edin . Eks Halda istifadeci olaraq davam edeceksiniz .");
            string pass = "325";
            string passRequest = Console.ReadLine();
            if (passRequest == pass)
            {
                START: 
                Console.WriteLine("=======================================================");
                Console.WriteLine("Yeni Elave etmek istediyiniz melumati secin ( Marka , Model , Elan , Elanlar ) : ");
                string functionRequest = Console.ReadLine().ToLower();
                if (functionRequest == "model")
                {
                    do
                    {
                        ModelManager modelManager = new ModelManager();
                        Console.WriteLine("Yeni Model elave etmek isteyirsinizmi ?");
                        string tocontunieQuest = Console.ReadLine();
                        if (tocontunieQuest == "he")
                        {
                            tocontunie = true;
                        }
                        else
                        {
                            goto START;
                        }
                    } while (tocontunie == true);
                }
                else if (functionRequest == "marka")
                {
                    do
                    {
                        ManifacturerManager manifacturerManager = new ManifacturerManager();

                        Console.WriteLine("Yeni Marka elave etmek isteyirsinizmi ?");
                        string tocontunieQuest = Console.ReadLine();
                        if (tocontunieQuest == "he")
                        {
                            tocontunie = true;
                        }
                        else
                        {
                            goto START;
                        }
                    } while (tocontunie);
                }

                else if (functionRequest == "elan")
                {
                    AdvertismentManager newadvertisment = new AdvertismentManager();
                }

                else if (functionRequest == "elanlar")
                {
                    AllAdverts.ShowAdverts();
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("1 . Elanlara Baxmaq // 2. Elan Elave Etmek ");
                string userAsk = Console.ReadLine();

                if (userAsk == "1")
                {
                    AllAdverts.ShowAdverts();
                }
                else
                {

                    AdvertismentManager advertisment = new AdvertismentManager();
                    do
                    {
                        Console.WriteLine("Basqa Elan Elave etmek isteyirsinizmi ?");
                        string cont = Console.ReadLine();
                        if (cont == "he")
                        {
                            tocontunie = true;

                        }
                        else
                        {
                            tocontunie = false;
                        }
                    } while (tocontunie);
                }

                Console.WriteLine("Elani Silmek : 1 ; Bitirmek : 2");
                string asker = Console.ReadLine();
                if (asker == "1")
                {
                    Console.WriteLine("Parolu daxil edin :");
                    string passask = Console.ReadLine();
                    if (passask == "325")
                    {
                        Console.WriteLine("Elan Silindi !");
                        Console.WriteLine("Elanlara Qayit  : 1 / Bitirmek 2 .");
                        int finishornot = Convert.ToInt32(Console.ReadLine());
                        switch (finishornot)
                        {
                            case 1:

                                AllAdverts.ShowAdverts();
                                break;

                            case 2:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parol Duzgun deyil.");
                    }
                }
                else
                {
                    Console.WriteLine("Istifade etdiyiniz ucun tesekkurler .");
                }

            }
        }


    }
}

