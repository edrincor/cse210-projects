public class Checklist : Goals
{
    private int _counter;

    public Checklist(string name, string description, int points, int counter) : base(name, description, points)
    {
        _counter = counter;
    }
}