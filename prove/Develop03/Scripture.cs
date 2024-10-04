using System;


public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordstrings = text.Split(" ");

        foreach (var words in wordstrings)
        {
            Word word = Word(words);
            _words.Add(word); 
        }
        
    }

    public void HideRandomWords(int numberToHIde)
    {

    }

    public string GetDisplayText()
    {
        Console.Write(_reference);
        foreach (Word words in _words)
        {
            Console.Write(words);
        }
    }

    public bool IsCompletelyHidden()
    {

    }
}