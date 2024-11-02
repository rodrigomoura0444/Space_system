public class Astronaut
{
    public string Name { get; set; }
    public string Role { get; set; }

    public Astronaut(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public override string ToString()
    {
        return $"{Name} - {Role}";
    }
}
