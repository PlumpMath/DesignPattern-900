abstract class PersonBuilder
{
	protected Graphics g;
	protected Pen p;
	public PersonBuilder(Graphics g,Pen p)
	{
		this.g=g;
		this.p=p;
	}
	
	public abstract void BuildHead();
	public abstract void BuildBody();
	public abstract void BuildArmLeft();
	public abstract void BuildArmRight();
	public abstract void BuildLegLeft();
	public abstract void BuildLegRight();
}

class PersonThinBulider: PersonBuilder
{
	public PersonThinBulider(Graphics g,Pen p) : base(g,p)
	{}
	public override void BuildHead()
	{
		g.DrawEllipse(p,50,20,30,30);
	}
	public override void BuildBody()
	{
		g.DrawEllipse(p,60,50,10,50);
	}
	public override void BuildArmLeft()
	{
		g.DrawEllipse(p,60,50,40,100);
	}
	public override void BuildArmRight()
	{
		g.DrawEllipse(p,70,50,80,100);
	}
	public override void BuildLegLeft()
	{
		g.DrawEllipse(p,60,100,40,80);
	}
	public override void BuildLegRight()
	{
		g.DrawEllipse(p,50,20,30,30);
	}
}

class PersonDirector
{
	private PersonBuilder pb;
	public PersonDirector(PersonBuilder pb)
	{
		this.pb=pb;
	}
	public void CreatePerson()
	{
		pb.BuildHead();
		pb.BuildBody();
		pb.BuildArmLeft();
		pb.BuildArmRight();
		pb.BuildLegLeft();
		pb.BuildLegRight();
	}
}

//�ͻ���
Pen p=new Pen(Color.Yellow);
Graphics g=new pictureBox1.CreateGraphics();
PersonThinBuilder ptb=new PersonThinBuilder(g,p);
PersonDirector pdThin=new PersonDirector(ptb);
pdThin.CreatePerson();

//��������ͬ��

/****************
���ڴ����ϸ��ӵĶ�����Щ�����ڲ�������Ľ���˳�����ȶ��ģ��������ڲ��Ĺ���ͨ�����ٸ��ӵı仯��
****************/