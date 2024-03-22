int numberOfHeroes = int.Parse(Console.ReadLine());
var heroes = new Dictionary<string, Dictionary<int, int>>();

for (int i = 0; i < numberOfHeroes; i++)
{
    string[] arguments = Console.ReadLine()
        .Split()
        .ToArray();

    string heroName = arguments[0];
    int hp = int.Parse(arguments[1]);
    int mp = int.Parse(arguments[2]);

    heroes[heroName] = new Dictionary<int, int>();
    heroes[heroName][hp] = mp;
}

string commands;
while ((commands = Console.ReadLine()) != "End")
{
    string[] command = commands
        .Split(" - ")
        .ToArray();
    string heroName = command[1];

    switch (command[0])
    {
        case "CastSpell":
            int mpNeeded = int.Parse(command[2]);
            string spellName = command[3];

            foreach (var kvp in heroes)
            {
                if (kvp.Key == heroName)
                {
                    foreach (var kvpOne in kvp.Value)
                    {
                        if (heroes[heroName] == kvp.Value && kvpOne.Value >= mpNeeded)
                        {
                            int result = kvpOne.Value - mpNeeded;

                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {result} MP!");
                            heroes[heroName] = new Dictionary<int, int>();
                            heroes[heroName][kvpOne.Key] = result;
                            break;
                        }

                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        heroes[heroName] = new Dictionary<int, int>();
                        heroes[heroName][kvpOne.Key] = kvpOne.Value;
                        break;
                    }
                }
            }
            break;
        case "TakeDamage":
            int damage = int.Parse(command[2]);
            string attacker = command[3];

            foreach (var kvp in heroes)
            {
                if (kvp.Key == heroName)
                {
                    foreach (var kvpOne in kvp.Value)
                    {
                        int result = kvpOne.Key - damage;

                        if (kvpOne.Key > 0)
                        {
                            if (result <= 0)
                            {
                                heroes.Remove(heroName);
                                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                                break;
                            }

                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {result} HP left!");
                            heroes[heroName] = new Dictionary<int, int>();
                            heroes[heroName][result] = kvpOne.Value;
                        }
                    }
                }
            }
            break;
        case "Recharge":
            int rechargeAmout = int.Parse(command[2]);

            foreach (var kvp in heroes)
            {
                if (kvp.Key == heroName)
                {
                    foreach (var kvpOne in kvp.Value)
                    {
                        int result = kvpOne.Value + rechargeAmout;

                        if (result > 200)
                        {
                            result = 200;
                        }

                        heroes[heroName] = new Dictionary<int, int>();
                        heroes[heroName][kvpOne.Key] = result;
                        Console.WriteLine($"{heroName} recharged for {result - kvpOne.Value} MP!");
                        break;
                    }
                }
            }
            break;
        case "Heal":
            int healAmout = int.Parse(command[2]);

            foreach (var kvp in heroes)
            {
                if (kvp.Key == heroName)
                {
                    foreach (var kvpOne in kvp.Value)
                    {
                        int result = kvpOne.Key + healAmout;

                        if (result > 100)
                        {
                            result = 100;
                        }

                        heroes[heroName] = new Dictionary<int, int>();
                        heroes[heroName][result] = kvpOne.Value;

                        Console.WriteLine($"{heroName} healed for {result - kvpOne.Key} HP!");
                    }
                }
            }
            break;
    }
}

foreach (var kvp in heroes)
{
    Console.WriteLine(kvp.Key);
    
    foreach (var kvpOne in kvp.Value)
    {
        Console.WriteLine($"  HP: {kvpOne.Key}");
        Console.WriteLine($"  MP: {kvpOne.Value}");
    }
}
