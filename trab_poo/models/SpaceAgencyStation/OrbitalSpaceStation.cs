//-----------------------------------------------------------------
//    <copyright file="OrbitalSpaceStation.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>11-11-2024</date>
//    <time>22:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

using System.Diagnostics.Contracts;

namespace ModelsPOO.models.SpaceAgency
{
    /// <summary>
    /// Represents an orbital space station, with specific modules and maintenance capability.
    /// </summary>
    public class OrbitalSpaceStation : SpaceStation
    {
        #region Properties

        /// <summary>
        /// The list of modules the space station has.
        /// </summary>
        public List<string> Modules { get; }


        /// <summary>
        /// Indicates if the space station is undergoing maintenance.
        /// </summary>
        public bool IsUnderMaintenance { get; private set; }




        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrbitalSpaceStation"/> class.
        /// </summary>
        /// <param name="name">The name of the space station.</param>
        /// <param name="crewCapacity">The crew capacity of the space station.</param>
        /// <param name="inaugurationDate">The inauguration date of the space station.</param>
        /// <param name="modules">The list of modules of the space station.</param>
        public OrbitalSpaceStation(string name, int crewCapacity, DateTime inaugurationDate, List<string> modules)
                : base(name, crewCapacity, inaugurationDate)
        {
            // Validates that the list of modules is not null
            if (modules == null || modules.Count == 0)
                throw new ArgumentException("The space station must have at least one module.", nameof(modules));

            Modules = modules;
            IsUnderMaintenance = false;  // The station starts without maintenance
        }

        #endregion

        #region Methods

        /// <summary>
        /// Starts the maintenance of the space station, changing the status to "under maintenance".
        /// </summary>
        public void StartMaintenance()
        {
            IsUnderMaintenance = true;
            Console.WriteLine($"The maintenance of the station {Name} has started.");
        }

        /// <summary>
        /// Ends the maintenance of the space station, changing the status to "operational".
        /// </summary>
        public void EndMaintenance()
        {
            IsUnderMaintenance = false;
            Console.WriteLine($"The maintenance of the station {Name} has been completed.");
        }

        /// <summary>
        /// Adds a new module to the space station.
        /// </summary>
        /// <param name="module">The name of the module to be added.</param>
        public void AddModule(string module)
        {
            if (string.IsNullOrWhiteSpace(module))
                throw new ArgumentException("The module name cannot be null or empty.", nameof(module));

            Modules.Add(module);
            Console.WriteLine($"The module '{module}' has been added to the station {Name}.");
        }

        /// <summary>
        /// Displays information about the modules and the maintenance status of the space station.
        /// </summary>
        /// <returns>A string with detailed information.</returns>
        public string GetOrbitalStationInfo()
        {
            string maintenanceStatus = IsUnderMaintenance ? "under maintenance" : "operational";
            string modulesInfo = string.Join(", ", Modules);
            return $"{Name} - Crew Capacity: {CrewCapacity} - Inauguration: {InaugurationDate:yyyy-MM-dd} - Status: {maintenanceStatus} - Modules: {modulesInfo}";
        }

        #endregion
    }
}
