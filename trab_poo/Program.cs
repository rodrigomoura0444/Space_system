using ModelsPOO.models.Launch;

namespace trab_poo
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal da aplica��o.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Criando inst�ncias da classe Astronaut com diferentes fun��es
            Astronaut astronaut1 = new Astronaut("John Doe", "Captain",AstronautRole.Commander);
            Astronaut astronaut2 = new Astronaut("Jane Smith", "Lieutenant", AstronautRole.Pilot);
            Astronaut astronaut3 = new Astronaut("Alice Johnson", "Specialist", AstronautRole.MissionSpecialist);

            // Preparando os astronautas para o lan�amento
            astronaut1.PrepareForLaunch();
            astronaut2.PrepareForLaunch();
            astronaut3.PrepareForLaunch();

            // Exibindo o estado de prontid�o dos astronautas
            Console.WriteLine("\nAstronauts' Readiness for Launch:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{astronaut1.Name} ({astronaut1.Rank}) - Ready: {astronaut1.IsReadyForLaunch}");
            Console.WriteLine($"{astronaut2.Name} ({astronaut2.Rank}) - Ready: {astronaut2.IsReadyForLaunch}");
            Console.WriteLine($"{astronaut3.Name} ({astronaut3.Rank}) - Ready: {astronaut3.IsReadyForLaunch}");

            // Aguardando entrada do usu�rio para encerrar o console
            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();

            // Inicializando a aplica��o Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_login());
        }
    }
}
