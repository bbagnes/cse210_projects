/*To "show creativity I added a method in the Journal class to select and display journal entries by date, and 
a constructor in the Entry class to add an Entry with specified member variables in order to create a dummy
entry dated 09/16/2024 in the Journal class to test its functionality. I also added a menu option in the main 
program to select and display journal entries selected by date.*/

using System;
using System.IO;
using System.Collections.Generic;


public class Journal
{
    public List<Entry> _entries;
    
    public Journal()
    {
        _entries = new List<Entry>();
        Entry entry = new Entry("09/16/2024", "Date selection test.", "This was the first day of class for CSE 210. This entry is to test the functionality of 'show creativity' addition.");
        
        _entries.Add(entry);
    }
    
    public void AddEntry()
    {
        Entry entry = new Entry();
        
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryDetails();
            Console.WriteLine("");
        }

    }

    public void DisplayEntryByDate(string date)
    {
        foreach (Entry entry in _entries)
        {
            if (entry._date == date)
            {
                entry.DisplayEntryDetails();
                Console.WriteLine("");
            }
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Please select a file name, and add the .txt extension. (Ex. myjournal.txt)");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            { 
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine("");
            }
        }    
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}