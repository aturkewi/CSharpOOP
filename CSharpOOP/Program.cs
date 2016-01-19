using System;

namespace CSharpOOP
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 
			var newWarehouse = new Warehouse ("Warehouse 1", 101);
			var myItem = newWarehouse.FindAndReturnItem (101);
			Console.WriteLine ("My item is {0}", myItem.Name);
			*/

			var myComputer = new Computer ();
			myComputer.ID = 102;


			Item mySecondComputer = new Computer ();
			// Only have access to properties that and Item would have. 
			mySecondComputer.ID = 103;
			// 'as' treate object as if it is another class.
			Computer mySecondComputer2 = mySecondComputer as Computer;
			string myCPUType = mySecondComputer2.CPUType;
			mySecondComputer2.Name = "Jupiter";
			mySecondComputer2.Purchase ();

		}
	}
}
