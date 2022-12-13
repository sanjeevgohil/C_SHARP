//creating and using property using Constructor 
using System;
class Emp
{
	private int eid;
	private string ename;

	public Emp()
	{
		eid=1;
		ename="Mukesh";
	}
	public Emp(int id ,string nm)
	{
		eid=id;
		ename=nm;
	}
	public int Empid
	{
		get{return eid;}//read only
	}
	public string EmpName
	{
		get{return ename;}
	}
}
class A52
{
	public static void Main(string []args)
	{
		Emp e1=new Emp();
		Emp e2=new Emp(101,"Mukesh");

		Console.WriteLine("Employee id is :{0} and Employee Name is :{1} ",e1.Empid,e1.EmpName);	
		Console.WriteLine("Employee id is :{0} and Employee Name is :{1} ",e2.Empid,e2.EmpName);
	}
}