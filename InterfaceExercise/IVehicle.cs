using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{

		public string  Vin { get; set; }
		public string Engine { get; set; }
		public bool CarbCompliant { get; set; }
		public string AutoManual { get; set; }

		public void ReadyForTransit();
		public void PreShipInspection();
		public void VehicleTotal();

    }
}

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
  */