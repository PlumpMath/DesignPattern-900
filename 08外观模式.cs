class SubSystemOne
{
	public void MethodOne()
	{
		Console.WriteLine("��ϵͳ����һ");
	}
}
class SubSystemTwo
{
	public void MethodTwo()
	{
		Console.WriteLine("��ϵͳ������");
	}
}
class  SubSystemThree
{
	public void MethodThree()
	{
		Console.WriteLine("��ϵͳ������");
	}
}

//�����
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
		Console.WriteLine("������һ��");
		one.MethodOne();
		three.MethodThree();
	}
	public void MethodB()
	{
		Console.WriteLine("���������");
		two.MethodTwo();
		one.MethodOne();
	}
}

//�ͻ��ˣ�
static void Main(string[] args)
{
	Facade facade=new Facade();
	
	facade.MethodA();
	facade.MethodB();
	
	Console.Read();
}

/*********
��ʱʹ�ã�
���ع�һ�����ӵ�ԭϵͳʱ��������һ������ཫԭϵͳ�����װ��ͬʱ�����Facade����ʵ���µĽӿڣ�
��ô�Ϳ��Էֳ�����С�飬һ��С�鸺���װԭ�����࣬��һ��С��ֱ�ӵ��ýӿڿ�����ϵͳ
*********/
