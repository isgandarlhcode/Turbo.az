using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
    public class ModelManager : Model
    {
        public ModelManager()
        {
            ModelID = Convert.ToString(GetHashCode());
            Console.WriteLine("Hansi markaya model elave etmek isteyirsiniz : ");
            string marka = Console.ReadLine();
            Console.WriteLine("Elave etmek istediyiniz modelin adini daxil edin : ");
            ModelName = Console.ReadLine();
            Console.WriteLine("Model Seriasini daxil edin : (Meselen : BMW dirse , 528 , 535 ve s. ) ");
            ModelSeries = Console.ReadLine();
            Console.WriteLine("Model Motor Hecmini daxil edin : (X.X)");
            ModelEngine = Console.ReadLine();
            Console.WriteLine("Model At gucunu daxil edin : ");
            ModelTorque = Console.ReadLine();
            Console.WriteLine("100 KM ucun olan benzin serfiyyatini daxil edin : ( Litr )");
            ModelFuelConsumption = Console.ReadLine();
            WriteModelInformation();
        }

        public void WriteModelInformation()
        {
            StringBuilder ModelINFO = new StringBuilder();
            ModelINFO.Append("Model Adi :  " + ModelName + "\n");
            ModelINFO.Append("Model Seriyasi :  " + ModelSeries + "\n");
            ModelINFO.Append("Model Muherrik :  " + ModelEngine + "\n");
            ModelINFO.Append("Model At Gucu :  " + ModelTorque + "\n");
            ModelINFO.Append("Model Serfiyati :  " + ModelFuelConsumption + "\n");
            Console.WriteLine(ModelINFO);
        }
    }
}
