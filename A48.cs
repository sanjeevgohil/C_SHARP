//Sealed Class 
using System;
sealed class A
{
	public void dispA()
	{
		Console.WriteLine("Disp A");
	}
	
}
class B
{
	public void dispB()
	{
		Console.WriteLine("Disp B ");
	}
}
class C :B
{
	public void dispC()
	{
		Console.WriteLine("Disp C");
	}
}
class A48
{
	public static void Main(string[]args)
	{
		A a1=new A();
		a1.dispA();
		C c1=new C();
		c1.dispB();
		c1.dispC();
	}
}