using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    //Constructor
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    //Second constructor so I meet the Design Requirements
    public Reference(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;
    }

    //Displays "Book Chapter:verse(s)"
    public void Display()
    {
        if (_endverse > 0)
        {
            Console.Write($"{_book} {_chapter}:{_verse}-{_endverse} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_verse} ");
        }
    }
}