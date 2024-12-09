using System;
using System.IO;

public class Goals()
{
    private List<Goal> _goals = new List<Goal>();
    private string _filename = "";
    private int _totalScore = 0;

    public void LoadFile()
    {
        string filename = _filename;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _goalName = parts[0];
            string _goalDesc = parts[1];
            string _goalType = parts[2];
        }
    }
    public void SaveFile()
    {
        string filename = _filename;

        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine("");
        }
    }
}