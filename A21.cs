//one dimensional Array
using System;
class A21
{
	public static void Main(string[]args)
	{
		int[] a=new int[10];
		int i;
		
		for (i=0;i<=9;i++)
		{
			a[i]=i+1;
		}
		for(i=0;i<=9;i++)
		{
			Console.WriteLine("Number is :"+a[i]);
		}
	}
}