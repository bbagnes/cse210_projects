using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Journal Program.");
        int response;

        do
        {
           
            response = ShowMenuOptions();

            if (response == 1)
            {
                Entry newEntry = new Entry();
                newEntry = Entry.GetEntry();

                response = ShowMenuOptions();
            }

            else if (response == 2)
            {

                response = ShowMenuOptions();
            }

            else if (response == 3)
            {
                
                response = ShowMenuOptions();
            }

            else if (response == 4)
            {
                Console.WriteLine("What name would you like to save the file under? (Example: Journal.txt)" );
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstName = parts[0];
                    string lastName = parts[1];

                response = ShowMenuOptions();
                } 
                
            }

            else
            {

            }

        } while (response != 5);

        Console.WriteLine("Thank you for using the Journal Program.");
        Console.WriteLine("Have a good day.");

        static int ShowMenuOptions()
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write Entry.");
            Console.WriteLine("2. Display Journal Entries.");
            Console.WriteLine("3. Save Journal to File.");
            Console.WriteLine("4. Load Journal from File.");
            Console.WriteLine("5. Quit Program.");
            string userResponse = Console.ReadLine();
            int response = int.Parse(userResponse);
            return response;
        }       

    }
}