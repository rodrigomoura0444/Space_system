//-----------------------------------------------------------------
//    <copyright file="SpaceTourismStation.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>11-11-2024</date>
//    <time>16:30</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace ModelsPOO.models.SpaceAgency
{
    /// <summary>
    /// Represents a space station dedicated to space tourism, offering accommodations for tourists in space.
    /// </summary>
    public class SpaceTourismStation : SpaceStation
    {
        #region Properties

        /// <summary>
        /// The maximum capacity of tourists the station can accommodate.
        /// </summary>
        public int TouristCapacity { get; set; }

        /// <summary>
        /// The number of tourists currently at the station.
        /// </summary>
        public int TouristsPresent { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the SpaceTourismStation class with the specified parameters.
        /// </summary>
        /// <param name="name">The name of the space station.</param>
        /// <param name="crewCapacity">The maximum capacity of crew members the station can accommodate.</param>
        /// <param name="inaugurationDate">The inauguration date of the station.</param>
        /// <param name="touristCapacity">The maximum capacity of tourists the station can accommodate.</param>
        public SpaceTourismStation(string name, int crewCapacity, DateTime inaugurationDate, int touristCapacity)
            : base(name, crewCapacity, inaugurationDate)
        {
            // Validate if the tourist capacity is a positive value
            if (touristCapacity <= 0)
                throw new ArgumentException("Tourist capacity must be greater than zero.", nameof(touristCapacity));

            TouristCapacity = touristCapacity;
            TouristsPresent = 0; // Initial value
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds tourists to the space station. If the maximum capacity is reached, it prevents the addition.
        /// </summary>
        /// <param name="quantity">The number of tourists to add.</param>
        public void AddTourists(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("The quantity of tourists to add must be positive.");
                return;
            }

            if (TouristsPresent + quantity <= TouristCapacity)
            {
                TouristsPresent += quantity;
                Console.WriteLine($"{quantity} tourists were added to the station. Total tourists present: {TouristsPresent}.");
            }
            else
            {
                Console.WriteLine("Cannot add this quantity of tourists, as the maximum capacity has been reached.");
            }
        }

        /// <summary>
        /// Removes tourists from the space station. If the number of tourists to remove exceeds the number present, it prevents removal.
        /// </summary>
        /// <param name="quantity">The number of tourists to remove.</param>
        /// 

       
        public void RemoveTourists(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("The quantity of tourists to remove must be positive.");
                return;
            }

            if (TouristsPresent >= quantity)
            {
                TouristsPresent -= quantity;
                Console.WriteLine($"{quantity} tourists were removed from the station. Total tourists remaining: {TouristsPresent}.");
            }
            else
            {
                Console.WriteLine("Cannot remove this quantity of tourists, as there aren't enough tourists.");
            }
        }

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Provides a detailed description of the space tourism station, including tourist capacity and the current number of tourists present.
        /// </summary>
        /// <returns>A string that describes the space tourism station's characteristics.</returns>
        public override string ToString()
        {
            return $"{base.ToString()}, Tourist Capacity: {TouristCapacity}, Tourists Present: {TouristsPresent}";
        }

        #endregion
    }
}
