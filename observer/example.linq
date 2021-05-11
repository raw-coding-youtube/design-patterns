<Query Kind="Program" />

void Main()
{
	var alarm = new Alarm();
	alarm.AddWatcher(new FireStation());
	alarm.AddWatcher(new PoliceStation());
	alarm.AddWatcher(new HospitalStation());
	alarm.Notify();
}

public class Alarm {
	
	List<IWatcher<Alarm>> watchers = new ();
	
	public void AddWatcher(IWatcher<Alarm> alarmWatcher){
		watchers.Add(alarmWatcher);
	}
	
	public void Notify() {
		foreach(var w in watchers){
			w.Alert(this);
		}
	}
}

public interface IWatcher<T>{
	public void Alert(T value);
}

public class FireStation : IWatcher<Alarm>
{
	public void Alert(Alarm value)
	{
		nameof(FireStation).Dump("RESPONDING!");
	}
}

public class PoliceStation : IWatcher<Alarm>
{
	public void Alert(Alarm value)
	{
		nameof(PoliceStation).Dump("RESPONDING!");
	}
}

public class HospitalStation : IWatcher<Alarm>
{
	public void Alert(Alarm value)
	{
		nameof(HospitalStation).Dump("RESPONDING!");
	}
}
