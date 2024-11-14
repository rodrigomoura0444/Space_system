// launch interface

namespace ModelsPOO.models.Launch
{
    public interface ILaunchableMission
    {
        /// <summary>
        /// Calculates how many days are left until the launch
        /// </summary>
        int DaysUntilLaunch();

        /// <summary>
        /// Provides information about the mission , simple information
        /// </summary>
        string BasicInfo();
    }
}

