//creating and using multicast delegate 
/*NOTE 1 :- It call pointer to Function
NOTE 2:-It not retrun value*/ 
using System;
public delegate void Arith(double i,double j);
class A61
{
	static void add(double i,double j)
	{
		Console.WriteLine("Addition is :"+(i+j));
	}
	static void multi(double i ,double j)
	{
		Console.WriteLine("Multiplication is :"+(i*j));
	}
	static void minus(double i ,double j)
	{
		Console.WriteLine("Minus is :"+(i-j));
	}
	public static void Main(string[]args)
	{
		Arith a1=new Arith(add);
		a1+=new Arith(multi);
		a1(10,20);
		Console.WriteLine("------------------------------");	
		a1+=new Arith(minus);
		a1(20,30);
		Console.WriteLine("------------------------------");
		a1-=new Arith(multi);
		a1(5,10);
	}
}
