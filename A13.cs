//output concatineted method 
using System;
class A13
{
	public static void Main(string []args)
	{
		int a,b,tot;
		Console.Write("Enter First Number :");
		a=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter Second Number :");
		b=Convert.ToInt32(Console.ReadLine());
		
		tot=a+b;
		
		Console.WriteLine("First Number is :"+a+"Second Number is :"+b+"Total is :"+tot);
		Console.WriteLine("First Number is :{0} Second Number is :{1} Total is :{2}",a,b,tot);
	}
}