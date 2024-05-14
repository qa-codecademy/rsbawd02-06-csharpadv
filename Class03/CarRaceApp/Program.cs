// See https://aka.ms/new-console-template for more information

using CarRaceApp;

Car car1 = new Car
{
    Model = "Hyundai",
    Speed = 100
};

Car car2 = new Car();
car2.Model = "Mazda";
car2.Speed = 120;

Car car3 = new()
{
    Model = "Ferrari",
    Speed = 150
};

Car car4 = new()
{
    Model = "Porsche",
    Speed = 140
};

Car car5 = new Car {Model = "Test"};

Car[] cars = [car1, car2, car3, car4];
Driver[] drivers = new[]
{
    new Driver { Name = "Bob", Skill = 0.8m },
    new Driver { Name = "Greg", Skill = 0.9m },
    new Driver { Name = "Jill", Skill = 1.05m },
    new Driver { Name = "Anne", Skill = 0.95m }
};

Console.WriteLine("+++ Cars and drivers +++");

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cars[i].Model} - {cars[i].Speed} kmph");
}
Console.WriteLine("Select first car (1-4): ");

var userInput = Console.ReadLine();
if (!int.TryParse(userInput, out int car1Index))
{
    Console.WriteLine("Invalid input. Please enter a number.");
    return;
}

var selectedCar1 = cars[car1Index - 1];

for (int i = 0; i < drivers.Length; i++)
{
    Console.WriteLine($"{i + 1}. {drivers[i].Name} - {drivers[i].Skill}");
}
Console.WriteLine("Select first driver (1-4): ");
var driver1Index = int.Parse(Console.ReadLine()) - 1;
selectedCar1.Driver = drivers[driver1Index];

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cars[i].Model} - {cars[i].Speed} kmph");
}
Console.WriteLine("Select second car (1-4): ");
var car2Index = int.Parse(Console.ReadLine()) - 1;

while (car1Index == car2Index)
{
    Console.WriteLine("Car already selected. Please select another car.");
    car2Index = int.Parse(Console.ReadLine()) - 1;
}

var selectedCar2 = cars[car2Index];

for (int i = 0; i < drivers.Length; i++)
{
    Console.WriteLine($"{i + 1}. {drivers[i].Name} - {drivers[i].Skill}");
}
Console.WriteLine("Select second driver (1-4): ");
var driver2Index = int.Parse(Console.ReadLine()) - 1;
selectedCar2.Driver = drivers[driver2Index];

Console.WriteLine("*** RACE ***");
RaceCars(selectedCar1, selectedCar2);

void RaceCars(Car car1, Car car2)
{
    int car1Speed = car1.CalculateSpeed();
    int car2Speed = car2.CalculateSpeed();

    if (car1Speed > car2Speed)
    {
        Console.WriteLine($"{car1.Model} wins, with speed {car1Speed} kmph, and driver {car1.Driver.Name}");
    }
    else if (car2Speed > car1Speed)
    {
        Console.WriteLine($"{car2.Model} wins, with speed {car2Speed} kmph, and driver {car2.Driver.Name}");
    }
    else
    {
        Console.WriteLine("It's a tie");
    }
}