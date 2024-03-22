int linesCount = int.Parse(Console.ReadLine());
var pieces = new Dictionary<string, Dictionary<string, string>>();

for (int i = 0; i < linesCount; i++)
{
    string[] arguments = Console.ReadLine().Split("|");
    string piece = arguments[0];
    string composer = arguments[1];
    string key = arguments[2];

    pieces[piece] = new Dictionary<string, string>();
    pieces[piece].Add(composer, key);
}

string commands;
while ((commands = Console.ReadLine()) != "Stop")
{
    string[] arguments = commands.Split("|");

    switch (arguments[0])
    {
        case "Add":
            string piece = arguments[1];
            string composer = arguments[2];
            string key = arguments[3];

            if (!pieces.ContainsKey(piece))
            {
                pieces[piece] = new Dictionary<string, string>();
                pieces[piece].Add(composer, key);
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                continue;
            }

            Console.WriteLine($"{piece} is already in the collection!");
            break;
        case "Remove":
            string removePiece = arguments[1];

            if (!pieces.ContainsKey(removePiece))
            {
                Console.WriteLine($"Invalid operation! {removePiece} does not exist in the collection.");
                continue;
            }

            pieces.Remove(removePiece);
            Console.WriteLine($"Successfully removed {removePiece}!");
            break;
        case "ChangeKey":
            string changePiece = arguments[1];
            string newKey = arguments[2];

            if (!pieces.ContainsKey(changePiece))
            {
                Console.WriteLine($"Invalid operation! {changePiece} does not exist in the collection.");
                continue;
            }

            foreach (var kvp in pieces)
            {
                foreach (var kvpOne in kvp.Value)
                {
                    if (kvp.Key == changePiece)
                    {
                        pieces[changePiece][kvpOne.Key] = newKey;
                        break;
                    }
                }
            }

            Console.WriteLine($"Changed the key of {changePiece} to {newKey}!");
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
