/* For the "Show Creativity and Exceeding Requirements" portion of the assignment I added an option in the main program to reset the text 
to show all text, and added a method in the Scripture class that resets all boolean logic to "false;" which in turn causes the GetDisplayText 
method in the Word Class to display all of the words in the scripture. */ 

using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    private static Reference _reference = new Reference("Moroni",5,2);
               
    static string _text = "O God, the Eternal Father, we ask thee, in the name of thy Son, Jesus Christ, to bless and sanctify this wine to the souls of all those who drink of it, that they may do it in remembrance of the blood of thy Son, which was shed for them; that they may witness unto thee, O God, the Eternal Father, that they do always remember him, that they may have his Spirit to be with them. Amen.";
        
    private static Scripture scripture = new Scripture(_reference, _text);
    private static bool _allTextHidden = scripture.IsCompletelyHidden();
    private static string userInput = "";     
    
    public static void Main(string[] args)
    {
        
        
        do
        {
            Console.Clear();
            Console.WriteLine("");
            scripture.GetDisplayText();
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue. Type 'reset' to start over. Or type 'quit' to finish:");
            userInput = Console.ReadLine();
            _allTextHidden = scripture.IsCompletelyHidden();

            if (userInput == "")
            {              
                
                Random randomGenerator = new Random();
                int numberToHIde = randomGenerator.Next(5, 10);              
                scripture.HideRandomWords(numberToHIde);
                                
            }
            
            else if (userInput == "reset")
            {
                Console.Clear();

                scripture.ResetAllWords();
                
            }

            else if (userInput == "quit")
            {
                break;          
            }   
                  
        }while(_allTextHidden != true);    
    }
}