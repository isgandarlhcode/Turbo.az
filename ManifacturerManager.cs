using System;
using System.Collections.Generic;
using System.Text;

namespace Turbo.az
{
    public class ManifacturerManager : Manifacturer
    {
        public ManifacturerManager()
        {
            ManifactID = Convert.ToString(GetHashCode());
            Console.WriteLine("Elave etmek istediyiniz Marka adini daxil edin : ");
            ManifacName = Console.ReadLine();
            Console.WriteLine("Marka yaradilis tarixini daxil edin : ");
            ManifactFoundationDate = Console.ReadLine();
            WriteManifacInformation();
        }

        public void WriteManifacInformation()
        {
            StringBuilder ManifacINFO = new StringBuilder();
            ManifacINFO.Append("Marka Adi :  " + ManifacName + "\n");
            ManifacINFO.Append("Marka Yaradilis tarixi :  " + ManifactFoundationDate + "\n");
            Console.WriteLine(ManifacINFO);
        }
    }
}
