using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Video video1 = new Video();
            video1._title = "Top 5 places to visit in Baden-Württembearg";
            video1._author = "Larisa Portillo";
            video1._length = 400;

            Video video2 = new Video();
            video2._title = "Euro-Trip";
            video2._author = "Daniel Galileo";
            video2._length = 350;
            Video video3 = new Video();
            video3._title = "vlog in Rome";
            video3._author = "Gertrudiz Fernandez";
            video3._length = 380;

            video1.AddComment(new Comment("Ana", "Great tips, I loved the video!"));
            video1.AddComment(new Comment("Mark", "Nice places, thanks!"));
            video1.AddComment(new Comment("Liu", "I will visit the first on the list."));

            video2.AddComment(new Comment("Ana", "Great tips, I loved the video!"));
            video2.AddComment(new Comment("Mark", "Nice places, thanks!"));
            video2.AddComment(new Comment("Liu", "I will visit the first on the list."));

            video3.AddComment(new Comment("Ana", "Great tips, I loved the video!"));
            video3.AddComment(new Comment("Mark", "Nice places, thanks!"));
            video3.AddComment(new Comment("Liu", "I will visit the first on the list."));
            video3.AddComment(new Comment("Milo", "Congrats."));

            List<Video> videos = new List<Video> { video1, video2, video3 };
            foreach (Video v in videos)
            {
                v.Display();
                Console.WriteLine();
            }

        }
    }
}