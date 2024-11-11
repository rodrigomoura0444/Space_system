//-----------------------------------------------------------------
//    <copyright file="Mission.cs" company="IPCA">
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
    /// Represents a space mission with its name and objective.
    /// </summary>
    public class CMission
    {
        #region Properties

        /// <summary>
        /// The name of the mission (e.g., "Mars 2024").
        /// </summary>
        public string MissionName { get; }

        /// <summary>
        /// The objective of the mission (e.g., "Land on Mars").
        /// </summary>
        public string Objective { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CMission"/> class.
        /// </summary>
        /// <param name="missionName">The name of the mission.</param>
        /// <param name="objective">The objective of the mission.</param>
        /// <exception cref="ArgumentException">Thrown when missionName or objective is null or empty.</exception>
        public CMission(string missionName, string objective)
        {
            // Validate that mission name is not null or empty
            if (string.IsNullOrWhiteSpace(missionName))
                throw new ArgumentException("Mission name cannot be null or empty.", nameof(missionName));

            // Validate that mission objective is not null or empty
            if (string.IsNullOrWhiteSpace(objective))
                throw new ArgumentException("Mission objective cannot be null or empty.", nameof(objective));

            // Assign values to properties
            MissionName = missionName;
            Objective = objective;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a short description of the mission.
        /// </summary>
        /// <returns>A string with the mission name and objective.</returns>
        public string ShortDescription()
        {
            return $"{MissionName}: {Objective}";
        }

        /// <summary>
        /// Checks if the mission has a specific objective.
        /// </summary>
        /// <param name="searchObjective">The objective to search for.</param>
        /// <returns>True if the objective contains the search string, otherwise false.</returns>
        public bool HasObjective(string searchObjective)
        {
            if (string.IsNullOrWhiteSpace(searchObjective))
                throw new ArgumentException("Search objective cannot be null or empty.", nameof(searchObjective));

            return Objective.IndexOf(searchObjective, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        #endregion

        #region Override Methods

        /// <summary>
        /// Returns a string representation of the mission.
        /// </summary>
        /// <returns>A string that contains the mission name and objective.</returns>
        public override string ToString()
        {
            return $"{MissionName} - Objective: {Objective}";
        }

        #endregion
    }
}
