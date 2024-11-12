using System;

public class Prompt
{
    // List of prompts
    private List<string> prompts = new List<string>();
    public Prompt()
    {
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("Did I achieve my goals for today?");
        prompts.Add("What am I grateful for?");
    }

    // Generating random prompt from list
    public string generatePrompt()
    {
        Random r = new Random();
        int index = r.Next(prompts.Count);
        string randomPrompt = prompts[index];
        return randomPrompt;
    }
}