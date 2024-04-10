int linesCount = int.Parse(Console.ReadLine());
var pieces = new Dictionary<string, Dictionary<string, string>>();

for (int i = 0; i < linesCount; i++)
{
    string[] arguments = Console.ReadLine().Split("|");
    string piece = arguments[0];
    string composer = arguments[1];
    string key = arguments[2];
    pieces[piece] = new Dictionary<string, string>() { { composer, key } };
}

string commands;
while ((commands = Console.ReadLine()) != "Stop")
{
    string[] arguments = commands.Split("|");
    string pieceName = arguments[1];

    switch (arguments[0])
    {
        case "Add":
            string composer = arguments[2];
            string key = arguments[3];

            if (!pieces.ContainsKey(pieceName))
            {
                pieces[pieceName] = new Dictionary<string, string>() { { composer, key } };
                Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                continue;
            }

            Console.WriteLine($"{pieceName} is already in the collection!");
            break;
        case "Remove":
            if (!pieces.ContainsKey(pieceName))
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                continue;
            }

            pieces.Remove(pieceName);
            Console.WriteLine($"Successfully removed {pieceName}!");
            break;
        case "ChangeKey":
            if (!pieces.ContainsKey(pieceName))
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                continue;
            }

            string newKey = arguments[2];
            composer = pieces[pieceName].First().Key;
            pieces[pieceName] = new Dictionary<string, string>() { {composer, newKey } };
            Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
            break;
    }
}

foreach (var piece in pieces)
{
    foreach (var kvp in piece.Value)
    {
        Console.WriteLine($"{piece.Key} -> Composer: {kvp.Key}, Key: {kvp.Value}");
    }
}
