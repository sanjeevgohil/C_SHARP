//Overriding Method 
using System;
abstract class intrest
{
	public abstract int intrate();
	public void disp()
	{
		Console.WriteLine("Welcome ");
	}
}
class SBI : intrest 
{
	public  override int  intrate()
	{
		return 7;
	}
}
class BOB : intrest
{
	public override  int intrate()
	{
		return 8;
	}
}
class A57
{
	public static void Main(string[]args)
	{
		intrest i1;
		i1=new SBI ();
		Console.WriteLine("Rate of Intrest is :"+i1.intrate());
		i1=new BOB();
		Console.WriteLine("Rate of Intrest is :"+i1.intrate());
	}
}