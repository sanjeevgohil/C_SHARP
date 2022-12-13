//jagged array dynamic
using System; 
class A24
{
	public static void Main(string []args)
	{
		int i,j,k,r,c;
		Console.Write("Enter Row-Size :");
		r=Convert.ToInt32(Console.ReadLine());
		int [][]a =new int[r][];
		
		for(i=0;i<a.Length;i++)
		{
			Console.Write("Enter "+(i+1)+" Row Column Size :");
			c=Convert.ToInt32(Console.ReadLine());
				a[i]=new int[c];
		}
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