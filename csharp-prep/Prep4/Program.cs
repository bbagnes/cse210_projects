using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>() ;
        string addNumber;
        float number;
        float sum = 0;
        float max = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            
            Console.Write("Enter number: ");
            addNumber = Console.ReadLine();
            number = float.Parse(addNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }            
            

        } while (number != 0);

        foreach (float value in numbers)
        {
            sum = sum + value;
            if (value > max)
            {
                max = value;
            }
        }
        Console.WriteLine($"The sum is: {sum}.");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {max}.");
    }    
}