//Boxing and UnBoxing 
using System;
class A18
{
	public static void Main(string []args)
	{
		object ans=45;
		int a;
		a=Convert.ToInt32(ans);//UnBoxing 
		Console.WriteLine("Value of A is :"+a);
		
		String nm="Ruparel";
		object temp;
		temp=nm;//Boxing 
		Console.WriteLine("Value of Temp is :"+temp);
	}
}