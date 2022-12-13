//foreach  loop 
using System;
class A25
{
	public static void Main(string[]args)
	{
		String[]nm={"A","B","C","D","E"};
		Console.WriteLine("Using For loop");
			
		for(int i=0;i<nm.Length;i++)
		{
			Console.WriteLine("Name is :"+nm[i]);
		}
		
		Console.WriteLine("Using foreach Loop");
		
		foreach(String s1 in nm)
		{
			Console.WriteLine("Name is :"+s1);
		}
	}
}