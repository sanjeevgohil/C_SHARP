//switch case
using System;
class A26
{
	public static void Main(string[]args)
	{
		int a=10,b=5,ans=0;
		Console.Write("Enter 1->Addition \nEnter 2->Substration \nEnter 3->multiplation \nEnter 4->Division ");
		Console.Write("Enter Your Choise...");
		int ch=Convert.ToInt32(Console.ReadLine());
		
		switch(ch)
		{
			case 1:
				ans=a+b;
				break;
			case 2:
				ans=a-b;
				break;
			case 3:
				ans=a*b;
				break;
			case 4:
				ans=a/b;
				break;
			default :
				Console.WriteLine("Wrong Choise.....");
				break;
		}
		Console.WriteLine("Answer is :"+ans);
	}
}