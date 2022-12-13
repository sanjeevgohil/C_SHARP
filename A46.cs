//Hierarchical  Inheritance 
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
		Console.WriteLine("Class B");
	}
}
class C : A
{
	public void display()
	{
		Console.WriteLine("Class C ");
	}
}
class A46
{
	public static void Main(string []args)
	{
		B b1=new B();
		b1.dispA();
		b1.dispB();
		C c1=new C();
		b1.dispA();
		c1.display();
	}
}