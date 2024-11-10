//-----------------------------------------------------------------
//    <copyright file="Astronaut.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace ModelsPOO.models.Astronaut
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
        PayloadSpecialist,


    }

    /// <summary>
    /// Represents an astronaut with a name, role, and years of experience.
    /// </summary>
    public class Astronaut
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the astronaut.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role of the astronaut, defined by the RoleType enumeration.
        /// </summary>
        public RoleType Role { get; private set; }

        /// <summary>
        /// Gets or sets the years of experience the astronaut has.
        /// </summary>
        public int ExperienceYears { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Astronaut"/> class.
        /// </summary>
        /// <param name="name">The name of the astronaut.</param>
        /// <param name="role">The role of the astronaut.</param>
        /// <param name="experienceYears">The years of experience of the astronaut.</param>
        public Astronaut(string name, RoleType role, int experienceYears)
        {
            Name = name;
            Role = role;
            ExperienceYears = experienceYears;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Checks if the astronaut has more than 5 years of experience.
        /// </summary>
        /// <returns>A boolean indicating if the astronaut is experienced (5+ years).</returns>
        public bool IsExperienced()
        {
            return ExperienceYears >= 5;
        }

        /// <summary>
        /// Updates the role of the astronaut.
        /// </summary>
        /// <param name="newRole">The new role to be assigned to the astronaut.</param>
        public void UpdateRole(RoleType newRole)
        {
            Role = newRole;
        }

        /// <summary>
        /// Returns a detailed description of the astronaut, including name, role, years of experience, and experience status.
        /// </summary>
        /// <returns>A string containing detailed information about the astronaut.</returns>
        public string GetDetailedDescription()
        {
            string experienceLevel = IsExperienced() ? "Experienced" : "Less Experienced";
            return $"{Name}, a {Role} with {ExperienceYears} years of experience. Status: {experienceLevel}.";
        }

        #endregion
    }
}





