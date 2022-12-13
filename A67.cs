// Collection - Queue  
using System;
using System.Collections;
class A67
{
	public static void Main(string []args)
	{
		Queue q1=new Queue();	
		q1.Enqueue(10);
		q1.Enqueue(20);
		q1.Enqueue(30);
		q1.Enqueue(40);
		q1.Enqueue(50);
		
		foreach(int i in q1)
		{
			Console.WriteLine("Value is :"+i)	;
		}
		Console.WriteLine("--------------------------------------");
		Console.WriteLine("AFTER REMOVE  VALUE ");
		Console.WriteLine("--------------------------------------");
		q1.Dequeue();
		foreach(int i in q1)
		{	
			Console.WriteLine("Value is :"+i);
		}	
	}
}