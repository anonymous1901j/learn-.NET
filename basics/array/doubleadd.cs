class program
{
	public static void Main()
	{
		int [,]a=new int[2,2];
		int [,]b=new int[2,2];
		int [,]c=new int[2,2];
		int i,j;
		for(i=0;i<a.GetLength(0);i++)
		{
		for(j=0;j<a.GetLength(1);j++)
		{
			a[i,j]=int.Parse(System.Console.ReadLine());
		}
		}
		for(i=0;i<a.GetLength(0);i++)
		{
		for(j=0;j<a.GetLength(1);j++)
		{
			b[i,j]=int.Parse(System.Console.ReadLine());
		}
		}
		for(i=0;i<a.GetLength(0);i++)
		{
		for(j=0;j<a.GetLength(1);j++)
		{
			c[i,j]=a[i,j]+b[i,j];
		}
		}

		for(i=0;i<a.GetLength(0);i++)
		{
		for(j=0;j<a.GetLength(1);j++)
		{
			System.Console.Write(c[i,j]);
		}
		System.Console.WriteLine();
		}
	}
}
