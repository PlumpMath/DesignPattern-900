class TestPaper
{
	public void TestQuestion1()
	{
		Console.WriteLine("���ǣ�A.1 B.2 C.3 D.4");
		Console.WriteLine("ѡ�� "+Answer1());
	}
	public void TestQuestion2()
	{
		Console.WriteLine("����: A.5 B.6 C.7 D.8");
		Console.WriteLine("ѡ�� "+Answer2());
	}
	public void TestQuestion3()
	{
		Console.WriteLine("���ǣ�A.1 B.3 C.5 D.7");
		Console.WriteLine("ѡ�� "+Answer3());
	}
	
	public virtual string Answer1()
	{return "";}
	public virtual string Answer2()
	{return "";}
	public virtual string Answer3()
	{return "";}
}

//ѧ���׵��Ծ�
class TestPaperA: TestPaper
{
	public string Answer1()
	{return "B";}
	public string Answer2()
	{return "C";}
	public string Answer3()
	{return "A";}
}
//ѧ���ҵ��Ծ�
class TestPaperB: TestPaper
{
	public string Answer1()
	{return "A";}
	public string Answer2()
	{return "B";}
	public string Answer3()
	{return "C";}
}

//�ͻ��ˣ�
static void Main(string[] args)
{
	Console.WriteLine("ѧ���׵��Ծ��:");
	TestPaper stuA=new TestPaperA;
	stuA.TestQuestion1();
	stuA.TestQuestion2();
	stuA.TestQuestion3();
	
	Console.WriteLine("ѧ���ҵ��Ծ��:");
	TestPaper stuB=new TestPaperB;
	stuB.TestQuestion1();
	stuB.TestQuestion2();
	stuB.TestQuestion3();
	
	Console.Read();
}