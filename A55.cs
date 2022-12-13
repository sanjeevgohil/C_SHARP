//creating pointer unsafe block and multiple pointer declaration 
using System;
class A55
{
	public static void Main(string[]args)
	{
		unsafe
		{
			int* p,q;
			int a=10,b=20;
		
			p=&a;
			q=&b;	

			Console.WriteLine("Value of A  is :"+*p);
			Console.WriteLine("Value of A is :"+*q);
		}
	}
}
//NOTE 1:pointer variable declaration any way  int*p,q  and int *p,*q;
//NOTE 2 : complie time write unsafe keyword;