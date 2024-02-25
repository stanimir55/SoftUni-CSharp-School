int songsCount = int.Parse(Console.ReadLine());
List<Song> playlist = new List<Song>();

for (int i = 0; i < songsCount; i++)
{
    string[] songArguments = Console.ReadLine().Split("_");
    Song song = new Song(songArguments[0], songArguments[1], songArguments[2]);
    playlist.Add(song);
}

string filter = Console.ReadLine();

if (filter != "all")
{
    foreach (Song song in playlist)
    {
        if (song.TypeList == filter)
        {
            Console.WriteLine(song.Name);
        }
    }

    return;
}

foreach (Song song in playlist)
{
    Console.WriteLine(song.Name);
}

class Song
{
    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }

    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}
