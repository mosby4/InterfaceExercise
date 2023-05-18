using System;
namespace InterfaceExercise
{
	public interface ICompany
	{
        // ICompnay properties
        public string Logo { get; set; }
        public string Moto { get; set; }

    }
}

/*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */