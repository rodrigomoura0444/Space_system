//-----------------------------------------------------------------
//    <copyright file="Rocket.cs" company="IPCA">
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
    /// Class representing a rocket, including its name, weight, and the ability to simulate a launch.
    /// </summary>
    public class Rocket
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the rocket (e.g., "Falcon Heavy").
        /// </summary>
        public string RocketName { get; set; }

        /// <summary>
        /// Gets or sets the name of the rocket (e.g., "Falcon Heavy").
        /// This property serves as an alias for RocketName.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight of the rocket in tons.
        /// </summary>
        public double Weight { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Rocket"/> class with the specified name and weight.
        /// </summary>
        /// <param name="name">The name of the rocket (e.g., "Falcon Heavy").</param>
        /// <param name="weight">The weight of the rocket in tons.</param>
        /// <exception cref="ArgumentException">Thrown if the rocket name is null, empty, or the weight is non-positive.</exception>
        public Rocket(string name, double weight)
        {
            // Validate that the rocket name is not null or empty
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Rocket name cannot be null or empty.", nameof(name));

            // Validate that the rocket weight is positive
            if (weight <= 0)
                throw new ArgumentException("Rocket weight must be greater than zero.", nameof(weight));

            // Assign values to properties
            Name = name;
            Weight = weight;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Simulates the rocket launching by outputting the rocket's name and weight to the console.
        /// </summary>
        public void LaunchRocket()
        {
            Console.WriteLine($"Rocket {Name} (Weight: {Weight} tons) is ready to launch!");
        }

        #endregion
    }
}
