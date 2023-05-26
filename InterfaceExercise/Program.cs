using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var Silverado = new Truck()
            {
                Vin = "1HGCG1657WA051534",
                AutoManual = " Automatic",
                GasDiesel = "Gas",
                CarbCompliant = true ,
                Engine = "V8",
                PayLoad = 2850,
                GrossVehicleWeight = 10000,

            };
            var Jetta = new Car()
            {
                Vin = "1HGCG1657KA051534",
                AutoManual = "Automatic",
                Engine = "Inline five cylinder",
                CarbCompliant = true,
                CoupeSedan = "Sedan",
                PassSeating = 4,
            };

            var AudiQ7 = new SUV()
            {
                Vin = "1FGCG1657LA051534",
                AutoManual = "Automatic",
                Engine = "V6",
                CarbCompliant = true,
                CargoSqFt = 300,
                CompactFullSize = "Fullsize",
            };

            var DealerCatalog = new List<IVehicle>();
            DealerCatalog.Add(Silverado);
            DealerCatalog.Add(Jetta);
            DealerCatalog.Add(AudiQ7 );


             foreach (var vehicle  in DealerCatalog )
             {
                Console.WriteLine("Mainfest item details...");
                
                 vehicle.PreShipInspection();
                Console.WriteLine();
                Console.WriteLine($"Vin {vehicle.Vin }, engine = {vehicle.Engine} Carb compliant {vehicle.CarbCompliant } Transmission = {vehicle.AutoManual }, ");
                Console.WriteLine();
                vehicle.ReadyForTransit();
                Console.WriteLine("");
                 Console.WriteLine("-----------------------------");
             }
           
            
            //Creatively display and organize their values
        }
    }
}
