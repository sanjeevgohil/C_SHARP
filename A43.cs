//Multiple Inheritance using Interface 
using System;
interface A
{
	void disp1();
	void disp2();	
}
class B 
{
	public void display()
	{
		Console.WriteLine("class A ");
	}
	public void disp1()
	{
		Console.WriteLine("disp 1 ");
	}
	public void disp2()
	{
		Console.WriteLine("disp 2");
	}
}
class C : B , A 
{
	public void dispC()
	{
		Console.WriteLine("class C");
	}
}
class A43
{
	public static void Main(string []args)
	{
		C c1=new C();
		c1.display();
		c1.disp1();
		c1.disp2();
		c1.dispC();
	}
}