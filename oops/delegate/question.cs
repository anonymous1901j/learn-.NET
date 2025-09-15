delegate void mydelegate();
class student
{
	private int sid;
	private string sname;
	
	public void read()
	{
		sid=int.Parse(System.Console.ReadLine());
		sname=System.Console.ReadLine();
	}
	public void print()
	{
		System.Console.WriteLine("{0} {1} ",sid,sname);
	}
}
class program
{
	public static void Main()
	{
		student []s;
		mydelegate md=null;
		s=new student[5];
		for(int i=0;i<s.Length;i++)
		{
			s[i]=new student();
			md +=new mydelegate(s[i].read);
		}
		for(int i=0;i<s.Length;i++)
		{		
			md +=new mydelegate(s[i].print);
		}
		md();
	}
  // this is the output of this program
  1
shiva
2
gani
3
abhi
4
ravi
5
mitilesh
1 shiva
2 gani
3 abhi
4 ravi
5 mitilesh
  //
}
