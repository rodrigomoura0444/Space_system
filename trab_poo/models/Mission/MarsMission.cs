namespace ModelsPOO.models.Mission
{
    /// <summary>
    /// Represents a mission specifically targeting Mars.
    /// </summary>
    public class MarsMission : CMission
    {
        /// <summary>
        /// The duration of the Mars mission in days.
        /// </summary>
        public int MissionDuration { get; }

        /// <summary>
        /// Indicates whether the mission is manned or unmanned.
        /// </summary>
        public bool IsManned { get; }

        /// <summary>
        /// Initializes a new instance of the MarsMission class.
        /// </summary>
        /// <param name="missionName">The name of the mission.</param>
        /// <param name="objective">The objective of the mission.</param>
        /// <param name="missionDuration">The duration of the mission in days.</param>
        /// <param name="isManned">True if the mission is manned; otherwise, false.</param>
        public MarsMission(string missionName, string objective, int missionDuration, bool isManned)
            : base(missionName, objective)
        {
            if (missionDuration <= 0)
                throw new ArgumentException("Mission duration must be a positive number.", nameof(missionDuration));

            MissionDuration = missionDuration;
            IsManned = isManned;
        }

        /// <summary>
        /// Returns a string representation of the Mars mission.
        /// </summary>
        /// <returns>A string with the mission details.</returns>
        public override string ToString()
        {
            string missionType = IsManned ? "Manned" : "Unmanned";
            return $"{base.ToString()} - Duration: {MissionDuration} days - Type: {missionType}";
        }
    }
}
