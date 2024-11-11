//-----------------------------------------------------------------
//    <copyright file="Astronaut.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace ModelsPOO.models.Launch
{
    /// <summary>
    /// Class representing an astronaut, including their name, rank, and the ability to prepare for launch.
    /// </summary>
    public class Astronaut
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the astronaut (e.g., "Neil Armstrong").
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the rank of the astronaut (e.g., "Commander").
        /// </summary>
        public string Rank { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Astronaut"/> class with the specified name and rank.
        /// </summary>
        /// <param name="name">The name of the astronaut (e.g., "Neil Armstrong").</param>
        /// <param name="rank">The rank of the astronaut (e.g., "Commander").</param>
        /// <exception cref="ArgumentException">Thrown if the astronaut name or rank is null or empty.</exception>
        public Astronaut(string name, string rank)
        {
            // Validate that the astronaut name is not null or empty
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Astronaut name cannot be null or empty.", nameof(name));

            // Validate that the astronaut rank is not null or empty
            if (string.IsNullOrWhiteSpace(rank))
                throw new ArgumentException("Astronaut rank cannot be null or empty.", nameof(rank));

            // Assign values to properties
            Name = name;
            Rank = rank;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Simulates the astronaut preparing for the launch by outputting the astronaut's name and rank to the console.
        /// </summary>
        public void PrepareForLaunch()
        {
            Console.WriteLine($"Astronaut {Name}, {Rank}, is preparing for the launch.");
        }

        #endregion
    }
}
