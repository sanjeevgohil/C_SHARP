//Enter Number and Which number is Max
using System;
class A8
{
	public static void Main(string []args)
	{
		int a=Convert.ToInt32(args[0]);
		int b=Convert.ToInt32(args[1]);
	
		if (a>b)
		{
			Console.WriteLine("First Number is Max ");
		}	
		else
		{
			Console.WriteLine("Second Number is Max ");
		}
	}
}