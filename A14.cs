//input all data types 
using System;
class A14
{
	public static void Main(string []args)
	{
		bool ans =false;
	
		Console.Write("Enter Integer Number :");
		int a=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter Double :");
		double b=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter String :");
		String nm=Console.ReadLine();
		Console.Write("Enter Character :");
		char c=Console.ReadLine()[0];
		Console.Write("Preass Y to Continue :");
		char d=Console.ReadKey().KeyChar;
		
		if (d=='Y' || d=='y')
		{
			ans =true;
		}
		
		Console.WriteLine("\n OUTPUT \n");
		Console.WriteLine("Integer is :{0}",a);
		Console.WriteLine("Double is :{0}",b);
		Console.WriteLine("String is :{0}",nm);
		Console.WriteLine("Character is :{0}",c);
		Console.WriteLine("Another Character is :{0}",d);
		Console.WriteLine("Boolean is :{0}",ans);
	}
}