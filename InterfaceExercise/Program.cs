using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany
            //Done 
            //Create 3 classes called Car , Truck , & SUV
            //Done 
            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            // Done 

            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */
            // Done 
            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            // Done 

            //Now, create objects of your 3 classes and give their members values;
            var Silverado = new Truck()
            {
                Vin = "1HGCG1657WA051534",
                AutoManual = "Auto",
                GasDiesel = "Gas",
                CarbCompliant = true ,
                Engine = "V8",
                PayLoad = 2850,
                GrossVehicleWeight = 10000,

            };
            var Jetta = new Car()
            {
                Vin = "1HGCG1657KA051534",
                AutoManual = "Auto",
                Engine = "I5",
                CarbCompliant = true,
                CoupeSedan = "Sedan",
                PassSeating = 4,
            };

            var AudiQ7 = new SUV()
            {
                Vin = "1FGCG1657LA051534",
                AutoManual = "Auto",
                Engine = "V6",
                CarbCompliant = true,
                CargoSqFt = 300,
                CompactFullSize = "Fullsize",
            };

            var DealerCatalog = new List<IVehicle>() { Silverado, Jetta, AudiQ7 };

            foreach (var vehicle  in DealerCatalog )
            {
                vehicle.PreShipInspection();
                vehicle.ReadyForTransit();
                vehicle.VehicleTotal();
                Console.WriteLine();
            }
            
            //Creatively display and organize their values
        }
    }
}
