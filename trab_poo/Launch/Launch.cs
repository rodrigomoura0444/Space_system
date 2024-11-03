namespace launch
{
    public class Launch
    {
        public string MissionName { get; set; }
        public DateTime LaunchDate { get; set; }
        public string RocketName { get; set; }

        public Launch(string missionName, DateTime launchDate, string rocketName)
        {
            MissionName = missionName;
            LaunchDate = launchDate;
            RocketName = rocketName;
        }

        public override string ToString()
        {
            return $"Mission: {MissionName}, Date: {LaunchDate.ToShortDateString()}, Rocket: {RocketName}";
        }

        // Retorna se o lançamento é futuro ou passado
        public string LaunchStatus()
        {
            return DateTime.Now < LaunchDate ? "Upcoming" : "Completed";
        }

        // Retorna o número de dias restantes até o lançamento
        public int DaysUntilLaunch()
        {
            return (LaunchDate - DateTime.Now).Days;
        }

        // Retorna uma string simples com o nome da missão e data do lançamento
        public string BasicInfo()
        {
            return $"{MissionName} scheduled for {LaunchDate:MMMM dd, yyyy}";
        }
    }
}
