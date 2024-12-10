using System.Collections.Immutable;
using ModelsPOO.models.Launch;

namespace trab_poo
{
    internal static class Program
    {
        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Creating instances of the Astronaut class with different roles
            Astronaut astronaut1 = new Astronaut("John Doe", "Captain", AstronautRole.Commander);
            Astronaut astronaut2 = new Astronaut("Jane Smith", "Lieutenant", AstronautRole.Pilot);
            Astronaut astronaut3 = new Astronaut("Alice Johnson", "Specialist", AstronautRole.MissionSpecialist);

            // Preparing the astronauts for launch
            astronaut1.PrepareForLaunch();
            astronaut2.PrepareForLaunch();
            astronaut3.PrepareForLaunch();

            // Displaying the readiness status of the astronauts
            Console.WriteLine("\nAstronauts' Readiness for Launch:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{astronaut1.Name} ({astronaut1.Rank}) - Ready: {astronaut1.IsReadyForLaunch}");
            Console.WriteLine($"{astronaut2.Name} ({astronaut2.Rank}) - Ready: {astronaut2.IsReadyForLaunch}");
            Console.WriteLine($"{astronaut3.Name} ({astronaut3.Rank}) - Ready: {astronaut3.IsReadyForLaunch}");

            // Waiting for user input to close the console
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Initializing the Windows Forms application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_login());
            
            
         
        }
    }
}
