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
    /// Representa uma estação espacial orbital, com módulos específicos e capacidade de manutenção.
    /// </summary>
    public class OrbitalSpaceStation : SpaceStation
    {
        #region Propriedades

        /// <summary>
        /// A lista de módulos que a estação espacial possui.
        /// </summary>
        public List<string> Modules { get; }
       

        /// <summary>
        /// Indica se a estação espacial está em processo de manutenção.
        /// </summary>
        public bool IsUnderMaintenance { get; private set; }
       

       

    #endregion

    #region Construtores

    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="OrbitalSpaceStation"/>.
    /// </summary>
    /// <param name="name">O nome da estação espacial.</param>
    /// <param name="crewCapacity">A capacidade de tripulantes da estação espacial.</param>
    /// <param name="inaugurationDate">A data de inauguração da estação espacial.</param>
    /// <param name="modules">A lista de módulos da estação espacial.</param>
    public OrbitalSpaceStation(string name, int crewCapacity, DateTime inaugurationDate, List<string> modules)
            : base(name, crewCapacity, inaugurationDate)
        {
            // Valida que a lista de módulos não é nula
            if (modules == null || modules.Count == 0)
                throw new ArgumentException("A estação espacial deve ter pelo menos um módulo.", nameof(modules));

            Modules = modules;
            IsUnderMaintenance = false;  // A estação começa sem manutenção
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Inicia a manutenção da estação espacial, alterando o status para "em manutenção".
        /// </summary>
        public void StartMaintenance()
        {
            IsUnderMaintenance = true;
            Console.WriteLine($"A manutenção da estação {Name} foi iniciada.");
        }

        /// <summary>
        /// Finaliza a manutenção da estação espacial, alterando o status para "em operação".
        /// </summary>
        public void EndMaintenance()
        {
            IsUnderMaintenance = false;
            Console.WriteLine($"A manutenção da estação {Name} foi concluída.");
        }

        /// <summary>
        /// Adiciona um novo módulo à estação espacial.
        /// </summary>
        /// <param name="module">O nome do módulo a ser adicionado.</param>
        public void AddModule(string module)
        {
            if (string.IsNullOrWhiteSpace(module))
                throw new ArgumentException("O nome do módulo não pode ser nulo ou vazio.", nameof(module));

            Modules.Add(module);
            Console.WriteLine($"O módulo '{module}' foi adicionado à estação {Name}.");
        }

        /// <summary>
        /// Exibe informações sobre os módulos e o status de manutenção da estação espacial.
        /// </summary>
        /// <returns>Uma string com as informações detalhadas.</returns>
        public string GetOrbitalStationInfo()
        {
            string maintenanceStatus = IsUnderMaintenance ? "em manutenção" : "em operação";
            string modulesInfo = string.Join(", ", Modules);
            return $"{Name} - Capacidade de Tripulantes: {CrewCapacity} - Inauguração: {InaugurationDate:yyyy-MM-dd} - Status: {maintenanceStatus} - Módulos: {modulesInfo}";
        }

        #endregion
    }
}

