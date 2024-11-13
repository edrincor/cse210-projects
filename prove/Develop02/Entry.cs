using System;

public class Entry
{
    // Date
    private DateTime dateTime = DateTime.Now;
    private string _date;

    // Random prompt
    private Prompt prompts = new Prompt();
    private string _randomPrompt;

    // Response
    private string _response;

    // Constructor
    public Entry(string r)
    {
        _randomPrompt = prompts.GeneratePrompt();
        _date = dateTime.ToShortDateString();
        _response = r;
    }
    
    // Accessing private variables
    public string Date
    {
        get {return _date;}
        set {_date = value;}
    }
    public string RandomPrompt
    {
        get {return _randomPrompt;}
        set { _randomPrompt = value;}
    }
    public string Response
    {
        get {return _response;}
        set { _response = value;}
    }

    // Display Entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_randomPrompt}");
        Console.WriteLine($"Response: {_response}");
    }
}