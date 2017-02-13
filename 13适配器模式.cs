//球员抽象类
abstract class Player
{
	protected string name;
	public Player(string name)
	{
		this.name=name;
	}
	public abstract void Attack();
	public abstract void Defense();
}

//前锋 
class Forwards: Player
{
	public Forwards(string name):base(name)
	{}
	public override void Attack()
	{
		//进攻
	}
	public override void Defense()
	{
		//防守
	}
}
//中锋
class Center: Player
{
	
}
//后卫
class Guards: Player
{
	
}

//客户端
static void Main(string[] args)
{
	Player b=new Forwards("AA");
	b.Attack();
	Player m=new Guards("BB");
	m.Attack();
	
	Player ym=new Center("CC");
	ym.Attack(); //ym听不懂英语，所以不知道该怎么执行，这里就需要一个翻译，即适配器
	ym.Defense();
}

/*******************加入翻译(适配器)****************/
//外籍球员
class ForeignCenter
{
	private string name;
	public string Name
	{
		get{return name;}
		set{name=value;}
	}
	public void 进攻()
	{
		//进攻
	}
	public void 防守()
	{
		//防守
	}
}
//翻译
class Translator: Player
{
	private ForeignCenter wjzf=new ForeignCenter();
	public Translator(string name):base(name)
	{
		wjzf.Name=name;
	}
	public override void Attack()
	{
		wjzf.进攻();
	}
	public override void Defense()
	{
		wjzf.防守();
	}
}
//客户端
static void Main(string[] args)
{
	Player ym=new Translator("CC");
	ym.Attack();
	ym.Defense();
}

}