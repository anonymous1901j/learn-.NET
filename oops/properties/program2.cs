class Items
{
	private student []x;
	public Items()
	{
		x=new student[10];
	}
	public student this[int ndx]
	{
		set{
			x[ndx]=value;
		}
		get{
			return x[ndx];
		}
	}
}
class program
{
	public static void Main()
	{
		Items items;
		items=new Items();
		items[0]=100;
		items[1]=200;
		for(int i=0;i<2;i++)
		{
			items[i].print();
		}
	}
}
