using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    public int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null)
            throw new ArgumentNullException("Title cannot be null.");

        if (title.Length > 100)
            throw new ArgumentException("Title length cannot be more than 100 characters.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count <= 0)
            throw new ArgumentOutOfRangeException("Count must be a positive integer.");

        checked
        {
            try
            {
                this.playCount += count;
            }
            catch (OverflowException ex)
            {
                throw new InvalidOperationException("Play count exceeded the maximum limit.", ex);
            }
        }
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
        SayaTubeVideo video = null;

        try
        {
            video = new SayaTubeVideo(videoTitle);

            // Test preconditions
            // videoTitle = null; // uncomment to test null title precondition
            // videoTitle = new string('a', 101); // uncomment to test title length precondition

            video.PrintVideoDetails();

            // Test exception
            // for (int i = 0; i < 10000000; i++) // uncomment to test overflow exception
            // {
            //     video.IncreasePlayCount(1);
            // }

            // Uncomment the line below to test IncreasePlayCount method
            // video.IncreasePlayCount(100);

            Console.WriteLine("\nAfter adding 100 play count, the new play count is {0}", video.playCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}