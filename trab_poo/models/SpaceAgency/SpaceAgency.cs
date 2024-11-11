//-----------------------------------------------------------------
//    <copyright file="SpaceAgency.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using ModelsPOO.models.Launch;

namespace ModelsPOO.models.SpaceAgency
{
    /// <summary>
    /// Represents a space agency with details about its rockets.
    /// </summary>
    public class SpaceAgency
    {
        #region Public Properties

        /// <summary>
        /// The name of the space agency.
        /// </summary>
        public string AgencyName { get; private set; }

        /// <summary>
        /// The country where the space agency is based.
        /// </summary>  
        public string Country { get; private set; }

        /// <summary>
        /// A list of rockets owned by the space agency.
        /// </summary>
        public List<Rocket> Rockets { get; private set; } = new List<Rocket>();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the SpaceAgency class.
        /// </summary>
        /// <param name="agencyName">The name of the space agency.</param>
        /// <param name="country">The country where the space agency is based.</param>
        public SpaceAgency(string agencyName, string country)
        {
            AgencyName = agencyName;
            Country = country;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a rocket to the space agency's collection.
        /// </summary>
        /// <param name="rocket">The rocket to be added.</param>
        public void AddRocket(Rocket rocket)
        {
            if (rocket != null)
            {
                Rockets.Add(rocket);
            }
        }

        /// <summary>
        /// Provides a string representation of the space agency.
        /// </summary>
        /// <returns>A string containing the agency's name, country, and the number of rockets available.</returns>
        public override string ToString()
        {
            return $"{AgencyName} ({Country}) - {Rockets.Count} rocket{(Rockets.Count != 1 ? "s" : "")} available";
        }

        /// <summary>
        /// Returns a list of the names of all rockets in the agency's collection.
        /// </summary>
        /// <returns>A list of rocket names.</returns>
        public List<string> GetRocketNames()
        {
            return Rockets.Select(r => r.RocketName).ToList();
        }

        #endregion
    }
}