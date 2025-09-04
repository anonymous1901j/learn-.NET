class program
{
	public static void Main()
	{
		int i;
		int []a;
		a=new int[5];
		for(i=0;i<5;i++)
		{
			a[i]=int.Parse(System.Console.ReadLine());
		}
		for(i=0;i<5;i++)
		{
			System.Console.WriteLine(a[i]);
		}
	}
}
