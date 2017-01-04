class Person
{
	public Person()
	{}
	
	private string name;
	public Person(string name)
	{
		this.name=name;
	}
	
	public virtual void Show()  //用virtual，子类不是必须重写实现它，表示不一定会被装饰。
	{
		Console.WriteLine("装扮的{0}",name);
	}
}

class Finery: Person
{
	protected Person component;
	
	//打扮
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
		Console.Write("大T恤");
		base.show();
		//base调用的是父类，即Finery类的Show()方法，父类Show()里会检测当前实例component指向，所以会跳到另一个实例里，继续Show()。		
	}
}

class BigTrouser: Finery
{
	public override void Show()
	{
		Console.Write("垮裤");
		base.Show();
	}
}
//其余的类似，省略

//客户端代码:
static void Main(string[] args)
{
	Person xc=new Person("小菜");
	Console.WriteLine("\n 第一种装扮：");
	
	Sneakers pqx=new Sneakers();
	BigTrouser kk=new BigTrouser();
	Tshirts dtx=new Tshirts();
	
	//装饰过程
	pqx.Decorate(xc);
	kk.Decorate(pqx);
	dtx.Decorate(kk);
	dtx.Show();
}