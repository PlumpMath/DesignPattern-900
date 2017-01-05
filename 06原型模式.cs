class WorkExperience: ICloneable
{
	private string workDate;
	public string WorkDate
	{
		get{return workDate;}
		set{workDate=value;}
	}
	private string company;
	public string Company
	{
		get{return company;}
		set{company=value;}
	}
	public Object Clone()
	{
		return (Object)this.MemberwiseClone();
	}
}

class Resume: ICloneable
{
	private string name;
	private string sex;
	private string age;
	private WorkExperience work;
	
	public Resume(string name)
	{
		this.name=name;
		work=new WorkExperience();
	}
	private Resume(WorkExperience work) //提供Clone方法调用的私有构造函数，以便克隆“工作经历”的数据
	{
		this work=(WorkExperience)work.Clone();
	}
	
	public SetPersonalInfo(string sex,string age)
	{
		this.sex=sex;
		this.age=age;
	}
	public void SetWorkExperience(string workDate,string company)
	{
		work.WorkDate=workDate;
		work.Company=company;
	}
	public void Display()
	{
		Console.WriteLine("{0} {1} {2}",name,sex,age);
		Console.WriteLine("工作经历: {0} {1}"，work.WorkDate,work.Company);
	}
	
	public Object Clone()
	{
		Resume obj=new Resume(this.work); //调用私有构造方法，克隆工作经历并创建对象
		obj.name=this.name;
		obj.sex=this.sex;
		obj.age=this.age; //然后赋值，达到深复制对象
		return obj;
	}
}

//客户端:
static void Main(string[] args)
{
	Resume a=new Resume("大鸟");
	a.SetPersonalInfo("男"，"29");
	a.SetWorkExperience("1998-2000","A公司");
	
	Resume b=(Resume)a.Clone();
	b.SetWorkExperience("2001-2006","B公司");
	
	Resume c=(Resume)a.Clone();
	c.SetPersonalInfo("男","25");
	
	a.Display();
	b.Display();
	c.Display();
	
	Console.Read();
}
/**************
浅复制与深复制：
区别在对对象里的引用的复制上。
浅复制只是拷贝了引用本身，所以复制后的对象的引用还是指向之前的引用;
深复制会重新构建一个引用对象，使得复制后的对象的引用指向新的地方。
**************/