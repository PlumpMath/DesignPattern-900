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

class Secretary: ISubject //����֪ͨ���ϰ�֪ͨ��������
{
	private IList<Observer> observers=new IList<Observer>();
	private string action;
	public void Attach(Observer observer)
	{
		observers.Add(observer)��
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

//����۲���
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
		Console.WriteLine("����Ʊ�Ĺص��Ըɻ�");
	}
}
class NBAObserver: Observer
{

	public NBAObserver(string name,Secretary sub) : base(name,sub)
	{

	}
	public override void Update()
	{
		Console.WriteLine("��NBA�Ĺص��Ըɻ�");
	}
}

//�ͻ��ˣ�
Secretary tongzizhe=new Secretary();
StockObserver no1=new StockObserver("wy",tongzizhe);
NBAObserver no2=new NBAObserver("zy",tongzizhe);

tongzizhe.Attach(no1);
tongzizhe.Attach(no2);
tongzizhe.SubjectState="�ϰ�����ˣ�";
tongzizhe.Notify();

Console.Read();

//���͵�һ�Զ࣬�����뷢����ģʽ��