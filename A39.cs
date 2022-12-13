//inheritance using with base keyword
using System;
class A 
{
	public int a;
	public A(int i)
	{
		a=i;
	}
}
class B :A
{
	private int b;
	public B(int i,int j): base(i)
	{
		b=j;
	}
	public void sum()
	{
		Console.WriteLine("Answer is :"+(a+b));
	}
}
class A39
{
	public static void Main(string []args)
	{
		B b1=new B(6,11);
		b1.sum();
	}
}