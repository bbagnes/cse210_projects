using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();

        string UserName = PromptUserName();
        int Number = PromptUserNumber();
        int SquareRoot = SquareNumber(Number);

        DisplayResult(UserName, SquareRoot); 
               
        static void DisplayWelcome ()
            {
                Console.WriteLine("Welcome to the Program!");
            }

        static string PromptUserName()
            {
                Console.Write("Please enter your name: ");
                string UserName = Console.ReadLine();
                return UserName;
            }

        static int PromptUserNumber()
            {
                Console.Write("Please enter your favorite number: ");
                string UserNumber = Console.ReadLine();
                int Number = int.Parse(UserNumber);
                return Number;
            }
        static int SquareNumber(int Number)
            {
                int SquareRoot = Number * Number;
                return SquareRoot;

            }

        static void DisplayResult(string UserName, int SquareRoot)
            {
                Console.WriteLine($"{UserName}, the square of your number is {SquareRoot}");
            }      
             
    }
}