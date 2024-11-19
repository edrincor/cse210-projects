using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    public Reference()
    {
        _book = "Mosiah";
        _chapter = 2;
        _verse = 17;
    }

    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_verse} ");
    }
}