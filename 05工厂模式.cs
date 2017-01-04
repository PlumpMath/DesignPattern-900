public class Operation //抽象出的操作类
{
	private double _numberA=0;
	private double _numberB=0;
	
	public double NumberA
	{
		get {return _numberA;}
		set {_numberA=NumberA;}
	}
	public double NumberB
	{
		get {return _numberB;}
		set {_numberB=NumberB;}
	}
	
	public virtual double GetResult()
	{
		double result=0;
		return result;
	}
}

class OperationAdd: Operation
{
	public override double GetResult()
	{
		double result=0;
		result=NumberA+NumberB;
		return result;
	}
}
class OperationSub: Operation
{
	public override double GetResult()
	{
		double result;
		result=NumberA-NumberB;
		return result;
	}
}
class OperationMul: Operation
{
	public override double GetResult()
	{
		double result;
		result=NumberA*NumberB;
		return result;
	}
}
class OperationDiv:Operation
{
	public override double GetResult()
	{
		double result;
		if(NumberB==0)
			throw new Exception("除数不能为0!");
		result=NumberA/NumberB;
		return result;
	}
}

//工厂模式
interface IFactory
{
	Operation CreateOperation();
}

class AddFactory: IFactory
{
	public Operation CreateOperation()
	{
		return OperationAdd();
	}
}

class SubFactory: IFactory
{
	public Operation CreateOperation()
	{
		return OperationSub();
	}
}

class MulFactory: IFactory
{
	public Operation CreateOperation()
	{
		return OperationMul();
	}
}

class DivFactory: IFactory
{
	public Operation CreateOperation()
	{
		return OperationDiv();
	}
}

//客户端程序
IFactory operFactory=new AddFactory();
Operation oper=operFactory.CreateOperation();
oper.NumberA=1;
oper.NumberB=2;
double result=oper.GetResult();