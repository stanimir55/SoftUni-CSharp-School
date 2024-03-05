var players = new Dictionary<string, Dictionary<string, int>>();
var playersSkills = new Dictionary<string, int>();

string commands;
while ((commands = Console.ReadLine()) != "Season end")
{
    if (commands.Contains(" -> "))
    {
        string[] arguments = commands.Split(" -> ");
        string player = arguments[0];
        string position = arguments[1];
        int skill = int.Parse(arguments[2]);

        if (!players.ContainsKey(player))
        {
            players.Add(player, new Dictionary<string, int>());
            players[player].Add(position, skill);
            playersSkills.Add(player, skill);
        }
        else
        {
            if (!players[player].ContainsKey(position))
            {
                players[player].Add(position, skill);
                playersSkills[player] += skill;
            }
            else
            {
                if (players[player][position] < skill)
                {
                    players[player][position] -= players[player][position];
                    players[player][position] += skill;
                    players[player][position] = skill;
                }
            }
        }
    }
    else if (commands.Contains(" vs "))
    {
        string[] duelPlayers = commands.Split(" vs ");
        string playerOne = duelPlayers[0];
        string playerTwo = duelPlayers[1];

        if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
        {
            for (int i = 0; i < players[playerOne].Count; i++)
            {
                if (players[playerTwo].ContainsKey(players[playerOne].Keys.ElementAt(i)))
                {
                    string currentKey = players[duelPlayers[0]].Keys.ElementAt(i);

                    if (players[playerOne][currentKey] > players[playerTwo][currentKey])
                    {
                        players.Remove(playerTwo);
                        playersSkills.Remove(playerTwo);
                        break;
                    }
                    else if (players[playerOne][currentKey] < players[playerTwo][currentKey])
                    {
                        players.Remove(playerOne);
                        playersSkills.Remove(playerOne);
                        break;
                    }
                }
            }
        }
    }
}

foreach (var player in playersSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{player.Key}: {player.Value} skill");

    foreach (var roleSkill in players[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
    {
        Console.WriteLine($"- {roleSkill.Key} <::> {roleSkill.Value}");
    }
}
