//Unary  operator overload
using System;
class Abc
{
	int a,b;
	public Abc(){}
	
	public Abc(int i,int j)
	{
		a=i;
		b=j;
	}
	public static Abc operator ++(Abc a1)
	{
		Abc temp = new Abc();
		temp.a= a1.a+100;
		temp.b=a1.b+100;
		return temp;	
	}
	public void disp()
	{
		Console.WriteLine("value of A is :"+a);
		Console.WriteLine("Vlue of B is :"+b);
	}
}
class A36
{
	public static void Main(string []args)
	{
		Abc a1=new Abc (10,20);
		a1.disp();
		Abc a2=++a1;
		a2.disp();
		Abc a3=++a2;
		a3.disp();
	}
}