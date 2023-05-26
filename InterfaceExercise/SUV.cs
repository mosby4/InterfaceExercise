using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany 
	{
		public SUV()
		{
		}
        public void ReadyForTransit()
        {
            Console.WriteLine($"{GetType().Name} is ready for transit!!!");
        }
        public void PreShipInspection()
        {
            Console.WriteLine($"Vehicle {GetType().Name} has passed all required checks. ");
        }
        public void VehicleTotal()
        {
            Console.WriteLine($"This automobile has been added to the transit bill. ");
        }


        public int CargoSqFt { get; set; }
		public string CompactFullSize { get; set; }

        // IVehicle properties
        public string Vin { get; set; }
        public string Engine { get; set; }
        public bool CarbCompliant { get; set; }
        public string AutoManual { get; set; } 

        // ICompnay properties
        public string Logo { get; set; }
        public string Moto { get; set; }
    }
}
/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                  
 */
