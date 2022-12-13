//Event delegate
//Example is Investing money 
using System;
public delegate void EHandler();
class Abc
{
	public event EHandler temp;
	public void dispAbc()
	{
		if(temp!=null)
		{
			temp();
		}
	}
}
class A
{
	public void dispA()
	{
		Console.WriteLine("Class A Receive Event");
	}
}
class B
{
	public void dispB()
	{
		Console.WriteLine("Class B Receive Event ");
	}
}
class A62
{
	static public void dispMain()
	{
		Console.WriteLine("Main class Receive Event ");
	}
	public static void Main(string []args)
	{
		Abc abc1=new Abc();
		A a1=new A();
		B b1=new B();
		
		abc1.temp+=dispMain; 
		abc1.temp+=a1.dispA;
		abc1.temp+=b1.dispB;
		
		abc1.dispAbc();	
	}
}
