namespace Mission
{
    public class Mission
{
    public string MissionName { get; set; }
    public string Objective { get; set; }


    public Mission(string missionName, string objective)
    {
        MissionName = missionName;
        Objective = objective;
    }

    public override string ToString()
    {
        return $"{MissionName} - Objective: {Objective}";
    }

    // Retorna uma descrição curta da missão
    public string ShortDescription()
    {
        return $"{MissionName}: {Objective}";
    }

    // Verifica se a missão tem um objetivo específico
    public bool HasObjective(string searchObjective)
    {
        return Objective.IndexOf(searchObjective, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // Formata o nome da missão em letras maiúsculas
    public string GetMissionNameUppercase()
    {
        return MissionName.ToUpper();
    }

    
    public int ObjectiveWordCount()
    {

        return Objective.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
}
   