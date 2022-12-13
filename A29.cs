//overloading  constructor 
using System;
class Abc
{
	int a;
	char ch;
	public Abc()
	{
		a=10;
		ch='m';
	}
	
	public Abc(int i)
	{
		a=i;
		ch='M';
	}
	
	public Abc(int i,char c)
	{
		a=i;
		ch='c';
	}
	
	public Abc(char c,int i)
	{
		a=i;
		ch='c';
	}
	public void disp()
	{
		Console.WriteLine("Value of A is :"+a);
		Console.WriteLine("Value of CH is :"+ch);
	}
}
class A29
{
	public static void Main(string []args)
	{
		Abc a1=new Abc();
		Abc a2=new Abc(20);
		Abc a3=new Abc(20,'F');
		Abc a4=new Abc('Y',100);
		a1.disp();
		a2.disp();
		a3.disp();
		a4.disp();
	}
}