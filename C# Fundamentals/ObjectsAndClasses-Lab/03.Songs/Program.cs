int numberOfSongs = int.Parse(Console.ReadLine());

List<Song> playlist = new List<Song>();

for (int i = 0; i < numberOfSongs; i++)
{
    string[] arguments = Console.ReadLine().Split("_");

    string listType = arguments[0];
    string songName = arguments[1];
    string songTime = arguments[2];

    Song song = new Song(listType, songName, songTime);

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
        this.TypeList = typeList;
        this.Name = name;
        this.Time = time;
    }

    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}