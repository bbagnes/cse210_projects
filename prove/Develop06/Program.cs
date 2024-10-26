/* To 'Show Creativity and Exceeding Requirements' this week I have added a ranking system in the GoalManager Class with the method
GetPlayerRank() that compares the player's score to a list of rankings, then displays the correct ranking message dependant on their
score. And a small animation sequence method called ShowTwinklingStars() that plays when the player obtains the rank of Grandmaster.
Ranking increases are at 500, 2000, 4000, 8000, and 16000 total points respectively. */

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        
    }
}