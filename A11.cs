//Leap Year or Not
using System;
class A11
{
	public static void Main(string []args)
	{
		int year=Convert.ToInt32(args[0]);
	
		if (year % 4 ==0)
		{
			Console.WriteLine(" leap year");
		}
		else
		{
			Console.WriteLine("Not leap Year");
		}
	}
}