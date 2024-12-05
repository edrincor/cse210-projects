using System;

public class Goals
{
    private string _name;
    private string _description;
    private int _points;

    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {
        
    }
    
    public bool IsComplete()
    {
        return false;
    }
}