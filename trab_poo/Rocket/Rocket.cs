public class Rocket
{
    public string RocketName { get; set; }
    public string FuelType { get; set; }
    public int Capacity { get; set; }       // Número de pessoas que o foguete pode transportar
    public double MaxPayload { get; set; }   // Capacidade máxima de carga em toneladas

    public Rocket(string rocketName, string fuelType, int capacity, double maxPayload)
    {
        RocketName = rocketName;
        FuelType = fuelType;
        Capacity = capacity;
        MaxPayload = maxPayload;
    }

    // Verifica se o foguete pode transportar uma carga específica
    public bool CanCarryPayload(double payloadWeight)
    {
        return payloadWeight <= MaxPayload;
    }

    // Retorna uma descrição simples do foguete
    public string BasicInfo()
    {
        return $"{RocketName}: {FuelType} fuel, Capacity: {Capacity} people, Max Payload: {MaxPayload} tons";
    }

    public override string ToString()
    {
        return BasicInfo();
    }
}
