using System;

namespace CSharpOOP
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var newWarehouse = new Warehouse ("Warehouse 1", 101);
			var myItem = newWarehouse.FindAndReturnItem (101);
			Console.WriteLine ("My item is {0}", myItem.Name);
		}
	}
}
