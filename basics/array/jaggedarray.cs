class program
{
	public static void Main()
	{
		int i,j;
		int [][]x;
		x=new int[3][];
		x[0]=new int[1];
		x[1]=new int[2];
		x[2]=new int[3];
		for(i=0;i<x.Length;i++)
		{
		for(j=0;j<x[i].Length;j++)
		{
			x[i][j]=int.Parse(System.Console.ReadLine());
		}
		}
		for(i=0;i<x.Length;i++)
		{
		for(j=0;j<x[i].Length;j++)
		{
			System.Console.Write(x[i][j]);
		}
		System.Console.WriteLine();
		}
	}
}
