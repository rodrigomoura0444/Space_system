//-----------------------------------------------------------------
//    <copyright file="Launch.cs" company="IPCA">
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
    /// Class representing a launch mission, including the mission name,
    /// launch date, and the associated rocket.
    /// </summary>
    public class CLaunch
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the mission (e.g., "Apollo 11").
        /// </summary>
        public string MissionName { get; set; }

        /// <summary>
        /// Gets the date of the launch. This property is read-only externally.
        /// </summary>
        public DateTime LaunchDate { get; private set; }

        /// <summary>
        /// Gets the name of the rocket used for the mission. This property is read-only externally.
        /// </summary>
        public string RocketName { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CLaunch"/> class with mission name, launch date, and rocket name.
        /// </summary>
        /// <param name="missionName">The name of the mission (e.g., "Apollo 11").</param>
        /// <param name="launchDate">The scheduled date for the launch (must be in the future).</param>
        /// <param name="rocketName">The name of the rocket used for the mission (e.g., "Falcon 9").</param>
        /// <exception cref="ArgumentException">Thrown if any parameter is invalid (e.g., empty or past date).</exception>
        public CLaunch(string missionName, DateTime launchDate, string rocketName)
        {
            // Validate that mission name is not null or empty
            if (string.IsNullOrWhiteSpace(missionName))
                throw new ArgumentException("Mission name cannot be null or empty.", nameof(missionName));

            // Validate that rocket name is not null or empty
            if (string.IsNullOrWhiteSpace(rocketName))
                throw new ArgumentException("Rocket name cannot be null or empty.", nameof(rocketName));

            // Validate that the launch date is in the future
            if (launchDate <= DateTime.Now)
                throw new ArgumentException("Launch date must be in the future.", nameof(launchDate));

            // Assign values to properties
            MissionName = missionName;
            LaunchDate = launchDate;
            RocketName = rocketName;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Calculates how many days are left until the launch.
        /// </summary>
        /// <returns>The number of days until the launch. Returns 0 if the launch date is today or in the past.</returns>
        public int DaysUntilLaunch()
        {
            int daysUntil = (LaunchDate - DateTime.Now).Days;
            return daysUntil > 0 ? daysUntil : 0;
        }

        /// <summary>
        /// Returns a brief summary of the mission, including the mission name and the scheduled launch date.
        /// </summary>
        /// <returns>A string with the mission name and the launch date in a readable format.</returns>
        public string BasicInfo()
        {
            return $"{MissionName} scheduled for {LaunchDate:MMMM dd, yyyy}";
        }

        #endregion
    }
}
