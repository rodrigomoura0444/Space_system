
public class Astronaut
{
    public string Name { get; set; }
    public string Role { get; set; }  // e.g., Commander, Pilot, Mission Specialist
    public int ExperienceYears { get; set; }  // Years of experience in space missions

    public Astronaut(string name, string role, int experienceYears)
    {
        Name = name;
        Role = role;
        ExperienceYears = experienceYears;

       
    }

    public override string ToString()
    {
        return $"{Name} - {Role} ({ExperienceYears} years of experience)";
    }
}
