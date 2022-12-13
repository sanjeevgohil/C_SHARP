//inheritance using Setval Function 
using System;
class A
{
	public int a,b;
	public void setval(int i,int j)
	{
		a=i;
		b=j;
	}
}
class B : A
{
	public void sum()
	{
		Console.WriteLine("Answer is :"+(a+b));
	}
}
class A40
{
	public static void Main(string []args)
	{
		B b1=new B();
		b1.setval(10,20);
		b1.sum();
	}	
}