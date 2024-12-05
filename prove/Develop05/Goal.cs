using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;

    // Constructors
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal(){}

    // Getters and Setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }
    public bool GetStatus()
    {
        return _status;
    }

    // Inheritable methods
    public virtual string ListGoal()
    {
        return $"{_name} ({_description}): {_points}";
    }
    public abstract int RecordEvent();
    public abstract void RunGoal();
}