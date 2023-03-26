using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: {0}", this.id);
        Console.WriteLine("Title: {0}", this.title);
        Console.WriteLine("Play Count: {0}", this.playCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string videoTitle = "Tutorial Design By Contract – [NAMA_PRAKTIKAN]";
        SayaTubeVideo video = new SayaTubeVideo(videoTitle);

        video.PrintVideoDetails();

        // tambahkan play count sebanyak 10
        video.IncreasePlayCount(10);

        //Console.WriteLine("\nSetelah ditambahkan 10, play count sekarang adalah {0}", video.playCount);
    }
}