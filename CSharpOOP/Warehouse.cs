using System;

namespace CSharpOOP
{
	class Warehouse
	{
		// Set warehouse properties and add getter and setter methods 
		public int ID { get; set;}
		public string WarehouseName { get; set;}

		// Constructor is the same as 'def initialize'
		public Warehouse(string Name, int ID){
			WarehouseName = Name;
			this.ID = ID;
		}

		public Item FindAndReturnItem(int itemID)
		{
			Item returnItem = new Item(){ ID = itemID, Name = "MS Office"};
			return returnItem;
		}
	}
}

