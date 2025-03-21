class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Faishal");
        video.PrintVideoDetails();

        video.IncreasePlayCount(5000);
        video.PrintVideoDetails();

        try
        {
            video.IncreasePlayCount(int.MaxValue);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}
