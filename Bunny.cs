using System;

Bunny myBunny = new Bunny("Snowball")
{
    LikesCarrots = true,
    LikesHumans = true
};

ActivityLevel bunnyActivity = ActivityLevel.High;

Console.WriteLine("Bunny Name: " + myBunny.Name);
Console.WriteLine("Likes Carrots: " + myBunny.LikesCarrots);
Console.WriteLine("Likes Humans: " + myBunny.LikesHumans);
Console.WriteLine("Activity Level: " + bunnyActivity);

public class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    public Bunny(string n)
    {
        Name = n;
    }
}

public enum ActivityLevel
{
    Low,
    Medium,
    High
}
