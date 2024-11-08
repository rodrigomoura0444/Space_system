//-----------------------------------------------------------------
//    <copyright file="Launch.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace Launch
{
    /// <summary>
    /// Represents a space mission launch with information about the mission, date, and rocket.
    /// </summary>
    public class Launch
    {
        #region Public Properties

        /// <summary>
        /// The name of the space mission.
        /// </summary>
        public string MissionName { get;  set; }

        /// <summary>
        /// The date of the launch.
        /// </summary>
        public DateTime LaunchDate { get; private set; }

        /// <summary>
        /// The name of the rocket used for the launch.
        /// </summary>
        public string RocketName { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to initialize a launch with mission name, launch date, and rocket name.
        /// </summary>
        /// <param name="missionName">The name of the mission.</param>
        /// <param name="launchDate">The date of the launch.</param>
        /// <param name="rocketName">The name of the rocket.</param>
        /// <exception cref="ArgumentException">Thrown when the mission name or rocket name is null or empty, or if the launch date is in the past.</exception>
        public Launch(string missionName, DateTime launchDate, string rocketName)
        {
            if (string.IsNullOrWhiteSpace(missionName))
                throw new ArgumentException("Mission name cannot be null or empty.", nameof(missionName));

            if (string.IsNullOrWhiteSpace(rocketName))
                throw new ArgumentException("Rocket name cannot be null or empty.", nameof(rocketName));

            if (launchDate <= DateTime.Now)
                throw new ArgumentException("Launch date must be in the future.", nameof(launchDate));

            MissionName = missionName;
            LaunchDate = launchDate;
            RocketName = rocketName;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns the number of days remaining until the launch.
        /// </summary>
        /// <returns>Number of days until the launch. If the launch date has passed, returns 0.</returns>
        public int DaysUntilLaunch()
        {
            int daysUntil = (LaunchDate - DateTime.Now).Days;
            return daysUntil > 0 ? daysUntil : 0;
        }

        /// <summary>
        /// Returns a simple string with the mission name and launch date formatted.
        /// </summary>
        /// <returns>A basic information string with the mission name and launch date.</returns>
        public string BasicInfo()
        {
            return $"{MissionName} scheduled for {LaunchDate:MMMM dd, yyyy}";
        }

        #endregion
    }
}
