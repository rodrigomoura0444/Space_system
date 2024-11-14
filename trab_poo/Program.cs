
using System;
using ModelsPOO.models.Launch;
namespace trab_poo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       [STAThread]
        static void Main() 
            
        {
            // Creating instances of the Astronaut class with different roles
            Astronaut astronaut1 = new Astronaut("John Doe", "Captain", AstronautRole.Commander);
            Astronaut astronaut2 = new Astronaut("Jane Smith", "Lieutenant", AstronautRole.Pilot);
            Astronaut astronaut3 = new Astronaut("Alice Johnson", "Specialist", AstronautRole.MissionSpecialist);

            // Preparing astronauts for launch
            astronaut1.PrepareForLaunch();
            astronaut2.PrepareForLaunch();
            astronaut3.PrepareForLaunch();

            // Checking if astronauts are ready for launch
            Console.WriteLine($"{astronaut1.Name} is ready for launch: {astronaut1.IsReadyForLaunch}");
            Console.WriteLine($"{astronaut2.Name} is ready for launch: {astronaut2.IsReadyForLaunch}");
            Console.WriteLine($"{astronaut3.Name} is ready for launch: {astronaut3.IsReadyForLaunch}");

         

            
            Console.ReadLine();
          
          
            //ApplicationConfiguration.Initialize();
            Application.Run(new Form_login());








        }
    }
}