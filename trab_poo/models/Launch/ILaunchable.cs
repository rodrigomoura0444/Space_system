
// astronaut interface
namespace ModelsPOO.models.Launch
{
    public interface ILaunchable
    {
        /// <summary>
        /// Method to simulate the preparation for launch.
        /// </summary>
        void PrepareForLaunch();

        /// <summary>
        /// Property to check if the astronaut is ready for launch.
        /// </summary>
        bool IsReadyForLaunch { get; }
    }
}
