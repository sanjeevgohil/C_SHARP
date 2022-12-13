//implicit type casting
using System;
class A16
{
	public static void Main(string []args)
	{
		int a=12345;
		double b=a;
		
		Console.WriteLine("Integer value is :"+a);
		Console.WriteLine("Double Value is :"+b);//implicit convert from integer to double 
	}
} 