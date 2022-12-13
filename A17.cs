//explicit type casting
using System;
class A17
{
	public static void Main(string []args)
	{
		int a=12345;
		double b=a;
		int c=(int)b;
		
		Console.WriteLine("Integer value is :"+a);
		Console.WriteLine("Double Value is :"+b);//implicit convert from integer to double 
		Console.WriteLine("C Value is :"+c);//explicit
	}
} 