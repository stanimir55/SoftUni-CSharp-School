int guestCount = int.Parse(Console.ReadLine());

List<string> guestList = new List<string>();

for (int i = 0; i < guestCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string name = arguments[0];

    if (arguments[2] == "going!")
    {
        if (guestList.Exists(x => x == name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guestList.Add(name);
        }

    }
    else if (arguments[2] == "not")
    {

        if (guestList.Exists(x => x == name))
        {
            guestList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }

    }
}

for (int i = 0; i < guestList.Count; i++)
{
    Console.WriteLine(string.Join(" ", guestList[i]));
}