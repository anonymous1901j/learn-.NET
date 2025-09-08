class student 
{
	private int sid;
	private string sname;
	public int Sid
	{
		set
		{
			sid=value;
		}
		get
		{
			return(sid);
		}
	}
	public string Sname
	{
		set
		{
			sname=value;
		}
		get
		{
			return(sname);
		}
	}
}
class program
{
	public static void Main()
	{
		student s=new student();
		s.Sid=1001;
		s.Sname="ravi";
		System.Console.WriteLine("{0} {1}",s.Sid,s.Sname);
	}
}

/* this is the output of the program
1001 ravi
*/
