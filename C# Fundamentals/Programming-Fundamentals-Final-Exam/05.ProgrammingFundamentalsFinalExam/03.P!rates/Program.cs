string commands;
List<City> cities = new List<City>();

while ((commands = Console.ReadLine()) != "Sail")
{
    string[] arguments = commands
        .Split("||")
        .ToArray();

    string cityName = arguments[0];
    int population = int.Parse(arguments[1]);
    int gold = int.Parse(arguments[2]);

    City city = cities.FirstOrDefault(x => x.Name == cityName);

    if (city is not null)
    {
        city.Population += population;
        city.Gold += gold;
        continue;
    }

    cities.Add(new City
    {
        Name = cityName,
        Population = population,
        Gold = gold
    });
}

while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands
        .Split("=>")
        .ToArray();

    string town = arguments[1];
    City city = cities.FirstOrDefault(x => x.Name == town);

    switch (arguments[0])
    {
        case "Plunder":
            int people = int.Parse(arguments[2]);
            int gold = int.Parse(arguments[3]);

            city.Population -= people;
            city.Gold -= gold;

            Console.WriteLine($"{city.Name} plundered! {gold} gold stolen, {people} citizens killed.");

            if (city.Population <= 0 || city.Gold <= 0)
            {
                Console.WriteLine($"{city.Name} has been wiped off the map!");
                cities.Remove(city);
            }
            break;
        case "Prosper":
            int prosperGold = int.Parse(arguments[2]);

            if (prosperGold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                continue;
            }

            city.Gold += prosperGold;

            Console.WriteLine($"{prosperGold} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");
            break;
    }
}

if (cities.Count == 0)
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

    foreach (City city in cities)
    {
        Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
    }
}


public class City
{
    public string Name { get; set; }

    public int Population { get; set; }

    public int Gold { get; set; }
}