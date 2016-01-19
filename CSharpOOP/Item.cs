using System;

namespace CSharpOOP
{
	class Item
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}

	class Software : Item
	{
		public string ISBN { get; set;}
	}

	class Hardware : Item
	{
		public string SerialNumber { get; set;}
	}

	class Computer : Hardware
	{
		string CPUType { get; set;}
		string Disks { get; set;}
	}

	class Peripheral : Hardware
	{
		string Description { get; set;}
	}
}

