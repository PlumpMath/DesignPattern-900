class TestPaper
{
	public void TestQuestion1()
	{
		Console.WriteLine("答案是：A.1 B.2 C.3 D.4");
		Console.WriteLine("选择： "+Answer1());
	}
	public void TestQuestion2()
	{
		Console.WriteLine("答案是: A.5 B.6 C.7 D.8");
		Console.WriteLine("选择： "+Answer2());
	}
	public void TestQuestion3()
	{
		Console.WriteLine("答案是：A.1 B.3 C.5 D.7");
		Console.WriteLine("选择： "+Answer3());
	}
	
	public virtual string Answer1()
	{return "";}
	public virtual string Answer2()
	{return "";}
	public virtual string Answer3()
	{return "";}
}

//学生甲的试卷
class TestPaperA: TestPaper
{
	public string Answer1()
	{return "B";}
	public string Answer2()
	{return "C";}
	public string Answer3()
	{return "A";}
}
//学生乙的试卷
class TestPaperB: TestPaper
{
	public string Answer1()
	{return "A";}
	public string Answer2()
	{return "B";}
	public string Answer3()
	{return "C";}
}

//客户端：
static void Main(string[] args)
{
	Console.WriteLine("学生甲的试卷答案:");
	TestPaper stuA=new TestPaperA;
	stuA.TestQuestion1();
	stuA.TestQuestion2();
	stuA.TestQuestion3();
	
	Console.WriteLine("学生乙的试卷答案:");
	TestPaper stuB=new TestPaperB;
	stuB.TestQuestion1();
	stuB.TestQuestion2();
	stuB.TestQuestion3();
	
	Console.Read();
}