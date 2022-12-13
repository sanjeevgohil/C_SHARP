//Input 3 int Number and Which Number is Max
using System;
class A12
{
	public static void Main(string []args)
	{
		int a=Convert.ToInt32(args[0]);
		int b=Convert.ToInt32(args[1]);
		int c=Convert.ToInt32(args[2]);
		
		if(a>b && a>c)
		{
			Console.WriteLine("First Number is Max ");
		}
		else if(b>a && b>c)
		{
			Console.WriteLine("Second Number is Max ");
		}
		else if (c>a && c>b)
		{
			Console.WriteLine("Third Number is Max");
		}
		else 
		{
			Console.WriteLine("More then One Number is Max");
		}
	}
}