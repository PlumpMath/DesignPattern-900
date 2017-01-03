abstract class CashSuper
{
	return abstract double acceptCash(double money);
}

class CashNomal:CashSuper
{
	return money;
}

class CashRebate:CashSuper
{
	private double moneyRebate=1;
	public CashRebate(string moneyRebate)
	{
		this.moneyRebate=double.Parse(moneyRebate);
	}
	public override double acceptCash(double money)
	{
		return money*moneyRebate;
	}
}

class CashReturn:CashSuper
{
	private double moneyCondition=0;
	private double moneyReturn=0;
	public CashReturn(string moneyCondition,string moneyReturn)
	{
		this.moneyCondition=moneyCondition;
		this.moneyReturn=moneyReturn;
	}
	
	public override double acceptCash(double money)
	{
		double result=0;
		if(money>=moneyCondition)
			result=money-Math.Floor(money/moneyCondition)*moneyReturn;
		return result;
	}
}

//以下是策略模式
class CashContext
{
	CashSuper cs=null;
	
	public CashContext(string type)
	{
		switch(type)
		{
			case "正常收费"：
				cs=new CashNomal();
				break;
			case "满300减100":
				CashReturn cr1=new CashReturn("300","100");
				cs=cr1;
				break;
			case "打8折":
				CashRebate cr2=new CashRebate("0.8");
				cs=cr2;
				break;
		}
	}
	
	public double GetResult(double money)
	{
		return cs.acceptCash(money);
	}
}

//客户端代码:
CashContext csuper=new CashContext("满300减100");
totalprice=csuper.GetResult(1000.0);

//以下是简单工厂模式
class CashFactory
{
	public static CashSuper cteateCashAccept(string type)
	{
		CashSuper cs=null;
		switch(type)
		{
			case "正常收费"：
				cs=new CashNomal();
				break;
			case "满300减100":
				CashReturn cr1=new CashReturn("300","100");
				cs=cr1;
				break;
			case "打8折":
				CashRebate cr2=new CashRebate("0.8");
				cs=cr2;
				break;
		}
		return cs;
	}
}