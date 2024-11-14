namespace ModelsPOO.models.Launch
{
    /// <summary>
    /// Class representing a launch mission, including the mission name,
    /// launch date, and the associated rocket.
    /// </summary>
    public class CLaunch : ILaunchableMission
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the mission like Apollo 11
        /// </summary>
        public string MissionName { get; set; }

        /// <summary>
        /// Gets the date of the launch
        /// </summary>
        public DateTime LaunchDate { get; private set; }

        /// <summary>
        /// Gets the name of the rocket used for the mission
        /// </summary>
        public string RocketName { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CLaunch"/> class with mission name, launch date, and rocket name.
        /// </summary>
        /// <param name="missionName">The name of the mission</param> 
        /// <param name="launchDate">The scheduled date for the launch (must be in the future).</param>
        /// <param name="rocketName">The name of the rocket used for the mission </param>
        /// <exception cref="ArgumentException">Thrown if any parameter is invalid ( empty or past date).</exception>
        public CLaunch(string missionName, DateTime launchDate, string rocketName)
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
        /// Calculates how many days are left until the launch.
        /// </summary>
        public int DaysUntilLaunch()
        {
            int daysUntil = (LaunchDate - DateTime.Now).Days;
            return daysUntil > 0 ? daysUntil : 0;
        }

        /// <summary>
        /// Returns a brief summary of the mission, including the mission name and the scheduled launch date.
        /// </summary>
        public string BasicInfo()
        {
            return $"{MissionName} scheduled for {LaunchDate:MMMM dd, yyyy}";
        }

        #endregion
    }
}
