class collection
{
	private object []x;
	public collection(int ndx)
	{
		x=new object[ndx];
	}
	public void add(object value)
	{
		x[count++]=value;
	}
	public int count{get;set;}
	public object this[int ndx]
	{
		
		get
		{
			for(int i=0;i<count;i++)
			{
				if(ndx==(int)x[i])
				{
					return i;
				}
			}
			return null;
		}
		
	}
}
class list
{
	private collection c;
	public list(int size)
	{
		c=new collection(size);
	}
	public list()
	{	
		c=new collection(10);
	}
	public collection items
	{
		get
		{
			return (c);
		}
	}
}
class program
{
	public static void Main()
	{
		object pos;
		list l=new list();
		l.items.add(100);
		l.items.add(200);
		l.items.add(300);
		l.items.add(400);
		pos=l.items[300];
		System.Console.WriteLine(pos);
	}
}

/*the out.put of this program is
  100
  200
  300
  400
  2
  */
