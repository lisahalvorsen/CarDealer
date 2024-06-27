namespace CarDealer;

public class CarShop
{
    private readonly Customer _customer = new Customer();
    private readonly Car _newCar = new Car();

    private readonly List<Car> _allCars =
    [
        new Car(make: "Volkswagen", model: "Golf", modelYear: 2022, licensePlate: "ZE90000", mileage: 100000,
            fuel: "Diesel", gearbox: "Automatic"),
        new Car(make: "Toyota", model: "Yaris", modelYear: 2019, licensePlate: "ZE89100", mileage: 100432,
            fuel: "Gasoline", gearbox: "Manual"),
        new Car(make: "Volkswagen", model: "Polo", modelYear: 2023, licensePlate: "ZE89235", mileage: 99320,
            fuel: "Diesel", gearbox: "Manual"),
        new Car(make: "Tesla", model: "Model S", modelYear: 2024, licensePlate: "EL10010", mileage: 20347,
            fuel: "Electricity", gearbox: "Automatic"),
        new Car(make: "Nissan", model: "Leaf", modelYear: 2022, licensePlate: "ZE93209", mileage: 58900,
            fuel: "Electricity", gearbox: "Automatic")
    ];

    internal void ShowAllCars()
    {
        Console.Clear();
        if (_allCars.Count == 0)
        {
            Console.WriteLine($"We don't have any cars to sell, sorry. Please come back another time!");
        }
        else
        {
            Console.WriteLine("In the shop, we have these cars:");
            var mergeCarMakes = string.Join(", ", _allCars.Select(car => car.Make));
            Console.WriteLine($"{mergeCarMakes}.\n");
        }
    }

    internal void GetCarInfo()
    {
        Console.WriteLine("Which car do you want to know more about? Type in the make");
        var carMake = Console.ReadLine();
        Console.WriteLine("Then type in the model");
        var carModel = Console.ReadLine();

        var car = _allCars.FirstOrDefault(car => car.Make == carMake && car.Model == carModel);

        if (car != null)
        {
            _newCar.PrintCarInfo(car);
        }
        else
        {
            Console.WriteLine("Sorry, it doesn't look like we have the car you're looking for. Please try again.\n");
        }
    }

    internal void FindCarModelYear()
    {
        Console.Clear();
        Console.WriteLine("What model year are you looking for?");
        var findCarModelYear = int.Parse(Console.ReadLine());
        var carExists =
            _allCars.Any(car =>
                car.ModelYear == findCarModelYear); // checks if any of the cars in _allCars matches the input

        if (!carExists)
        {
            Console.WriteLine($"No cars were found with the model year {findCarModelYear}\n");
        }
        else
        {
            var foundCar =
                _allCars.Where(car => car.ModelYear == findCarModelYear)
                    .ToList(); // selects all the elements in _allCars that matches the input and returns a list
            Console.WriteLine($"The car(s) with model year from {findCarModelYear} are:");
            foreach (var car in foundCar)
            {
                Console.WriteLine($"{car.Make}, {car.Model}.");
            }
        }
    }

    internal void FindCarMileage()
    {
        Console.Clear();
        Console.WriteLine("What mileage are you interested in?");
        var carMileage = int.Parse(Console.ReadLine());

        if (carMileage == 0)
        {
            Console.WriteLine("There are no cars with a mileage of 0 km.\n");
            return;
        }

        var carsWithLowerOrEqualMileage = _allCars.Where(car => car.Mileage <= carMileage).ToList();
        if (carsWithLowerOrEqualMileage.Count > 0)
        {
            Console.WriteLine($"\nCars with mileage of {carMileage} km or less:");
            foreach (var car in carsWithLowerOrEqualMileage)
            {
                Console.WriteLine($"{car.Make} {car.Model}, {car.Mileage}.");
            }
        }

        var carsWithHigherOrEqualMileage = _allCars.Where(car => car.Mileage >= carMileage).ToList();
        if (carsWithHigherOrEqualMileage.Count > 0)
        {
            Console.WriteLine($"\nCars with mileage of {carMileage} km or more:");
            foreach (var car in carsWithHigherOrEqualMileage)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Mileage}.");
            }
        }
    }

    internal void BuyCar()
    {
        Console.WriteLine("Which car do you want to buy? Type in the car make");
        var carMake = Console.ReadLine();
        Console.WriteLine("Then type in the car model");
        var carModel = Console.ReadLine();
        var car = _allCars.FirstOrDefault(car => car.Make == carMake && car.Model == carModel);

        if (car != null)
        {
            _customer.MyCars.Add(car);
            _allCars.RemoveAll(c => c.Make == carMake && c.Model == carModel);

            Console.WriteLine("\nCongratulations with your new car purchase! A lovely");
            foreach (var boughtCar in _customer.MyCars)
            {
                Console.WriteLine($"{boughtCar.Make} {boughtCar.Model}");
            }
        }
        else
        {
            Console.WriteLine($"We're sorry that we couldn't find the car you're looking for. Please try again.\n");
        }
    }
}