class employee
{
	public int Eid{get;set;}
	public string Ename{get;set;}
}
class program
{
	public static void Main()
	{
	employee e=new employee();
	e.Eid=1001;
	e.Ename="shiva";
	System.Console.WriteLine("{0} {1}",e.Eid,e.Ename);
	}
}
/* this is the output of this program
1001  shiva
*/
