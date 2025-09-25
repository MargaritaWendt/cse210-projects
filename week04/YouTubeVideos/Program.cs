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
            video1.AddComment(new Comment("Liu", "why go to BW if you have Bavaria next to it, way nicer"));

            video2.AddComment(new Comment("Sandra", "Awesome places!"));
            video2.AddComment(new Comment("Douglas", "Now I knwo where the Nett hier Meme comes from!"));
            video2.AddComment(new Comment("Martin", "Naah prefer Italy or Switzerland"));

            video3.AddComment(new Comment("Samu", "I am from BW liked your video but you missed some nice places"));
            video3.AddComment(new Comment("Martina", "really dont like your voice"));
            video3.AddComment(new Comment("Davide", "wouldve liked more details"));
            video3.AddComment(new Comment("Miguel", "do one of hamburg or the north please"));

            List<Video> videos = new List<Video> { video1, video2, video3 };
            foreach (Video v in videos)
            {
                v.Display();
                Console.WriteLine();
            }

        }
    }
}