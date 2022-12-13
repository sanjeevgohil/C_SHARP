//creating and using property 
using System;
class A
{
	private int a;
	public int x
	{
		get
		{
			return a;
		}
		set 
		{
			a=value;
		}
	}
}
class A50
{
	public static void Main(string []args)
	{
		A a1=new A();
		A a2=new A();
		A a3=new A();
		
		a1.x=10;
		a2.x=20;
		a3.x=30;
	
		Console.WriteLine("Value of A is :"+a1.x);
		Console.WriteLine("Value of A is :"+a2.x);
		Console.WriteLine("Value of A is :"+a3.x);
	}
}