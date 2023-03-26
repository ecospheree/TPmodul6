// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

public class SayaTubeVideo
{
    int id;
    string title;
    int playCount;

    public SayaTubeVideo(String t)
    {
        this.title = t;
        Random x = new Random();
        id = x.Next(10000,99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int pc)
    {
        this.playCount += pc;
            
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("id : " + this.id);
        Console.WriteLine("title : " + this.title);
        Console.WriteLine("playCount : " + this.playCount);
    }

    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Nabiel");
        video.IncreasePlayCount(11);
        video.PrintVideoDetails();
    }
}
