namespace _09.PokemonTrainer;
public class StartUp
{
    static void Main()
    {
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

        string commands;
        while ((commands = Console.ReadLine()) != "Tournament")
        {
            string[] arguments = commands.Split();

            string trainerName = arguments[0];
            string pokemonName = arguments[1];
            string pokemonElement = arguments[2];
            int pokemonHealth = int.Parse(arguments[3]);

            if (!trainers.ContainsKey(trainerName))
            {
                Trainer trainer = new Trainer(trainerName);
                trainers.Add(trainerName, new Trainer(trainerName));
            }

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            trainers[trainerName].Pokemons.Add(pokemon);
        }

        while ((commands = Console.ReadLine()) != "End")
        {
            foreach (var kvp in trainers)
            {
                bool doesTrainerHavePokemonElement = kvp.Value.Pokemons
                    .Any(x => x.Element == commands);

                if (doesTrainerHavePokemonElement)
                {
                    kvp.Value.Badges += 1;
                }
                else
                {

                    foreach (var kvpOne in kvp.Value.Pokemons)
                    {
                        kvpOne.Health -= 10;
                    }

                    kvp.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                }

            }
        }

        foreach (var kvp in trainers
            .OrderByDescending(x => x.Value.Badges))
        {
            Console.WriteLine($"{kvp.Key} {kvp.Value.Badges} {kvp.Value.Pokemons.Count}");
        }
    }
}

/*
Peter Charizard Fire 100
George Squirtle Water 38
Peter Pikachu Electricity 10
Tournament
Fire
Electricity
End
 */