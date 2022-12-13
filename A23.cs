//jagged array static
using System;
class A23
{
	public static void Main(string []args)
	{
		int [][]a=new int[3][];
		a[0]=new int[5];
		a[1]=new int[8];
		a[2]=new int[3];
		int i,j,k;
		
		for(i=0;i<a.Length;i++)
		{
			for(j=0,k=0;j<a[i].Length;j++,k++)
			{
				a[i][j]=k;
			}
		}
		for(i=0;i<a.Length;i++)
		{
			for(j=0;j<a[i].Length;j++)
			{
				Console.Write(" "+a[i][j]);
			}
			Console.WriteLine();
		}
	}
} 