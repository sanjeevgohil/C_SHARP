//Collection - Sorted List     
using System;
using System.Collections;
class A68
{
	public static void Main(string []args)
	{
		SortedList s1=new SortedList();
		s1.Add("1","Sunday");
		s1.Add("2","Monday");
		s1.Add("3","Tuesday");
		s1.Add("4","Wednesday");
		s1.Add("5","Thursday");
		s1.Add("6","Friday");
		s1.Add("7","Saturday");
		
		for(int i=0;i<s1.Count;i++)
		{
			Console.WriteLine(s1.GetKey(i) +"--->"+s1.GetByIndex(i));
		}
	}
}