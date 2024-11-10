using System;

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
        public int MissionDuration { get; private set; }

        /// <summary>
        /// Indicates whether the mission is manned or unmanned.
        /// </summary>
        public bool IsManned { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MarsMission class.
        /// </summary>
        /// <param name="missionName">The name of the mission.</param>
        /// <param name="objective">The objective of the mission.</param>
        /// <param name="missionDuration">The duration of the mission in days.</param>
        /// <param name="isManned">True if the mission is manned; otherwise, false.</param>
        /// <exception cref="ArgumentException">Thrown when the mission name, objective, or mission duration is invalid.</exception>
        public MarsMission(string missionName, string objective, int missionDuration, bool isManned)
            : base(missionName, objective)
        {
            if (string.IsNullOrWhiteSpace(missionName))
                throw new ArgumentException("Mission name cannot be null or empty.", nameof(missionName));

            if (string.IsNullOrWhiteSpace(objective))
                throw new ArgumentException("Objective cannot be null or empty.", nameof(objective));

            if (missionDuration <= 0)
                throw new ArgumentException("Mission duration must be a positive number.", nameof(missionDuration));

            MissionDuration = missionDuration;
            IsManned = isManned;
        }

        /// <summary>
        /// Updates the mission duration, if needed.
        /// </summary>
        /// <param name="newDuration">The new mission duration in days.</param>
        /// <exception cref="ArgumentException">Thrown when the new duration is not positive.</exception>
        public void UpdateMissionDuration(int newDuration)
        {
            if (newDuration <= 0)
                throw new ArgumentException("Mission duration must be a positive number.", nameof(newDuration));

            MissionDuration = newDuration;
        }

        /// <summary>
        /// Calculates the end date of the mission based on a given start date.
        /// </summary>
        /// <param name="startDate">The start date of the mission.</param>
        /// <returns>The end date of the mission.</returns>
        public DateTime CalculateEndDate(DateTime startDate)
        {
            return startDate.AddDays(MissionDuration);
        }

        /// <summary>
        /// Returns a string representation of the Mars mission.
        /// </summary>
        /// <returns>A string with the mission details.</returns>
        public override string ToString()
        {
            string missionType = IsManned ? "Manned" : "Unmanned";
            return $"{base.ToString()} - Objective: {Objective} - Duration: {MissionDuration} days - Type: {missionType}";
        }
    }
}
