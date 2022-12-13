//Static Method and Static member
using System;
class Abc
{
	static int a=10;
	static int b=20;
	public static int sum()
	{
		return a + b;
	}
}
class A31
{
	public static void Main(string []args)
	{
		Console.WriteLine("Answer is :"+Abc.sum());
	}
}