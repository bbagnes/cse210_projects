using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
        
    public static void DisplayAllVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideoDetails(video);
            video.DisplayAllComments();
        }
    }
    
    public static List<Video> _videos = new List<Video>();         
    
    static void Main(string[] args)
    {   
        Video video1 = new Video("Lesley String","Mimic","3:55");   
        _videos.Add(video1);
    
        Comment comment1 = new Comment("AdoringFan", "'This is definitely one of Lesley's best songs. I love when her mimic starts dancing.'");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("StarStruck", "'One of the first videos that got me into Lesley's music. Mimic will always have a special place in my heart. :)'");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("FanGirl07", "'1:58 so beautiful ❤️'");
        video1.AddComment(comment3);
        Comment comment4 = new Comment("FrancaisFanboy", "'Vous êtes magnifique'");
        video1.AddComment(comment4);
                
        Video video2 = new Video("Lesley String", "Mistress of Currents", "4:59");
        _videos.Add(video2);
    
        Comment comment5 = new Comment("IamLesleyFan", "'I think the most Amazing aspect of Lesley is she does her own choreography and it is second to none in show business, Incredible stuff.'");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("Lesleyis#1", "'nobody gonna talk about how the trident timed perfectly with the water in the back? 2:37'");
        video2.AddComment(comment6);
        Comment comment7 = new Comment("StraightAnswer", "'I think the world would be a very dull and boring place without music.'");
        video2.AddComment(comment7);
        Comment comment8 = new Comment("RandomThoughts", "'Pirates of the carrabian: RETREAT! SHE HAS A VIOLIN'");
        video2.AddComment(comment8);

        Video video3 = new Video("Manhattan Steamcleaner", "Veni Veni (O Come O Come Emanuel)", "4:17");
        _videos.Add(video3);

        Comment comment9 = new Comment("OlderFan", "'My most favorite version of this song. These guys changed Christmas music forever when the released their first album back in 1984. I really like that this is sung in Latin.'");
        video3.AddComment(comment9);
        Comment comment10 = new Comment("ReligiousFan", "'This is my favorite version of Veni Veni Emanuel.  I am so humbled. Praise to the Lord...Father, Son and Holy Ghost forever.'");
        video3.AddComment(comment10);
        Comment comment11 = new Comment("BigMSFan", "'This is an example of why MS got so hugely popular, a piece of music that absolutelty transcends. It's nostalgia for the past and longing for the future at the same time.'");
        video3.AddComment(comment11);
        Comment comment12 = new Comment("TouchedByMusic", "'Most beautiful rendition of this wonderful carol I've ever heard. Always brings tears to my eyes.'");
        video3.AddComment(comment12);

        Video video4 = new Video("Manhattan Steamcleaner", "Carol of the Bells (Audio)", "3:52");
        _videos.Add(video4);

        Comment comment13 = new Comment("MusicLover", "'The Christmas season officially starts for me when this song plays on the radio.'");
        video4.AddComment(comment13);
        Comment comment14 = new Comment("MSFan4Life", "'I have never met a version of Carol of the bells that I didn't like and this one is no exception. I always enjoy it when it comes on the radio around Christmas time.'");
        video4.AddComment(comment14);
        Comment comment15 = new Comment("BrandNewFan", "'Heard this for the first time on the radio today. Sounds so cool!'");
        video4.AddComment(comment15);

        Console.WriteLine();
        DisplayAllVideos();
        Console.WriteLine();

    }

    
}