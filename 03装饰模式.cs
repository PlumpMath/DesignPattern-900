class Person
{
	public Person()
	{}
	
	private string name;
	public Person(string name)
	{
		this.name=name;
	}
	
	public virtual void Show()  //��virtual�����಻�Ǳ�����дʵ��������ʾ��һ���ᱻװ�Ρ�
	{
		Console.WriteLine("װ���{0}",name);
	}
}

class Finery: Person
{
	protected Person component;
	
	//���
	public void Decorate(Person component)
	{
		this.component=component;
	}
	
	public override void Show()
	{
		if(component!=null)
		{
			component.Show();
		}
	}
}

class Tshirts: Finery
{
	public override void Show()
	{
		Console.Write("��T��");
		base.show();
		//base���õ��Ǹ��࣬��Finery���Show()����������Show()����⵱ǰʵ��componentָ�����Ի�������һ��ʵ�������Show()��		
	}
}

class BigTrouser: Finery
{
	public override void Show()
	{
		Console.Write("���");
		base.Show();
	}
}
//��������ƣ�ʡ��

//�ͻ��˴���:
static void Main(string[] args)
{
	Person xc=new Person("С��");
	Console.WriteLine("\n ��һ��װ�磺");
	
	Sneakers pqx=new Sneakers();
	BigTrouser kk=new BigTrouser();
	Tshirts dtx=new Tshirts();
	
	//װ�ι���
	pqx.Decorate(xc);
	kk.Decorate(pqx);
	dtx.Decorate(kk);
	dtx.Show();
}