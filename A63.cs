//Nested Class  non Static 
using System;
class A
{
	public  int a;
	public void input(int i)
	{
		a=i;
	}
	public void disp()		
	{
		b1.disp1(a);
	}
	class B
	{
		public void disp1(int a)
		{
			Console.WriteLine("Value of A is :"+a);
		}
	}
	B b1=new B();
}
class A63
{
	public static void Main(string[]args)
	{
		A a1=new A();
		a1.input(10);
		a1.disp();
	}
}