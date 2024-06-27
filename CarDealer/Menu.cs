namespace CarDealer;

public class Menu
{
    private readonly CarShop _carShop = new CarShop();
    internal void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the car dealer! What do you want to do?");
            Console.WriteLine("1. View all cars");
            Console.WriteLine("2. Get more information about a car");
            Console.WriteLine("3. Find a car based on model year");
            Console.WriteLine("4. Find a car based on mileage");
            Console.WriteLine("5. Buy a car");
            Console.WriteLine("6. Exit shop\n");
            MenuSelection();
        }
    }

    private void MenuSelection()
    {
        var choice = Console.ReadKey(true).KeyChar - '0';
        switch (choice) 
        {
            case 1:
                _carShop.ShowAllCars();
                break;
            case 2:
                _carShop.GetCarInfo();
                break;
            case 3:
                _carShop.FindCarModelYear();
                break;
            case 4:
                _carShop.FindCarMileage();
                break;
            case 5:
                _carShop.BuyCar();
                break;
            case 6:
                ExitShop();
                break;
            default:
                Console.WriteLine("Invalid input, please try again.\n");
                break;
        }
    }

    private static void ExitShop()
    {
        Console.WriteLine("Welcome back any time! :D");
        Environment.Exit(0);
    }
}