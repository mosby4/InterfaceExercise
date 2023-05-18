using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany 
	{
		public Truck()
		{
		}
        public void ReadyForTransit()
        {
            Console.WriteLine($"{GetType().Name} is ready for transit!!!");
        }
        public void PreShipInspection()
        {
            Console.WriteLine($" Vehicle {GetType().Name} has passed all required checks. ");
        }
        public void VehicleTotal()
        {
            Console.WriteLine($"This automobile has been added to the transit bill. ");
        }

        public int PayLoad { get; set; }
		public int GrossVehicleWeight { get; set; }
        public string GasDiesel { get; set; }

		// IVehicle properties
        public string Vin { get; set; }
        public string Engine { get; set; } = "V8";
        public bool CarbCompliant { get; set; } = true;
        public string AutoManual { get; set; } = "Auto";

        // ICompnay properties
        public string Logo { get; set; }
        public string Moto { get; set; }

    }
}

/*Create 2 members that are specific to each class
* Example: truck has a bed size while car has a trunk while suv has a cargo hold size
          
* Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
*/