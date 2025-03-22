using System;
using System.Collections.Generic;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul harus antara 1 hingga 100 karakter.");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public string GetTitle()
    {
        return this.title;
    }

    public int GetPlayCount()
    {
        return this.playCount;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 10000000)
            throw new ArgumentOutOfRangeException("Count harus antara 0 dan 10 juta.");

        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}
