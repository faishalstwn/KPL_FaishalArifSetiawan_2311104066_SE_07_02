class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Faishal");

        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Faishal");
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}
