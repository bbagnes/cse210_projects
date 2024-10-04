using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        public Reference _reference = Reference("Moroni",5,2);
       
        public string _text = "O God, the Eternal Father, we ask thee, in the name of thy Son, Jesus Christ, to bless and sanctify this wine to the souls of all those who drink of it, that they may do it in remembrance of the blood of thy Son, which was shed for them; that they may witness unto thee, O God, the Eternal Father, that they do always remember him, that they may have his Spirit to be with them. Amen.";

        public bool _allTextHidden = Scripture.IsCompletelyHidden();
    
        do
        {
            Console.WriteLine(Scripture.GetDisplayText());
            string userInput = Console.ReadLine();

        If (userInput == "")
        {
            Console.Clear();

            
        } 

// This will clear the console
Console.Clear();  
        } while (_allTextHidden != true && userInput != "quit");    
    }
}