// Collection - Hash Table 
/*NOTE 1 :- Give Key and Value 
NOTE 2 :- Key Not Duplicate 
NOTE 3:- DictionaryEntry is a Namespace */
using System;
using System.Collections;
class A65
{
	public static void Main(string []args)
	{
		Hashtable h1=new Hashtable();
		h1.Add("1","Sunday");
		h1.Add("2","Monday");
		h1.Add("3","Tuesday");
		h1.Add("4","Wednesday");
		h1.Add("5","Thursday");
		h1.Add("6","Friday");
		h1.Add("7","Saturday");
		
		foreach(DictionaryEntry day in h1)
		{
			Console.WriteLine(day.Key +"------>"+day.Value);
		}
	}
}