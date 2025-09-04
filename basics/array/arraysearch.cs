class program
{
	public static void Main()
	{
		int i,search;
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
		search=int.Parse(System.Console.ReadLine());
		for(i=0;i<5;i++)
		{
			if(search==a[i])
			{
				System.Console.WriteLine(a[i]);
				break;
			}
			if(i==4)
			{
				System.Console.WriteLine("element not found");
			}
		}
	}
}
