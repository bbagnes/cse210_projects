/*To "show creativity I added a method in the Journal class to select and display journal entries by date, and 
a constructor in the Entry class to add an Entry with specified member variables in order to create a dummy
entry dated 09/16/2024 in the Journal class to test its functionality. I also added a menu option in the main 
program to select and display journal entries selected by date.*/

using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program.");
        Journal journal = new Journal();  
        
        int response = ShowMenuOptions();      

        do
        {            
            
            if (response == 1)
            {
                journal.AddEntry();
                
                response = ShowMenuOptions();
            }

            else if (response == 2)
            {
                Console.WriteLine("What date for journal entries would you like to display? Ex. 10/10/2024.");
                string dateSelect = Console.ReadLine();
                Console.WriteLine("");
                journal.DisplayEntryByDate(dateSelect);

                response = ShowMenuOptions();
            }

            else if (response == 3)
            {
                journal.DisplayAllEntries();

                response = ShowMenuOptions();
            }

            else if (response == 4)
            {
                journal.SaveToFile();

                response = ShowMenuOptions();
            }

            else if (response == 5)
            {
                journal.LoadFromFile();

                response = ShowMenuOptions();
            } 

        } while (response != 6);

        Console.WriteLine("Thank you for using the Journal Program.");
        Console.WriteLine("Have a good day.");

        static int ShowMenuOptions()
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write Entry.");
            Console.WriteLine("2. Display Journal Entries by Date.");
            Console.WriteLine("3. Display All Journal Entries.");
            Console.WriteLine("4. Save Journal to File.");
            Console.WriteLine("5. Load Journal from File.");
            Console.WriteLine("6. Quit Program.");
            string userResponse = Console.ReadLine();
            int response = int.Parse(userResponse);
            return response;
        }       

    }
}