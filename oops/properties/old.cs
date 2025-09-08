class student
{
	private int sid;
	private string sname;
	public void set_id(int value)
	{
		sid=value;
	}
	public int get_id()
	{
		return sid;
	}
	public void set_sname(string value)
	{
		sname=value;
	}
	public string get_sname()
	{
		return sname;
	}
}
class program
{
	public static void Main()
	{
		student s=new student();
		s.set_id(1001);
		s.set_sname("ravi");
		System.Console.WriteLine("{0} {1} ",s.get_id(),s.get_sname());
	}
}

/* this is the output of this program
1001 ravi
*/
