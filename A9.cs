//Eligable for voting or not 
using System;
class A9
{
	public static void Main(string []args)
	{
		int no=Convert.ToInt32(args[0]);

		if (no>18)
		{
			Console.WriteLine("Eligable for Voting");
		}
		else
		{
			Console.WriteLine("Not Eligable for Voting");
		}
	}
}