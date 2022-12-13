//Hybrid  Inheritance using Interface 
using System;
interface A
{
	double area(double r);
}
class B
{
	public void disp()
	{
		Console.WriteLine("Class B ");
	}
}
class C :  B ,A
{
	public double area(double r)
	{
		double a;
		a=3.14 * r *r ;
		return a;
	}
}
class D :C
{
	public void display()
	{
		Console.WriteLine("Class D ");
	}
}
class A44
{
	public static void Main(string []args)
	{
		D d1=new D();
		double ans=d1.area(5);
		Console.WriteLine("Area of Circle is :"+ans);
		d1.disp();
		d1.display();
	}
}