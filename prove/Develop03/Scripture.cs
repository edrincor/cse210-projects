using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture()
    {
        _reference = new Reference();
        _words = new List<Word>();
        string scripture = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        string[] split = scripture.Split(" ");
        foreach (string word in split)
        {
            _words.Add(new Word(word));
        }
        
    }

    public void HideWords()
    {
        for(int i = 0; i > 3; i++) 
        {
            Random r = new Random();
            int index = r.Next(_words.Count());
            _words[index].Hide();
        }
    }
    public void Display()
    {
        _reference.Display();
        foreach(Word word in _words)
        {
            word.Display();
        }
    }
    public bool IsCompletelyHidden()
    {
        bool end = false;
        foreach(Word word in _words)
        {
            if(word.IsHidden())
            {
                end = false;
            }
            else{ end = true; }
        }
        return end;
    }
}