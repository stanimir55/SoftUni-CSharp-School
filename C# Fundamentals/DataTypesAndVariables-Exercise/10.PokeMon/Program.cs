int pokemonPower = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());
int target = 0;
int percent = (int)(pokemonPower * 0.5);

while (pokemonPower >= distance)
{
    target++;
    pokemonPower -= distance;

    if (pokemonPower == percent && exhaustionFactor != 0)
    {
        pokemonPower /= exhaustionFactor;
    }
}

Console.WriteLine(pokemonPower);
Console.WriteLine(target);
