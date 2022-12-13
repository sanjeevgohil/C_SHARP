//Collection - ArrayList 
using System;
using System.Collections; //  Collection is a header file 
class A64
{
	public static void Main(string []args)
	{
		ArrayList a1=new ArrayList();
		a1.Add(10);
		a1.Add(20);
		a1.Add(30);
		a1.Add(40);
		a1.Add(50);
		
		Console.WriteLine("-----------------------------------------------");
		Console.WriteLine("ALL VALUE IS ");
		Console.WriteLine("-----------------------------------------------");
		foreach(int i in a1)
		{
			Console.WriteLine("Value is :"+i);
		}
		Console.WriteLine("-----------------------------------------------");
		Console.WriteLine("AFTER REMOVE  VALUE IS ");
		Console.WriteLine("-----------------------------------------------");

		a1.Remove(30);          //Value Remove
		foreach(int i in a1)
		{
			Console.WriteLine("Value is :"+i);
		}
		Console.WriteLine("-----------------------------------------------");
		Console.WriteLine("AFTER REMOVE  AND INSERT INDEX  VALUE IS ");
		Console.WriteLine("-----------------------------------------------");

		a1.RemoveAt(1);         //Index Remove 
		a1.Insert(1,30);            //Insert Index 
		foreach(int i in a1)
		{
			Console.WriteLine("Value is :"+i);
		}
		
		ArrayList a2=new ArrayList();
		a2.Add(60);
		a2.Add(70);
		a2.Add(80);
		a2.Add(90);
		a2.Add(100);
		
		a1.AddRange(a2);         //Merge Index 
		foreach(int i in a2)
		{
			Console.WriteLine("Value is :"+i);
		}
	}
}