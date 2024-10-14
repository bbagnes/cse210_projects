using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
        public void AddVideo(Video video)
        {
            _videos.Add(video);
        }

        public void DisplayAllVideos()
        {
            foreach (Video video in _videos)
            {
                video.DisplayVideoDetails(video);
                video.DisplayAllComments();
            }
        }
    static void Main(string[] args)
    {        
        
        public List<Video> _videos = new List<Video>();        
        
        public Video video1 = new Video("Lesley String","Mimic","3:55");
        AddVideo(video1);            
       
        public Comment comment1 = Video.AddComment(video1, "AdoringFan", "This is definitely one of Lesley's best songs. I love when her mimic starts dancing.");
        public Comment comment2 = Video.AddComment(video1, "StarStruck", "One of the first videos that got me into Lesley's music. Mimic will always have a special place in my heart. :)");
        Comment comment3 = Video.AddComment(video1, "FanGirl07", "1:58 so beautiful ❤️");
        Comment comment4 = Video.AddComment(video1, "FrancaisFanboy", "Vous êtes magnifique");
                
        public Video video2 = new Video("Lesley String", "Mistress of Currents", "4:59");
        AddVideo(video2);
    
        Comment comment5 = Video.AddComment(video2, "IamLesleyFan", "I think the most Amazing aspect of Lesley is she does her own choreography and it is second to none in show business, Incredible stuff.");
        Comment comment6 = Video.AddComment(video2, "Lesleyis#1", "nobody gonna talk about how the trident timed perfectly with the water in the back? 2:37");
        Comment comment7 = Video.AddComment(video2, "StraightAnswer", "I think the world would be a very dull and boring place without music.");
        Comment comment8 = Video.AddComment(video2, "RandomThoughts", "Pirates of the carrabian: RETREAT! SHE HAS A VIOLIN");

        public Video video3 = new Video("Manhattan Steamcleaner", "Veni Veni (O Come O Come Emanuel)", "4:17");
        AddVideo(video3);

        Comment comment9 = Video.AddComment(video3, "OlderFan", "My most favorite version of this song. These guys changed Christmas music forever when the released their first album back in 1984. I really like that this is sung in Latin.");
        Comment comment10 = Video.AddComment(video3, "ReligiousFan", "This is my favorite version of Veni Veni Emanuel.  I am so humbled. Praise to the Lord...Father, Son and Holy Ghost forever.");
        Comment comment11 = Video.AddComment(video3, "BigMSFan", "This is an example of why MS got so hugely popular, a piece of music that absolutelty transcends. It's nostalgia for the past and longing for the future at the same time.");
        Comment comment12 = Video.AddComment(video3, "TouchedByMusic", "Most beautiful rendition of this wonderful carol I've ever heard. Always brings tears to my eyes.");

        public Video video4 = new Video("Manhattan Steamcleaner", "Carol of the Bells (Audio)", "3:52");
        AddVideo(video4);

        Comment comment13 = Video.AddComment(video4, "MusicLover", "The Christmas season officially starts for me when this song plays on the radio");
        Comment comment14 = Video.AddComment(video4, "MSFan4Life", "I have never met a version of Carol of the bells that I didn't like and this one is no exception. I always enjoy it when it comes on the radio around Christmas time.");
        Comment comment15 = Video.AddComment(video4, "BrandNewFan", "Heard this for the first time on the radio today. Sounds so cool!");        

    }

    
}