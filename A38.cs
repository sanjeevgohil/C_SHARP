//inheritance using setval & get Function 
using System;
class A
{
	public int a;
	int b;
	public void setval(int i,int j)
	{
		a=i;
		b=j;
	}
	public int getb()
	{
		return b;
	}
}
class B : A
{
	public void sum()
	{
		Console.WriteLine("Answer is :"+(a+getb()));
	}
}
class A38
{
	public static void Main(string []args)
	{
		B b1=new B();
		b1.setval(10,20);
		b1.sum();
	}	
}