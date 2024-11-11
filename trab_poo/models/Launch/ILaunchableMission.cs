namespace ModelsPOO.models.Launch
{
    public interface ILaunchableMission
    {
        /// <summary>
        /// Calculates how many days are left until the launch.
        /// </summary>
        int DaysUntilLaunch();

        /// <summary>
        /// Provides basic information about the mission.
        /// </summary>
        string BasicInfo();
    }
}
