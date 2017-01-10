interface ISubject
{
	void Attach(Observer observer);
	void Detach(Observer observer);
	void Notify();
	string SubjectState
	{
		get;
		set;
	}
}

class Secretary: ISubject //秘书通知，老板通知代码类似
{
	private IList<Observer> observers=new IList<Observer>();
	private string action;
	public void Attach(Observer observer)
	{
		observers.Add(observer)；
	}
	public void Detach(Observer observer)
	{
		observer.Remove(observer);
	}
	public Notify()
	{
		foreach (o in observers)
		{
			o.Update();
		}
	}
	public string SubjectState
	{
		get {return action;}
		set {action=value;}
	}
}

//抽象观察类
abstract class Observer
{
	protected string name;
	protected ISubject sub;
	public Observer(string name,ISubject sub)
	{
		this.name=name;
		this.sub=sub;
	}
	public abstract void Update();
}

class StockObserver: Observer
{

	public StockObserver(string name,Secretary sub) : base(name,sub)
	{

	}
	public override void Update()
	{
		Console.WriteLine("看股票的关电脑干活");
	}
}
class NBAObserver: Observer
{

	public NBAObserver(string name,Secretary sub) : base(name,sub)
	{

	}
	public override void Update()
	{
		Console.WriteLine("看NBA的关电脑干活");
	}
}

//客户端：
Secretary tongzizhe=new Secretary();
StockObserver no1=new StockObserver("wy",tongzizhe);
NBAObserver no2=new NBAObserver("zy",tongzizhe);

tongzizhe.Attach(no1);
tongzizhe.Attach(no2);
tongzizhe.SubjectState="老板回来了！";
tongzizhe.Notify();

Console.Read();

//典型的一对多，订阅与发布的模式。