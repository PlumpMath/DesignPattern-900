class SubSystemOne
{
	public void MethodOne()
	{
		Console.WriteLine("子系统方法一");
	}
}
class SubSystemTwo
{
	public void MethodTwo()
	{
		Console.WriteLine("子系统方法二");
	}
}
class  SubSystemThree
{
	public void MethodThree()
	{
		Console.WriteLine("子系统方法三");
	}
}

//外观类
class Facade
{
	SubSystemOne one;
	SubSystemTwo two;
	SubSystemThree three;
	
	public Facade()
	{
		one= new SubSystemOne;
		two= new SubSystemTwo;
		three=new SubSystemThree;
	}
	
	public void MethodA()
	{
		Console.WriteLine("方法组一：");
		one.MethodOne();
		three.MethodThree();
	}
	public void MethodB()
	{
		Console.WriteLine("方法组二：");
		two.MethodTwo();
		one.MethodOne();
	}
}

//客户端：
static void Main(string[] args)
{
	Facade facade=new Facade();
	
	facade.MethodA();
	facade.MethodB();
	
	Console.Read();
}

/*********
何时使用？
在重构一个复杂的原系统时，可以用一个外观类将原系统的类封装，同时在外观Facade类里实现新的接口，
那么就可以分成两个小组，一个小组负责封装原来的类，另一个小组直接调用接口开发新系统
*********/
