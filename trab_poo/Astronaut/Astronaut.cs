namespace AstronautNamespace
{
    public class Astronaut
    {
        public string Name { get; set; } // Astronaut s name
        public string Role { get; set; }  // e.g , Commander, Pilot, Mission Specialist
        public int ExperienceYears { get; set; }  // Years of experience 

        public Astronaut(string name, string role, int experienceYears)
        {
            Name = name;
            Role = role;
            ExperienceYears = experienceYears;
        }

        // Function to verify if the astronaut had more than 5 years of experience
        public bool IsExperienced()
        {
            return ExperienceYears >= 5;
        }

        // Função para atualizar o cargo do astronauta
        public void UpdateRole(string newRole)
        {
            Role = newRole;
        }

        // Função para retornar uma descrição detalhada do astronauta
        public string GetDetailedDescription()
        {
            string experienceLevel = IsExperienced() ? "Experienced" : "Less Experienced";
            return $"{Name}, a {Role} with {ExperienceYears} years of experience. Status: {experienceLevel}.";
        }

        // Função para representar o astronauta de forma resumida
        public override string ToString()
        {
            return $"{Name} - {Role} ({ExperienceYears} years of experience)";
        }
    }
}
