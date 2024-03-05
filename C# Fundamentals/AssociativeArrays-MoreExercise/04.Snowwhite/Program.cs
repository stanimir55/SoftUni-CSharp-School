var dwarfs = new Dictionary<string, Dictionary<string, int>>();

string commands;
while ((commands = Console.ReadLine()) != "Once upon a time")
{
    string[] arguments = commands.Split(" <:> ");
    string dwarfName = arguments[0];
    string dwarfHatColor = arguments[1];
    int dwarfPhysics = int.Parse(arguments[2]);

    if (!dwarfs.ContainsKey(dwarfHatColor))
    {
        dwarfs[dwarfHatColor] = new Dictionary<string, int>();
        dwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysics);
    }
    else
    {
        bool haveDwardWithTheSameName = false;

        foreach (var kvp in dwarfs[dwarfHatColor])
        {
            string currentName = kvp.Key;
            int currentPhysics = kvp.Value;

            if (currentName == dwarfName)
            {
                haveDwardWithTheSameName = true;

                if (dwarfPhysics > currentPhysics)
                {
                    dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                    break;
                }
            }
        }

        if (haveDwardWithTheSameName == false)
        {
            dwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysics);
        }
    }
}

var sortedDwarfs = new Dictionary<string, int>();

foreach (var kvp in dwarfs.OrderByDescending(x => x.Value.Count()))
{
    string hatColor = kvp.Key;
    var nameAndPhysics = kvp.Value;

    foreach (var kvpOne in nameAndPhysics)
    {
        string name = kvpOne.Key;
        int physics = kvpOne.Value;
        sortedDwarfs.Add($"({hatColor}) {name} <-> ", physics);
    }
}
foreach (var kvp in sortedDwarfs.OrderByDescending(x => x.Value))
{
    string name = kvp.Key;
    int physycs = kvp.Value;

    Console.WriteLine($"{name}{physycs}");
}

