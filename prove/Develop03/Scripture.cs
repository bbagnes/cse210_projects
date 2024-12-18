/* For the "Show Creativity and Exceeding Requirements" portion of the assignment I added an option in the main program to reset the text 
to show all text, and added a method in the Scripture class that resets all boolean logic to "false;" which in turn causes the GetDisplayText 
method in the Word Class to display all of the words in the scripture. */ 

using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Text;


public class Scripture
{
    private Reference _reference;

    private static List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordstrings = text.Split(" ");

        foreach (var words in wordstrings)
        {
            Word word = new Word(words);
            _words.Add(word); 
        }        
    }

    public void HideRandomWords(int number)
    {
        int countDown = number;
        int countChange = 0;        

        while (countDown> 0)
        {      
            if ((_words.Count - countChange) < countDown)
            {
               countDown = _words.Count - countChange;
            }

            else
            {
                countChange = 0;
                foreach (Word word in _words)
                {
                    bool status = word.GetHiddenStatus();                
                
                    if (status == false)
                    {
                        Random randomGenerator = new Random();
                        int hideWord = randomGenerator.Next(1, 7);
                        if (hideWord == 5)
                        {
                            word.HideWord();
                            countDown = countDown - 1;                                                   
                        }
                        else
                        {
                            continue;
                        }          
                    }

                    else
                    {
                        countChange ++;
                        continue;
                    }
                }
            }
        }
    }

    public void ResetAllWords()
    {
        foreach (Word word in _words)
                {
                word.ShowWord();
                }
    }

    public void GetDisplayText()
    {
        Console.Write(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
           word.GetDisplayText();            
        }
    }

    public bool IsCompletelyHidden()
    {
       foreach (Word word in _words)
       {
            bool status = word.GetHiddenStatus();
            if (status == false)
            {
                return false;
            }

            else
            {
                continue;
            }
       }
       return true;
    }
}