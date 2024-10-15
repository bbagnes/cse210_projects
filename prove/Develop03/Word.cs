/* For the "Show Creativity and Exceeding Requirements" portion of the assignment I added an option in the main program to reset the text 
to show all text, and added a method in the Scripture class that resets all boolean logic to "false;" which in turn causes the GetDisplayText 
method in the Word Class to display all of the words in the scripture. */
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


public class Word
{
    private string _word;
    
    private string _hiddenWord;

    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _hiddenWord = CreateHiddenWord(_word);
        
        _isHidden = true;
    }
    
    public string CreateHiddenWord(string word)
    {        
        StringBuilder hidingWord = new StringBuilder("", word.Length);

        foreach (char letter in word)        
        {
            if (letter == ',' || letter == '.' || letter == ';')
            {
                hidingWord.Append(letter);
            }

            else
            {
                hidingWord.Append('_');
            }
            _hiddenWord = hidingWord.ToString();
            // Console.WriteLine($"Testing: {word} & {_hiddenWord}");                       
        }
        return _hiddenWord; 
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public bool GetHiddenStatus()
    {
        return _isHidden;
    }

    public void GetDisplayText()
    {
        // string wordSelection = "";
        if (_isHidden == true)
        {
            Console.Write($"{_hiddenWord} ");
            // wordSelection = _hiddenWord;
        }
        else if (_isHidden == false)
        {
            Console.Write($"{_word} ");
            // wordSelection = _word;
        }
    }
}