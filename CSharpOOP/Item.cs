using System;

namespace CSharpOOP
{
	class Item
	{
		public int ID { get; set; }
		public string Name { get; set; }

		// Virtual method - it is intended to be overidden in derived classes
		public virtual void Purchase(){
			Console.WriteLine("Purchasing {0}", Name);
		}

	}

	// Software inherits from Item
	class Software : Item
	{
		public string ISBN { get; set;}
		public override void Purchase ()
		{
			base.Purchase ();
			Console.WriteLine ("Purchasing software with ID {0} and with ISBN: {0}", ID, ISBN);
		}
	}

	// Hardware inherits from Item
	class Hardware : Item
	{
		public string SerialNumber { get; set;}
	}

	// Computer inherits from Hardware
	class Computer : Hardware
	{
		public string CPUType { get; set;}
		public string Disks { get; set;}
		public override void Purchase ()
		{
			// Calls method from base class
			base.Purchase ();
			// Does a little extra after calling base method.
			Console.WriteLine ("My CPUType is {0}", CPUType);
		}
	}

	// Peripheral inherits from Hardware
	class Peripheral : Hardware
	{
		public string Description { get; set;}
	}
}

