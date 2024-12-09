public class Checklist : Goal
{
    private int _counter;

    public Checklist(string name, string description, int points, int counter) : base(name, description, points)
    {
        _counter = counter;
    }

    public override int RecordEvent()
    {
        return 0;
    }
    public override void RunGoal()
    {
        
    }
}