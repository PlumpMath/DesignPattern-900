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

//简单工厂
public class OperationFactory
{
	public static Operation createOperate(string operate)
	{
		Operation oper=null;
		switch(operate)
		{
			case "+":
				oper=new OperationAdd();
				break;
			case "-":
				oper=new OperationSub();
				break;
			case "*":
				oper=new OperationMul();
				break;
			case "/":
				oper=new OperationDiv();
				break;
		}
		return oper;
	}
}

//客户端代码
Operation oper;
oper=OperationFactory.createOperate("+");
oper.NumberA=1;
oper.NumberB=2;
double result=oper.GetResult();