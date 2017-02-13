public abstract class State
{
	public abstract void WriteProgram(Work w);
}

public class ForenoonState: State
{
	public override void WriteProgram(Work w)
	{
		if(w.Hour<12)
		{
			Console.WriteLine("当前上午{0}点，精神很好！",w.Hour);
		}
		else
		{
			w.SetState(new NoonState());
			w.WriteProgram();
		}
	}
}
public class NoonState: State
{
	public override void WriteProgram(Work w)
	{
		if(w.Hour<13)
		{
			Console.WriteLine("当前中午{0}点，休息！",w.Hour);
		}
		else
		{
			w.SetState(new AfternoonState());
			w.WriteProgram();
		}
	}
}

public class Work
{
	private State current;
	public Work()
	{
		current=new ForenoonStat();
	}
	
	private double hour;
	public double Hour
	{
		get{return hour;}
		set{hour=value;}
	}
	private bool finish=false;
	public bool TaskFinished
	{
		get{return finish;}
		set{finish=value;}
	}
	public void SetState(State s)
	{
		current s;
	}
	publiv void WriteProgram()
	{
		current.WriteProgram(this);
	}
}