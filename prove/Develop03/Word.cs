using System;

public class Word
{
    private string _word;
    public Word(string word)
    {
        _word = word;
    }

    public void Hide()
    {
        _word = new string('_', _word.Length);
        /*int length = _word.Length;
        string hidden = "";
        for (int i = 0; i < length; i++)
        {
            hidden += "_";
        }
        _word = hidden;*/
    }

    public string Show()
    {
        return _word;
    }

    public bool IsHidden()
    {
        if (_word.StartsWith("_"))
        {
            return true;
        }
        else{ return false; }
    }

    public void Display()
    {
        Console.Write($"{_word} ");
    }
}