using System;

public class Word
{
    private string _word;
    public Word(string word)
    {
        _word = word;
    }

    //Hides word by replacing it with _'s
    public void Hide(Word word)
    {
        _word = new string('_', _word.Length);
    }

    //Determines if a word is hidden by checking if it starts with '_'
    public bool IsHidden()
    {
        if (_word.StartsWith("_"))
        {
            return true;
        }
        return false;
    }
    
    //Displays individual words
    public void Display()
    {
        Console.Write($"{_word} ");
    }
}