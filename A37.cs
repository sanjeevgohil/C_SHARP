//Single Inheritance 
using System;
class A
{
	public void dispA()
	{
		Console.WriteLine("Class A");
	}
}
class B : A
{
	public void dispB()
	{
		Console.WriteLine("Class B ");
	}
}
class A37
{
	public static void Main(string[]args)
	{
		B b1=new B();
		b1.dispA();
		b1.dispB();
	}
}