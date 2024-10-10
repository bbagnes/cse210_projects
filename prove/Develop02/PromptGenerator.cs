using System;
using System.Security.Cryptography;


public class Prompt
{
    public List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("Write about something new in your life; a person you've met, something you've learned, or something new that you've done.");

        _prompts.Add("What has been the best part of your day so far today? And why?");

        _prompts.Add("Is there anything that has happened recently you would like to change? If so, how and why?");

        _prompts.Add("How have you seen the hand of God in your life recently?");

        _prompts.Add("Write about something that you are looking forward to in the future.");

    }
    
    public string GetRandomPrompt()
    {    
        Random prompting = new Random();
        int r = prompting.Next(_prompts.Count);
        string prompt = _prompts[r];
        return prompt;
    }
}