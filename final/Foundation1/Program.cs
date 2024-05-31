using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos =
        [
            new Video("video 1", "videoMan", 100, [new Comment("commentMan", "This rules"), new Comment("hater", "this sucks"), new Comment("Neutral", "meh")]),
            new Video("video 2", "notVidoeMan", 200, [new Comment("commentMan", "Thats Crazy"), new Comment("hater", "I hate this"), new Comment("Neutral", "neat I guess")]),
            new Video("Video 3", "Mastermind25", 250, [new Comment("commentMan", "Best video of the year"), new Comment("hater", "worst video of the year"), new Comment("Neutral", "neither best nor worst just another video")])
        ];

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}