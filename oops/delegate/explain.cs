
	delegate void mydelegate();
	class student
	{
		private int id;
		private string name;
		
		public void read()
		{
			id=int.Parse(System.Console.ReadLine());
			name=System.Console.ReadLine();
		}
		
		public void print()
		{
			System.Console.WriteLine("{0} {1}",id,name);
		}
		public static void Main()
		{
		student []s;
		mydelegate  md=null;
		s=new student[5];
		for(int i=0;i<s.Length;i++)
		{
			s[i]=new student();
			md+=new mydelegate(s[i].read);
		}
		for(int i=0;i<s.Length;i++)
		{
			md+=new mydelegate(s[i].print);
		}
		md();
	}
}

