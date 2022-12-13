//Binary operator overload
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
	public static Abc operator +(Abc a1,Abc a2)
	{
		Abc temp = new Abc();
		temp.a= a1.a+a2.a;
		temp.b=a1.b+a2.b;
		return temp;	
	}
	public void disp()
	{
		Console.WriteLine("value of A is :"+a);
		Console.WriteLine("Vlue of B is :"+b);
	}
}
class A35
{
	public static void Main(string []args)
	{
		Abc a1=new Abc (10,20);
		Abc a2=new Abc (30,40);
		Abc a3=a1+a2;
		a1.disp();
		a2.disp();
		a3.disp();
	}
}