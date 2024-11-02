using System;
using System.Collections.Generic;

public class Launch
{
    public Rocket Rocket { get; set; }
    public string LaunchDate { get; set; }
    public List<Astronaut> Astronauts { get; set; }

    public Launch(Rocket rocket, string launchDate)
    {
        Rocket = rocket;
        LaunchDate = launchDate;
        Astronauts = new List<Astronaut>();
    }

    public void AddAstronaut(Astronaut astronaut)
    {
        if (Astronauts.Count < Rocket.Capacity)
        {
            Astronauts.Add(astronaut);
        }
        else
        {
            Console.WriteLine("Cannot add astronaut; rocket is at full capacity.");
        }
    }

    public override string ToString()
    {
        var astronautNames = string.Join(", ", Astronauts);
        return $"{Rocket.RocketName} Launch on {LaunchDate} with astronauts: {astronautNames}";
    }
}
