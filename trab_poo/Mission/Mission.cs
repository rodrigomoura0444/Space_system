public class Mission
{
    public string MissionName { get; set; }
    public string MissionType { get; set; }
    public int DurationDays { get; set; }

    public Mission(string missionName, string missionType, int durationDays)
    {
        MissionName = missionName;
        MissionType = missionType;
        DurationDays = durationDays;
    }

    // Método para verificar se a missão é de longo prazo
    public bool IsLongDuration()
    {
        return DurationDays > 30;
    }

    public override string ToString()
    {
        return $"{MissionName} - {MissionType} Mission ({DurationDays} days)";
    }
}
