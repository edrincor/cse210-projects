using System;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Constructor
    public Scripture()
    {
        _words = new List<Word>();
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
        Random r = new Random();
        int pickline = r.Next(lines.Count());
        {
            string[] parts = lines[pickline].Split("|");
            _reference = new Reference(parts[0], Int32.Parse(parts[1]), Int32.Parse(parts[2]));
            string[] words = parts[3].Split(" ");
            foreach (string word in words)
            {
                _words.Add(new Word(word));
            }
        }
        
    }

    //Hides three words at a time, only hiding those still visible
    public void HideWords()
    {
        Random r = new Random();
        if (CountHidden() >= 3)
        {
            for(int i = 0; i < 3; i++) 
            {
                int index = r.Next(_words.Count());
                if(!_words[index].IsHidden())
                {
                    _words[index].Hide(_words[index]);
                }
                else {i--;}
            }
        }
        //Hides reamining words, only used when less than three words remain shown
        else
        {
            foreach(Word word in _words)
            {
                if(!word.IsHidden())
                {
                    word.Hide(word);
                }
            }
        }
    }

    //Counts the remaining words, only used when less than three words remain shown
    private int CountHidden()
    {
        int count = 0;
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    //Calls _reference.Display and _word.Display to output full scripture
    public void Display()
    {
        _reference.Display();
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    //Checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        int counter = 0;
        foreach(Word word in _words)
        {
            if(word.IsHidden())
            {
                counter++;
            }
        }
        if (counter == _words.Count())
        {
            return false;
        }
        return true;
    }
}