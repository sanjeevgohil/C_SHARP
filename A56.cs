//creating user define function and pass  pointer 
using System;
class A56
{
	unsafe public static void swap(int *i,int *j)
	{
		int k=*i;
		*i=*j;
		*j=k;
	}
	unsafe public static void Main(string[]args)
	{
		int a=10,b=20;	

		Console.WriteLine("Befor Swap ");
		Console.WriteLine("Value of A  is :"+a);
		Console.WriteLine("Value of A is :"+b);
		
		swap(&a,&b);
		
		Console.WriteLine(" After  Swap ");
		Console.WriteLine("Value of A  is :"+a);
		Console.WriteLine("Value of A is :"+b);
	}
}