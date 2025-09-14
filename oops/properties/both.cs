class collection
{
	private object []x;
	public collection(int ndx)
	{
		x=new object[ndx];
	}
	public collection()
	{
		x=new object[10];
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
				product p = x[i] as product;
				
                		if (p != null && p.Pid == ndx)
                		{
					
                  	  		return x[i];
               			}
			}
			for(int i=0;i<count;i++)
			{ 
				employee p = x[i] as employee;
				
                		if (p != null && p.Eid == ndx)
                		{
					
                  	  		return x[i];
               			}
			}
			return null;
		}
}
	public object this[string ndx]
	{
		
		get
		{
			for(int i=0;i<count;i++)
			{ 
				product p = x[i] as product;
				
                		if (p != null && p.Pname.Equals(ndx))
                		{
					
                  	  		return x[i];
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
		list l=new list();
		product p1=new product();
		employee e=new employee();
		p1.read();
		e.read();
		l.items.add(p1);
		l.items.add(e);
	
		System.Console.WriteLine(l.items[1]);
	}
}
class product
{
	private int pid;
	private string pname;
	private double price;
	public int Pid
    	{
        	get { return pid; }
        	set { pid = value; }
    	}

    	public string Pname
    	{
    	    	get { return pname; }
    	    	set { pname = value; }
    	}

    	public double Price
    	{
        	get { 
			return price;
		}
        	set { price = value; }
    	}
	public void read()
	{
		pid=int.Parse(System.Console.ReadLine());
		pname=System.Console.ReadLine();
		price=double.Parse(System.Console.ReadLine());
	}
	public void print()
	{
		System.Console.WriteLine("{0} {1} {2}",pid,pname,price);
	}
}

class employee
{
	private int eid;
	private string ename;
	private double salary;
	public int Eid
    	{
        	get { return eid; }
        	set { eid = value; }
    	}

    	public string Ename
    	{
    	    	get { return ename; }
    	    	set { ename = value; }
    	}

    	public double Salary
    	{
        	get { 
			return salary;
		}
        	set { salary = value; }
    	}
	public void read()
	{
		eid=int.Parse(System.Console.ReadLine());
		ename=System.Console.ReadLine();
		salary=double.Parse(System.Console.ReadLine());
	}
	public void print()
	{
		System.Console.WriteLine("{0} {1} {2}",eid,ename,salary);
	}
}

