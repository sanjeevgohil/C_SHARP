//Multilevel  Inheritance 
using System;
class A
{
	public void dispA()
	{
		Console.WriteLine("Class A");
	}
}
class B :A
{
	
	public void dispB()
	{
		Console.WriteLine("Class B");
	}
}
class C :B
{
	public void display()
	{
		Console.WriteLine("Class C ");
	}
}
class A45
{
	public static void Main(string []args)
	{
		C c1=new C();
		c1.dispA();
		c1.dispB();
		c1.display();
	}
}