using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
    class Car : Vehicle
    {
        public Car()
        {
            List<int> Supply = new List<int>();
            this.Supply = Supply;
        }
        public int ManifactID { get; set; }
        public string ManifacName { get; set; }

        public string Model { get; set; }

        public string  CarColor { get; set; }

        public string BanType { get; set; }

        public string City { get; set; }

        public string ProductionDate { get; set; }

        public string GearBoxType { get; set; }

        public string Engine { get; set; }

        public string FuelType { get; set; }

        public string DrivedDistance { get; set; }

        public string TransmitterType { get; set; }

        public List <int>  Supply { get; set; }

        public string Price { get; set; }

        public string isBarterable { get; set; }

        public string PhoneNumber { get; set; }


         public int SupplyAdder( int value)
        {
            this.Supply.Add(value);
            return value;

        }

        public void WriteInfo()
        {
            StringBuilder Car = new StringBuilder();
            Car.Append("Marka Adi :  " + ManifacName + "\n");
            Car.Append("Model adi :  " + Model + "\n");
            Car.Append("Rengi :  " + CarColor + "\n");
            Car.Append("Ban Tipi :  " + BanType + "\n");
            Car.Append("Muherrik :  " + Engine + "\n");
            Car.Append("Yerlesdiyi seher :  " + City + "\n");
            Car.Append("Istehsal Tarixi :  " + ProductionDate + "\n");
            Car.Append("Suretler Qutusu :  " + GearBoxType + "\n");
            Car.Append("Oturucu :  " + TransmitterType + "\n");
            Car.Append("Yanacaq Tipi :  " + FuelType + "\n");
            Car.Append("Oturucu :  " + TransmitterType + "\n");
            Car.Append("Qiymeti :  " + Price + "\n");
            Car.Append("Barter oluna bilirmi :  " + isBarterable + "\n");
            Car.Append("Elaqe Nomresi : " + PhoneNumber);
            Console.WriteLine(Car);
        }
    }
}
