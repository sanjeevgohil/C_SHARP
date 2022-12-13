//creating pointer unsafe keyword 
using System;
class A54
{
	unsafe public static void Main(string[]args)
	{
		int a=10;
		int*p=&a;
		
		Console.WriteLine("Value of A  is :"+a);
		Console.WriteLine("Value of A is :"+*p);
	}
}
//NOTE : complie time write unsafe keyword 