//Enter Number and print total
using System;
class A4
{
	public static void Main(string[]args)
	{
		Console.Write("Enter First Number :");
		int a=Convert.ToInt32(Console.Read());
	
		Console.Write("Enter Second Number :");
		int b=Convert.ToInt32(Console.Read());

		int c=a+b;
		
		Console.Write("First Number is :"+a); 
		Console.Write("Second  Number is :"+b);
		Console.Write("Total is :"+c);  
	}
}