//creating and using property using set and get 
using System;
class Emp
{
	int eid;
	string ename;
	public int Empid
	{
		get{return eid;}//read only
		set{eid =value;}//write  only
	}
	public string EmpName
	{
		get{return ename;}
		set{ename=value;}
	}
}
class A51
{
	public static void Main(string []args)
	{
		Emp e1=new Emp();

		e1.Empid=101;
		e1.EmpName="Mukesh";
	
		Console.WriteLine("Employee id is :{0} and Employee Name is :{1} ",e1.Empid,e1.EmpName);
	}
}