using System;
using System.Collections.Generic;

public class Launch
{
    public Rocket Rocket { get; set; }
    public Mission Mission { get; set; }
    public string LaunchDate { get; set; }
    public List<Astronaut> Astronauts { get; set; } = new List<Astronaut>();

    public Launch(Rocket rocket, Mission mission, string launchDate)
    {
        Rocket = rocket;
        Mission = mission;
        LaunchDate = launchDate;
    }

    // Método para adicionar um astronauta ao lançamento
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

    // Método para listar todos os astronautas no lançamento
    public void ListAstronauts()
    {
        foreach (var astronaut in Astronauts)
        {
            Console.WriteLine(astronaut.ToString());
        }
    }

    public override string ToString()
    {
        var astronautNames = string.Join(", ", Astronauts);
        return $"{Rocket.RocketName} Launch on {LaunchDate} for {Mission.MissionName} with astronauts: {astronautNames}";
    }
}
