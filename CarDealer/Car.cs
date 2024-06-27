namespace CarDealer;

public class Car
{
    public string Make { get; private set; }
    public string Model { get; private set; }
    public int ModelYear { get; private set; }
    private string LicensePlate { get; set; }
    public int Mileage { get; private set; }
    private string Fuel { get; set; }
    private string Gearbox { get; set; }

    public Car(string make, string model, int modelYear, string licensePlate, int mileage, string fuel, string gearbox)
    {
        Make = make;
        Model = model;
        ModelYear = modelYear;
        LicensePlate = licensePlate;
        Mileage = mileage;
        Fuel = fuel;
        Gearbox = gearbox;
    }

    public Car()
    {
    }

    internal void PrintCarInfo(Car car)
    {
        Console.WriteLine($"Make: {car.Make}");
        Console.WriteLine($"Model: {car.Model}");
        Console.WriteLine($"Model Year: {car.ModelYear}");
        Console.WriteLine($"License Plate: {car.LicensePlate}");
        Console.WriteLine($"Mileage: {car.Mileage}");
        Console.WriteLine($"Fuel: {car.Fuel}");
        Console.WriteLine($"Gearbox: {car.Gearbox}");
        Console.WriteLine();
    }
}