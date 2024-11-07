namespace launch
{
    public class Launch
    {
        public string MissionName { get; set; } // name of the mission
        public DateTime LaunchDate { get; set; } // date of the mission
        public string RocketName { get; set; } // e.g , dragon , falcon9 , falcon eavy

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

        //  return if the launch is in the past or in the future
        public string LaunchStatus()
        {
            return DateTime.Now < LaunchDate ? "Upcoming" : "Completed";
        }

        //  return how many days until the launch 
        public int DaysUntilLaunch()
        {
            return (LaunchDate - DateTime.Now).Days;
        }

        //  return a simple string with the name of the mission and the launch date 
        public string BasicInfo()
        {
            return $"{MissionName} scheduled for {LaunchDate:MMMM dd, yyyy}";
        }
    }
}
