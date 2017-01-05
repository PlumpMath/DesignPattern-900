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
	private Resume(WorkExperience work) //�ṩClone�������õ�˽�й��캯�����Ա��¡������������������
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
		Console.WriteLine("��������: {0} {1}"��work.WorkDate,work.Company);
	}
	
	public Object Clone()
	{
		Resume obj=new Resume(this.work); //����˽�й��췽������¡������������������
		obj.name=this.name;
		obj.sex=this.sex;
		obj.age=this.age; //Ȼ��ֵ���ﵽ��ƶ���
		return obj;
	}
}

//�ͻ���:
static void Main(string[] args)
{
	Resume a=new Resume("����");
	a.SetPersonalInfo("��"��"29");
	a.SetWorkExperience("1998-2000","A��˾");
	
	Resume b=(Resume)a.Clone();
	b.SetWorkExperience("2001-2006","B��˾");
	
	Resume c=(Resume)a.Clone();
	c.SetPersonalInfo("��","25");
	
	a.Display();
	b.Display();
	c.Display();
	
	Console.Read();
}
/**************
ǳ��������ƣ�
�����ڶԶ���������õĸ����ϡ�
ǳ����ֻ�ǿ��������ñ������Ը��ƺ�Ķ�������û���ָ��֮ǰ������;
��ƻ����¹���һ�����ö���ʹ�ø��ƺ�Ķ��������ָ���µĵط���
**************/