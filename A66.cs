// Collection - Stack 
using System;
using System.Collections;
class A66
{
	public static void Main(string []args)
	{
		Stack s1=new Stack();	
		s1.Push(10);
		s1.Push(20);
		s1.Push(30);
		s1.Push(40);
		s1.Push(50);
		
		foreach(int i in s1)
		{
			Console.WriteLine("Value is :"+i)	;
		}
		Console.WriteLine("--------------------------------------");
		Console.WriteLine("AFTER REMOVE VALUE ");
		Console.WriteLine("--------------------------------------");	
		s1.Pop();
		foreach(int i in s1)
		{	
			Console.WriteLine("Value is :"+i);
		}	
	}
}