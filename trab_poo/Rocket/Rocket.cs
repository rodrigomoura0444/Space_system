//-----------------------------------------------------------------
//    <copyright file="Rocket.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------


namespace SpaceAgency

{
    /// <summary>
    /// Represents a rocket used for space missions.
    /// </summary>
    public class Rocket
    {
        #region Properties

        /// <summary>
        /// The name of the rocket.
        /// </summary>
        public string RocketName { get; private set; }

        /// <summary>
        /// The type of fuel used by the rocket.
        /// </summary>
        public string FuelType { get; private set; }

        /// <summary>
        /// The capacity of the rocket (number of people it can transport).
        /// </summary>
        public int Capacity { get; private set; }

        /// <summary>
        /// The maximum payload the rocket can carry (in tons).
        /// </summary>
        public double MaxPayload { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new rocket instance with specified properties.
        /// </summary>
        /// <param name="rocketName">Name of the rocket.</param>
        /// <param name="fuelType">Type of fuel used by the rocket.</param>
        /// <param name="capacity">Capacity of the rocket (number of people it can carry).</param>
        /// <param name="maxPayload">Maximum payload the rocket can carry (in tons).</param>
        /// <exception cref="ArgumentException">Thrown when invalid values are provided for the rocket's properties.</exception>
        public Rocket(string rocketName, string fuelType, int capacity, double maxPayload)
        {
            if (string.IsNullOrWhiteSpace(rocketName))
                throw new ArgumentException("Rocket name cannot be null or empty.", nameof(rocketName));

            if (string.IsNullOrWhiteSpace(fuelType))
                throw new ArgumentException("Fuel type cannot be null or empty.", nameof(fuelType));

            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));

            if (maxPayload <= 0)
                throw new ArgumentException("Max payload must be greater than zero.", nameof(maxPayload));

            RocketName = rocketName;
            FuelType = fuelType;
            Capacity = capacity;
            MaxPayload = maxPayload;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Checks if the rocket can carry a specific payload weight.
        /// </summary>
        /// <param name="payloadWeight">The weight of the payload (in tons).</param>
        /// <returns>True if the payload is within the rocket's maximum capacity, otherwise false.</returns>
        public bool CanCarryPayload(double payloadWeight)
        {
            if (payloadWeight <= 0)
                throw new ArgumentException("Payload weight must be greater than zero.", nameof(payloadWeight));

            return payloadWeight <= MaxPayload;
        }

        /// <summary>
        /// Returns a brief description of the rocket, including name, fuel type, capacity, and max payload.
        /// </summary>
        /// <returns>A string containing basic information about the rocket.</returns>
        public string BasicInfo()
        {
            return $"{RocketName}: {FuelType} fuel, Capacity: {Capacity} people, Max Payload: {MaxPayload} tons";
        }

        #endregion

        #region Override Methods

        /// <summary>
        /// Returns a string representation of the rocket, including basic information.
        /// </summary>
        /// <returns>A string containing the basic info of the rocket.</returns>
        public override string ToString()
        {
            return BasicInfo();
        }

        #endregion
    }
}
