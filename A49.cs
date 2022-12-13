//interface inheritance 
interface A
{
	void disp1();
	void disp2();
}
interface B : A
{
	void disp3();	
}

class C : B
{
	public void disp1()
	{
		Console.WriteLine("Disp 1 ");
	}
	public void disp2()
	{
		Console.WriteLine("Disp 2 ");
	}
	public void disp3()
	{
		Console.WriteLine("Disp  3 ");
	}
}
class D : A
{
	public void disp1()
	{
		Console.WriteLine("Disp 1 ");
	}
	public void disp2()
	{
		Console.WriteLine("Disp 2 ");
	}
}
class A49
{
	public static void Main(string []args)
	{
		C c1=new C();
		c1.disp1();
		c1.disp2();
		c1.disp3();

		D d1=new D();
		d1.disp1();
		d1.disp2();
	}
}