//numeric command line
using System;
class A6
{
	public static void Main(string[]args)
	{
		int a=Convert.ToInt32(args[0]);
		int b=Convert.ToInt32(args[1]);

		int c=a+b;

		Console.WriteLine("First Number is:"+a);
		Console.WriteLine("Second Number is:"+b);
		Console.WriteLine("Total is:"+c);
	}
}