int dogFoodKg = int.Parse(Console.ReadLine());

int counter = 0;

string command = Console.ReadLine();
dogFoodKg = dogFoodKg * 1000;

while (command != "Adopted")
{
    int dogFoodGr = int.Parse(command);

    counter += dogFoodGr;
  
    command = Console.ReadLine();

}

if (dogFoodKg >= counter)
{
    Console.WriteLine($"Food is enough! Leftovers: {Math.Abs(dogFoodKg - counter)} grams.");

}
else if (dogFoodKg < counter)
{
    Console.WriteLine($"Food is not enough. You need {Math.Abs(dogFoodKg - counter)} grams more.");
}
