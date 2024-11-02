public class Rocket
{
    public string RocketName { get; set; }
    public string FuelType { get; set; }
    public int Capacity { get; set; }  // Maximum number of astronauts

    public Rocket(string rocketName, string fuelType, int capacity)
    {
        RocketName = rocketName;
        FuelType = fuelType;
        Capacity = capacity;
    }

    public override string ToString()
    {
        return $"{RocketName} (Fuel: {FuelType}, Capacity: {Capacity})";
    }
}
