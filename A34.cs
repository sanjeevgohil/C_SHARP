//method with out parameter
using System;
class A34
{
	public static  void Swapping(out int a,out  int b,int c,int d)
	{
		int temp;
		temp=c;
		c=d;
		d=temp;
		a=c;
		b=d;	
	}
	public static void Main(string []args)
	{
		int a=10,b=20;
		Console.WriteLine("Before Swap ");
		Console.WriteLine("Value of A is :"+a);
		Console.WriteLine("Value of B is :"+b);

		Swapping(out a,out b,a,b);

		Console.WriteLine("After Swap ");
		Console.WriteLine("Value of A is :"+a);
		Console.WriteLine("Value of B is :"+b);

		
	}
}