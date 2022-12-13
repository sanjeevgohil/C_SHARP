//non-parameterized constructor 
using System;
class Abc
{
	int a;
	public Abc()
	{
		a=10;
	}
	 public void disp()
	{
		Console.WriteLine("Value of A is :"+a);
	}
}
class A27
{
	public static void Main(string []args)
	{
		Abc a1=new Abc();
		a1. disp();
	}
}
