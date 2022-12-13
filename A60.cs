//creating and using single delegate 
/*NOTE 1 :- It call pointer to Function
NOTE 2:-It retrun value */ 
using System;
public delegate double Arith(double i,double j);
class A60
{
	static double add(double i,double j)
	{
		return i+j;	
	}
	static double multi(double i ,double j)
	{
		return i*j;
	}
	public static void Main(string[]args)
	{
		Arith a1=new Arith(add);
		Arith a2=new Arith(multi);
		
		Console.WriteLine("Addition is :"+a1(10,20));
		Console.WriteLine("Multipaltion is :"+a2(10,20));
	}
}
