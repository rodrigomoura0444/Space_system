//-----------------------------------------------------------------
//    <copyright file="MarsMission.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace ModelsPOO.models.Mission
{
    /// <summary>
    /// Represents a space mission specifically aimed at Mars exploration.
    /// Inherits from CMission and adds additional functionality or characteristics related to Mars missions.
    /// </summary>
    public class MarsMission : CMission
    {
        #region Properties

        /// <summary>
        /// The type of Mars mission like fot example Landing or orbital
        /// </summary>
        public string MissionType { get; }

       

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MarsMission"/> class.
        /// </summary>
        /// <param name="missionName">The name of the Mars mission (e.g., "Mars 2024").</param>
        /// <param name="objective">The objective of the mission (e.g., "Land on Mars").</param>
        /// <param name="missionType">The type of Mars mission (e.g., "Landing", "Orbital").</param>
        /// <exception cref="ArgumentException">Thrown when missionName, objective, or missionType is null or empty.</exception>
        public MarsMission(string missionName, string objective, string missionType)
            : base(missionName, objective)
        {
            if (string.IsNullOrWhiteSpace(missionType))
                throw new ArgumentException("Mission type cannot be null or empty.", nameof(missionType));

            MissionType = missionType;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Provides a detailed description of the Mars mission, including its type.
        /// </summary>
        /// <returns>A string with the mission name, objective, and mission type.</returns>
        public string DetailedDescription()
        {
            return $"{MissionName}: {Objective} (Mission Type: {MissionType})";
        }

        #endregion
    }
}
