interface IGiveGift  //实体与代理的共同接口
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
		Console.WriteLine(mm.name+"送你洋娃娃");
	}
	public void GiveFlowers()
	{
		Console.WriteLine(mm.name+"送你鲜花");
	}
	public void GiveChocolate()
	{
		Console.WriteLine(mm.name+"送你巧克力");
	}
}

class Proxy: IGiveGift
{
	Pursuit gg;  //代理实现一个对实体的入口
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

//以下是客户端程序
static void Main(string[] args)
{
	SchoolGirl jiaojiao=new SchoolGirl();
	jiaojiao.Name="李娇娇";
	
	Proxy daili_pursuit=new Proxy(jiaojiao);
	
	daili_pursuit.GiveDolls();
	daili_pursuit.GiveFlowers();
	daili_pursuit.GiveChocolate();
	
	Console.Read();
}