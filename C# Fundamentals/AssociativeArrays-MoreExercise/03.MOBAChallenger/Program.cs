string command;
var players = new Dictionary<string, Dictionary<string, int>>();
var playersSkills = new Dictionary<string, int>();

while ((command = Console.ReadLine()) != "Season end")
{
    if (command.Contains(" -> "))
    {
        string[] arguments = command
            .Split(" -> ")
            .ToArray();

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
    else if (command.Contains(" vs "))
    {
        string[] duelPlayers = command
            .Split(" vs ")
            .ToArray();

        string playerOne = duelPlayers[0];
        string playerTwo = duelPlayers[1];

        if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
        {
            string playerToRemove = "";

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

foreach (var kvp in playersSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    string playerName = kvp.Key;
    int playerTotalSkills = kvp.Value;

    Console.WriteLine($"{playerName}: {playerTotalSkills} skill");

    foreach (var roleSkill in players[playerName].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
    {
        string role = roleSkill.Key;
        int skill = roleSkill.Value;

        Console.WriteLine($"- {role} <::> {skill}");
    }
}