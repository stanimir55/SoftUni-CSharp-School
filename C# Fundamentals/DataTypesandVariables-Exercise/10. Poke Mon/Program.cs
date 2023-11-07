int powerThePokemon = int.Parse(Console.ReadLine());
int pokeTargets = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());

int counter = 0;

double percent = (double)powerThePokemon * 0.5;

if (powerThePokemon < pokeTargets)
{
    Console.WriteLine(powerThePokemon);
    Console.WriteLine(counter);
}
else
{
    while (powerThePokemon >= pokeTargets)
    {
        if (powerThePokemon - pokeTargets == percent && exhaustionFactor != 0)
        {
            powerThePokemon = (powerThePokemon - pokeTargets) / exhaustionFactor;
        }
        else
        {
            powerThePokemon -= pokeTargets;
        }
        counter++;
    }
}
Console.WriteLine(powerThePokemon);
Console.WriteLine(counter);