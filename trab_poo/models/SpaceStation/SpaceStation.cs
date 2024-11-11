//-----------------------------------------------------------------
//    <copyright file="SpaceStation.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>11-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Rodrigo Moura</author>
//-----------------------------------------------------------------

namespace ModelsPOO.models.SpaceAgency
{
    /// <summary>
    /// Representa uma estação espacial com nome, capacidade de tripulação e data de inauguração.
    /// </summary>
    public class SpaceStation
    {
        #region Propriedades

        /// <summary>
        /// O nome da estação espacial (por exemplo, "Estação Espacial Internacional").
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// A capacidade de tripulantes da estação espacial.
        /// </summary>
        public int CrewCapacity { get; }

        /// <summary>
        /// A data de inauguração da estação espacial.
        /// </summary>
        public DateTime InaugurationDate { get; }

        #endregion

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="SpaceStation"/>.
        /// </summary>
        /// <param name="name">O nome da estação espacial.</param>
        /// <param name="crewCapacity">A capacidade de tripulantes da estação espacial.</param>
        /// <param name="inaugurationDate">A data de inauguração da estação espacial.</param>
        /// <exception cref="ArgumentException">Lançado quando o nome da estação é nulo ou vazio, ou a capacidade de tripulantes é não positiva.</exception>
        public SpaceStation(string name, int crewCapacity, DateTime inaugurationDate)
        {
            // Valida que o nome da estação não é nulo ou vazio
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("O nome da estação não pode ser nulo ou vazio.", nameof(name));

            // Valida que a capacidade de tripulantes é um número positivo
            if (crewCapacity <= 0)
                throw new ArgumentException("A capacidade de tripulantes deve ser maior que zero.", nameof(crewCapacity));

            // Valida que a data de inauguração não está no futuro
            if (inaugurationDate > DateTime.Now)
                throw new ArgumentException("A data de inauguração não pode ser no futuro.", nameof(inaugurationDate));

            // Atribui valores às propriedades
            Name = name;
            CrewCapacity = crewCapacity;
            InaugurationDate = inaugurationDate;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Simula a operação da estação espacial, exibindo seu nome e a capacidade de tripulantes.
        /// </summary>
        public void OperateStation()
        {
            Console.WriteLine($"A estação espacial {Name} com capacidade para {CrewCapacity} tripulantes está operacional desde {InaugurationDate:yyyy-MM-dd}.");
        }

        /// <summary>
        /// Retorna uma descrição da estação espacial.
        /// </summary>
        /// <returns>Uma string com o nome da estação, a capacidade de tripulantes e a data de inauguração.</returns>
        public string GetStationInfo()
        {
            return $"{Name} - Capacidade de Tripulantes: {CrewCapacity} - Inauguração: {InaugurationDate:yyyy-MM-dd}";
        }

        #endregion
    }
}
