//Interface 
using System;
interface A
{
	 void disp();
	void disp1();
}
class B : A
{
	public void disp()
	{
		Console.WriteLine("Class A");
	}
	public void disp1()
	{
		Console.WriteLine("Class B");
	}
}
class A42
{
	public static void Main(string []args)
	{
		B b1=new B();
		b1.disp();
		b1.disp1();
	}
}