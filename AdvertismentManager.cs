using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
    internal class AdvertismentManager : Car
    {

        public AdvertismentManager()
        {

            bool isContinue = false;
            ID = GetHashCode();
            Console.WriteLine("Avtomobilinizin VIN kodunun son 4 reqemini daxil ediniz :");
            VIN = Console.ReadLine();
            Console.WriteLine("Yeni Elan Elave Etmek istediyiniz Markani seciniz : ");
            ManifacName = Console.ReadLine();
            Console.WriteLine("Model elave ediniz : ");
            Model = Console.ReadLine();
            Console.WriteLine("Rengini elave ediniz : ");
            CarColor = Console.ReadLine();
            Console.WriteLine("Ban novunu elave ediniz : ");
            BanType = Console.ReadLine();
            Console.WriteLine("Istehsal tarixini elave ediniz : ");
            ProductionDate = Console.ReadLine();
            Console.WriteLine("Neqliyat vasitesinin yerlesdiyi seheri qeyd edin ");
            City = Console.ReadLine();
            Console.WriteLine("Suretler Qutusu Tipini qeyd edin : (Mexaniki / Avtomat)");
            GearBoxType = Console.ReadLine();
            Console.WriteLine("Mator Hecmini daxil edin : ");
            Engine = Console.ReadLine();
            Console.WriteLine("Yanacaq tipini daxil edin : ");
            FuelType = Console.ReadLine();
            Console.WriteLine("Yurusunu daxil edin :");
            DrivedDistance = Console.ReadLine();
            Console.WriteLine("Oturucu Tipini daxil edin : (On / Arxa / Tam )");
            TransmitterType = Console.ReadLine();
            Console.WriteLine("Avtomobilinizde olan techizatlari qeyd ediniz : ");
            Console.WriteLine("1 : Conditioners ; " +  "\n" + "2 : Yungun Lehimli Diskler" + "\n" + "3 : Yagis Sensonru " + "\n" + "4 : Parking Radar" + "\n" + "5 : Deri Salon" + "\n" + "6 : Xenon Lampalar" + "\n" + "7 : Arxa Kamera" + "\n" + "8 : Oturacaqlarin Vintilyasiyasi " + "\n" + "9 : Yan Perdeler" + "\n" + "10 : Merkezi Qapanma Sistemi " + "\n" + "11 : ABS");
            do
            {
                int supplyadd = Convert.ToInt32(Console.ReadLine());
                SupplyAdder(supplyadd);
                Console.WriteLine("Basqa Techizat elave etmek isteyirsinizmi ? (He / Yox )");
                string request = Console.ReadLine();
                if (request == "he")
                {
                    isContinue = true;
                }
                else
                {
                    isContinue = false;
                }
            } while (isContinue);
            Console.WriteLine("Qiymetini daxil ediniz :");
            Price = Console.ReadLine();
            Console.WriteLine("Barter : (Edilir / Edilmir )");
            isBarterable = Console.ReadLine();
            Console.WriteLine("Elaqe nomrenizi daxil edin : ");
            PhoneNumber = Console.ReadLine();
            WriteInfo();
        }
    }
}
