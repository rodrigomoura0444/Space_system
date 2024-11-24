namespace ModelsPOO.models.Launch
{
    public class Astronaut : ILaunchable
    {
        #region Public Properties

        public string Name { get; set; }
        public string Rank { get; set; }
        public AstronautRole Role { get; set; }

        public bool IsReadyForLaunch { get; private set; }

        #endregion

        #region Constructors

        // Constructor that initializes Name, Rank, and Role
        public Astronaut(string name, string rank, AstronautRole role)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Astronaut name cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(rank))
                throw new ArgumentException("Astronaut rank cannot be null or empty.", nameof(rank));

            Name = name;
            Rank = rank;
            Role = role;
            IsReadyForLaunch = false;  // Initially not ready
        }

        #endregion

        #region Public Methods

        public void PrepareForLaunch()
        {
            Console.WriteLine($"Astronaut {Name}, {Rank}, Role: {Role}, is preparing for the launch.");
            IsReadyForLaunch = true;  // Mark as ready once the preparation begins
        }

        #endregion
    }
}
