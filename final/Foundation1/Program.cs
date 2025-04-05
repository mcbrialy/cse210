using System;

class Program
{
    private static List<Video> _videos = new List<Video>();
    static void Main(string[] args)
    {
        Video video1 = new Video("Clickbait", "Mr. Beast", 22.16);
        Video video2 = new Video("FIVE HACKS TO BLOW YOUR MIND", "5 Minute Crafts", 5);
        Video video3 = new Video("Rolling in the Deep MV", "Adele", 6.25);

        Comment comment1 = new Comment("Bob", "This video is my life, blood and soul XOXO");
        Comment comment2 = new Comment("John", "I hated this video");
        Comment comment3 = new Comment("Susie", "I don't have anything to say");
        Comment comment4 = new Comment("Bill", "Who knew watermelons could be used this way");
        Comment comment5 = new Comment("Jordan", "please just stop");
        Comment comment6 = new Comment("Helen", "Eggs? In this economy?");
        Comment comment7 = new Comment("Lyn", "please sign my child");
        Comment comment8 = new Comment("Tomac", "ur a goddess");
        Comment comment9 = new Comment("Eli", "More like rolling in the stink...");

        AddVideo(video1);
        AddVideo(video2);
        AddVideo(video3);

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
    public static void AddVideo(Video video)
    {
        _videos.Add(video);
    }
}