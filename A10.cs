//Enter Qty and give Discount 
using System;
class A10
{
	public static void Main(string []args)
	{
		double qty=Convert.ToDouble(args[0]);
		double r=Convert.ToDouble(args[1]);
		double amt=qty*r;

		if (amt>=1000)
		{
			double dis=amt*5/100;
			Console.WriteLine("Discount is :"+dis);
			amt=amt-dis;
		}
		Console.WriteLine("Amount is :" +amt);
		
	}
}