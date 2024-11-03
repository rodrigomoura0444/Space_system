public class Rocket
{
    public string RocketName { get; set; }
    public string FuelType { get; set; }
    public int Capacity { get; set; }
    public double MaxPayload { get; set; }

    public Rocket(string rocketName, string fuelType, int capacity, double maxPayload)
    {
        RocketName = rocketName;
        FuelType = fuelType;
        Capacity = capacity;
        MaxPayload = maxPayload;
    }

    // Método para verificar se o foguete é adequado para uma missão com uma carga específica
    public bool CanCarryPayload(double payloadWeight)
    {
        return payloadWeight <= MaxPayload;
    }

    public override string ToString()
    {
        return $"{RocketName} (Fuel: {FuelType}, Capacity: {Capacity}, Max Payload: {MaxPayload} tons)";
    }
}
