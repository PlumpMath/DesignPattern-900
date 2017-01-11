class User
{
	private int _id;
	private string _name;
	public int ID
	{
		get{return _id;}
		set{_id=value;0}
	}
	public string Name
	{
		get{return _name;}
		set{Name=value;}
	}
}

interface IUser
{
	void Insert(User user);
	User GetUser(int id);
}

class SqlserverUser: IUser
{
	public void Insert(User user)
	{
		···
	}
	public User GetUser(int id)
	{
		···
	}
}

class AccessUser: Iuser
{
	//同上
}

interface IFactory
{
	Iuser CreatUser();
}

class SqlserverFactory: IFactory
{
	public IUser CreatUser()
	{
		return new SqlserverUser();
	}
}
class AccessFactory: IFactory
{
	//同上
}

//客户端
static void Main(string[] args)
{
	User user=new User();
	
	IFactory factory=new SqlserverFactory();
	Iuser iu=factory.CreatUser();
	
	iu.Insert(user);
	iu.GetUser(1);
}