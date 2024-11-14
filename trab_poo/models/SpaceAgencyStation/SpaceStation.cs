//-----------------------------------------------------------------
//    <copyright file="SpaceStation.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>11-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace ModelsPOO.models.SpaceAgency
{
    /// <summary>
    /// Represents a space station with a name, crew capacity, and inauguration date.
    /// </summary>
    public class SpaceStation
    {
        #region Properties

        /// <summary>
        /// The name of the space station (e.g., "International Space Station").
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The crew capacity of the space station.
        /// </summary>
        public int CrewCapacity { get; }

        /// <summary>
        /// The inauguration date of the space station.
        /// </summary>
        public DateTime InaugurationDate { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceStation"/> class.
        /// </summary>
        /// <param name="name">The name of the space station.</param>
        /// <param name="crewCapacity">The crew capacity of the space station.</param>
        /// <param name="inaugurationDate">The inauguration date of the space station.</param>
        /// <exception cref="ArgumentException">Thrown when the station name is null or empty, or the crew capacity is non-positive.</exception>
        public SpaceStation(string name, int crewCapacity, DateTime inaugurationDate)
        {
            // Validates that the station name is not null or empty
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The name of the station cannot be null or empty.", nameof(name));

            // Validates that the crew capacity is a positive number
            if (crewCapacity <= 0)
                throw new ArgumentException("The crew capacity must be greater than zero.", nameof(crewCapacity));

            // Validates that the inauguration date is not in the future
            if (inaugurationDate > DateTime.Now)
                throw new ArgumentException("The inauguration date cannot be in the future.", nameof(inaugurationDate));

            // Assigns values to properties
            Name = name;
            CrewCapacity = crewCapacity;
            InaugurationDate = inaugurationDate;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Simulates the operation of the space station, displaying its name and crew capacity.
        /// </summary>
        public void OperateStation()
        {
            Console.WriteLine($"The space station {Name} with a crew capacity of {CrewCapacity} has been operational since {InaugurationDate:yyyy-MM-dd}.");
        }

        /// <summary>
        /// Returns a description of the space station.
        /// </summary>
        /// <returns>A string with the name of the station, crew capacity, and inauguration date.</returns>
        public string GetStationInfo()
        {
            return $"{Name} - Crew Capacity: {CrewCapacity} - Inauguration: {InaugurationDate:yyyy-MM-dd}";
        }

        #endregion
    }
}
