using System.Collections.Generic;
using System.Linq;

namespace SpaceAgency
{
    public class SpaceAgency
    {
        public string AgencyName { get; set; }
        public string Country { get; set; }
        public List<Rocket> Rockets { get; set; } = new List<Rocket>();

        public SpaceAgency(string agencyName, string country)
        {
            AgencyName = agencyName;
            Country = country;
        }

        public void AddRocket(Rocket rocket)
        {
            Rockets.Add(rocket);
        }

        public override string ToString()
        {
            return $"{AgencyName} ({Country}) - {Rockets.Count} rockets available";
        }

        // Função para contar o número de foguetes disponíveis
        public int RocketCount()
        {
            return Rockets.Count;
        }

        // Função para listar o nome de todos os foguetes
        public List<string> GetRocketNames()
        {
            return Rockets.Select(r => r.RocketName).ToList();
        }

    }
}
