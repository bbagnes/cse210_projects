/*For this week's Show Creativity and Exceeding Requirements I added a method to remove each question from the list of questions used in the
Reflection Activity after it had been used once to prevent repetition. This method only works, because the _questions list is intialized each 
time the option for the Reflection Activity is selected from the main menu.*/
using System;

class Program
{
    static void Main(string[] args)
    {       
        
        int response = ShowMenuOptions();      

        do
        {            
            
            if (response == 1)
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 60;

                BreathingActivity breathingActivity = new BreathingActivity(name, description, duration);

                breathingActivity.Run();
                
                response = ShowMenuOptions();
            }

            else if (response == 2)
            {
                string name = "Reflection Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                int duration = 120;

                ReflectionActivity reflectionActivity = new ReflectionActivity(name, description, duration);

                reflectionActivity.Run();

                response = ShowMenuOptions();
            }

            else if (response == 3)
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many as you can on a specified topic.";
                int duration = 180;

                ListingActivity listingActivity = new ListingActivity(name, description, duration);

                listingActivity.Run();

                response = ShowMenuOptions();
            }

        } while (response != 4);

        Console.WriteLine("");
        Console.WriteLine("Thank you for using the Mindfulness Program today. We hope it was helpful.");
        Console.WriteLine("Have a great day.");
        Console.WriteLine("");

        static int ShowMenuOptions()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity.");
            Console.WriteLine("2. Start Reflection Activity.");
            Console.WriteLine("3. Start Listing Activity.");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userResponse = Console.ReadLine();
            int response = int.Parse(userResponse);
            return response;
        }       
    }
}