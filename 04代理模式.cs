interface IGiveGift  //ʵ�������Ĺ�ͬ�ӿ�
{
	void GiveDolls();
	void GiveFlowers();
	void GiveChocolate();
}

class SchoolGirl
{
	private string name;
	public string Name
	{
		get {return name;}
		set {name=Value;}
	}
}

class Pursuit: IGiveGift
{
	SchoolGirl mm;
	Public Pursuit(SchoolGirl mm)
	{
		this.mm=mm;
	}
	
	public void GiveDolls()
	{
		Console.WriteLine(mm.name+"����������");
	}
	public void GiveFlowers()
	{
		Console.WriteLine(mm.name+"�����ʻ�");
	}
	public void GiveChocolate()
	{
		Console.WriteLine(mm.name+"�����ɿ���");
	}
}

class Proxy: IGiveGift
{
	Pursuit gg;  //����ʵ��һ����ʵ������
	Public Proxy(SchoolGirl mm)
	{
		gg=new Pursuit(mm);
	}
	public void GiveDolls()
	{
		gg.GiveDolls();
	}
	public void GiveFlowers()
	{
		gg.GiveFlowers();
	}
	public void GiveChocolate()
	{
		gg.GiveChocolate();
	}
}

//�����ǿͻ��˳���
static void Main(string[] args)
{
	SchoolGirl jiaojiao=new SchoolGirl();
	jiaojiao.Name="���";
	
	Proxy daili_pursuit=new Proxy(jiaojiao);
	
	daili_pursuit.GiveDolls();
	daili_pursuit.GiveFlowers();
	daili_pursuit.GiveChocolate();
	
	Console.Read();
}