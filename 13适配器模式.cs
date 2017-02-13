//��Ա������
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

//ǰ�� 
class Forwards: Player
{
	public Forwards(string name):base(name)
	{}
	public override void Attack()
	{
		//����
	}
	public override void Defense()
	{
		//����
	}
}
//�з�
class Center: Player
{
	
}
//����
class Guards: Player
{
	
}

//�ͻ���
static void Main(string[] args)
{
	Player b=new Forwards("AA");
	b.Attack();
	Player m=new Guards("BB");
	m.Attack();
	
	Player ym=new Center("CC");
	ym.Attack(); //ym������Ӣ����Բ�֪������ôִ�У��������Ҫһ�����룬��������
	ym.Defense();
}

/*******************���뷭��(������)****************/
//�⼮��Ա
class ForeignCenter
{
	private string name;
	public string Name
	{
		get{return name;}
		set{name=value;}
	}
	public void ����()
	{
		//����
	}
	public void ����()
	{
		//����
	}
}
//����
class Translator: Player
{
	private ForeignCenter wjzf=new ForeignCenter();
	public Translator(string name):base(name)
	{
		wjzf.Name=name;
	}
	public override void Attack()
	{
		wjzf.����();
	}
	public override void Defense()
	{
		wjzf.����();
	}
}
//�ͻ���
static void Main(string[] args)
{
	Player ym=new Translator("CC");
	ym.Attack();
	ym.Defense();
}

}