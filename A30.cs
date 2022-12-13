//overload Method 
using System;
class Abc
{
	public int sum(int a)
	{
		return a+a;
	}
	public int sum (int a,int b)
	{
		return a+b;
	}
	public int sum (int a,int b,int c)
	{
		return a+b+c;
	}
}
class A30
{
	public static void Main(string []args)
	{
		Abc a1=new Abc();
		int ans;
		ans =a1.sum(10);
		Console.WriteLine("Answer is :"+ans);
		ans =a1.sum(10,20);
		Console.WriteLine("Answer is :"+ans);
		ans =a1.sum(10,20,30);
		Console.WriteLine("Answer is :"+ans);
		
	}
}