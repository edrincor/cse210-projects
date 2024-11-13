using System;
using System.IO;

public class Journal
{
    private List<Entry> _journalEntries = new List<Entry>();

    // Adding Entry objects to list
    public void AddEntry()
    {
        _journalEntries.Add(new Entry(""));
        Console.WriteLine(_journalEntries.Last().RandomPrompt);
        _journalEntries.Last().Response = Console.ReadLine();
    }

    // Display Journal
    public void Display()
    {
        foreach (Entry e in _journalEntries)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void Load()
    {
        // Prompting user for filename
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Loading file and organizing into separate entries
        List<Entry> _loadedJournal = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("-");
            _loadedJournal.Add(new Entry(parts[2]));
            _loadedJournal.Last().RandomPrompt = parts[1];
            _loadedJournal.Last().Date = parts[0];
        }
        // Making _journalEntries == _loadedJournal
        _journalEntries.Clear();
        _journalEntries.AddRange(_loadedJournal);
    }

    public void Save()
    {
        // Prompting user for filename
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        // Using StreamWriter to save changes to file
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _journalEntries)
            {
                outputFile.WriteLine($"{e.Date}-{e.RandomPrompt}-{e.Response}");
            }
        }
    }
}