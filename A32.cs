using System;
class A32
{
	public static void Main(string []args)
	{
		try
		{
			int[] no=new int[3];
			Console.Write("Enter First Number :");
			int a=Convert.ToInt32(Console.ReadLine());
		
			Console.Write("Enter Second  Number: ");
			int b=Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Total is :" +(a/b));
			Console.WriteLine("value of no[3] is :"+no[3]);
		}
		catch(IndexOutOfRangeException e)
		{
			Console.WriteLine("Exception is :"+e);
		}
		catch(DivideByZeroException e)
		{
			Console.WriteLine("Exception is :"+e);
		}
		catch(Exception e)
		{
			Console.WriteLine("Exception is :"+e);
		}
		finally
		{
			Console.WriteLine("This is Finally Block ");
		}
	}
	
}