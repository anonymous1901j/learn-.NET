delegate int mydelegate(int x,int y);
class math
{
	public int sum(int x,int y)
	{
		return(x+y);
	}
	public int mult(int x,int y)
	{
		return(x*y);
	}
}
class program
{
	public static void Main()
	{
		math m=new math();
		mydelegate md=new mydelegate(m.sum);
		System.Console.WriteLine(md(100,200));
		md=new mydelegate(m.mult);
		System.Console.WriteLine(md(20,2));
	}
}
// the ouput of this program is
300
40
//
