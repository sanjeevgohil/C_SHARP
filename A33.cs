//Ref Parameter Method 
using System;
class A33
{
	public static  void Swapping(ref int a,ref int b)
	{
		int c;
		c=a;
		a=b;
		b=c;	
	}
	public static void Main(string []args)
	{
		int a=10,b=20;
		Console.WriteLine("Before Swap ");
		Console.WriteLine("Value of A is :"+a);
		Console.WriteLine("Value of B is :"+b);

		Swapping(ref a,ref b);

		Console.WriteLine("After Swap ");
		Console.WriteLine("Value of A is :"+a);
		Console.WriteLine("Value of B is :"+b);

		
	}
}