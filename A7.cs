//input n Number 
using System;
class A7
{
	public static void Main(string []args)
	{
		int no,i,tot=0;
		no=Convert.ToInt32(args.Length);

		for(i=0;i<no;i++)
		{
			Console.WriteLine("Number is :" +args[i]);
			tot=tot +Convert.ToInt32(args[i]);
		}
		Console.WriteLine("Total is :"+tot);
	}
}