//Inner class  static 
using System;
class A
{
	public static int a=10;
	public  class  B
	{
		public   void disp()
		{
			Console.WriteLine("Value of A is :"+a);
		}
	}
}
class A58
{
	public static void Main(string []args)
	{
		A.B b1=new A.B();
		b1.disp();
	}
}