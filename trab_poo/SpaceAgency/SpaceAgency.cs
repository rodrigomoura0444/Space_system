public class Astronaut
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int ExperienceYears { get; set; }

    public Astronaut(string name, string role, int experienceYears)
    {
        Name = name;
        Role = role;
        ExperienceYears = experienceYears;
    }

    // Método para calcular se o astronauta é veterano (mais de 5 anos de experiência)
    public bool IsVeteran()
    {
        return ExperienceYears > 5;
    }

    public override string ToString()
    {
        return $"{Name} - {Role} ({ExperienceYears} years of experience)";
    }
}
