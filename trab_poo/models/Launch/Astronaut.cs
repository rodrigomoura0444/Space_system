//-----------------------------------------------------------------
//    <copyright file="Astronaut.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.2</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace ModelsPOO.models.Launch
{
    /// <summary>
    /// Enumeration representing various astronaut roles.
    /// </summary>
    public enum RoleType
    {
        Commander,
        Pilot,
        MissionSpecialist,
        Engineer,
        Scientist,
        FlightEngineer,
        PayloadSpecialist
    }

    /// <summary>
    /// Represents an astronaut with a name, role, and years of experience.
    /// </summary>
    public class Astronaut
    {
        #region Private Properties

        private string name { get; set; }
        private RoleType role { get; set; }
        private int experienceYears { get; set; }

        #endregion

        #region Public Properties

        public string Name { get => name; set => name = value; }

        public RoleType Role
        {
            get => role;
            private set => role = value;
        }

        public int ExperienceYears
        {
            get => experienceYears;
            private set => experienceYears = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor with parameters for name, role, and experience years.
        /// </summary>
        /// <param name="name">The name of the astronaut.</param>
        /// <param name="role">The role of the astronaut.</param>
        /// <param name="experienceYears">Years of experience of the astronaut.</param>
        /// <exception cref="ArgumentException">Thrown if experienceYears is negative or name is null/empty.</exception>
        public Astronaut(string name, RoleType role, int experienceYears)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            if (experienceYears < 0)
                throw new ArgumentException("Experience years cannot be negative.", nameof(experienceYears));

            this.name = name;
            this.role = role;
            this.experienceYears = experienceYears;
        }

        #endregion

        #region Public Methods

        public bool IsExperienced()
        {
            return ExperienceYears >= 5;
        }

        public void UpdateRole(RoleType newRole)
        {
            Role = newRole;
        }

        public void AddExperience(int years)
        {
            if (years < 0)
                throw new ArgumentException("Experience years to add cannot be negative.", nameof(years));

            ExperienceYears += years;
        }

        public string GetDetailedDescription()
        {
            string experienceLevel = IsExperienced() ? "Experienced" : "Less Experienced";
            return $"{Name}, a {Role} with {ExperienceYears} years of experience. Status: {experienceLevel}.";
        }

        public override string ToString()
        {
            return $"{Name} - {Role} ({ExperienceYears} years)";
        }

        #endregion
    }
}
