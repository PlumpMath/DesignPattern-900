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
class Department
{
	//同上
}

interface IUser
{
	void Insert(User user);
	User GetUser(int id);
}
interface IDepartment
{
	void Insert(Department department);
	Department GetDepartment(int id);
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
class SqlserverDepartment: IDepartment
{
	
}
class AccessDepartment: IDepartment
{
	
}

interface IFactory
{
	Iuser CreatUser();
	IDepartment CreateDepartment();
}

class SqlserverFactory: IFactory
{
	public IUser CreatUser()
	{
		return new SqlserverUser();
	}
	public IDepartment CreateDepartment()
	{
		···
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
	Department dept=new Department();
	
	IFactory factory=new SqlserverFactory();
	Iuser iu=factory.CreatUser();
	IDepartment id=factory.CreateDepartment();
	
	iu.Insert(user);
	iu.GetUser(1);
	
	id.Insert(dept);
	id.GetDepartment(2);
}