string[] songs = Console.ReadLine().Split(", ");
Queue<string> songsQueue = new Queue<string>(songs);

while (true)
{
    string[] arguments = Console.ReadLine().Split();

    switch (arguments[0])
    {
        case "Play":
            songsQueue.Dequeue();

            if (songsQueue.Count == 0)
            {
                Console.WriteLine("No more songs!");
                return;
            }
            break;
        case "Add":
            string songName = string.Join(" ", arguments.Skip(1));

            if (songsQueue.Contains(songName))
            {
                Console.WriteLine($"{songName} is already contained!");
                continue;
            }

            songsQueue.Enqueue(songName);
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songsQueue));
            break;
    }
}