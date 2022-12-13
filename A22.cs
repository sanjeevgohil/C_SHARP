//two dimensional Array
using System;
class A22
{
	public static void Main(string[]args)
	{
		int [,] a=new int[3,3];
		int i,j;
		
		for (i=0;i<=2;i++)
		{
			for(j=0;j<=2;j++)
			{
				a[i,j]=i+1;
			}
		}
		for(i=0;i<=2;i++)
		{
			for(j=0;j<=2;j++)
			{
				Console.Write(" "+a[i,j]);
			}
			Console.WriteLine();
		}
	}
}