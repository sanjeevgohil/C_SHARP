//paramerized constructor 
using System;
class Abc
{
	int a;
	public Abc(int i)
	{
		a=i;
	}
	public void  disp()
	{
		Console.WriteLine("Value of A is :"+a);
	}
}
class A28
{
	public static void Main(string []args)
	{
		Abc a1=new Abc(10);
		a1.disp();
	}
}