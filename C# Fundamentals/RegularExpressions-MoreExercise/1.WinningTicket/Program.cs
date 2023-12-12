﻿using System.Text.RegularExpressions;

string splitPattern = @" *,{1} *";
string pattern = @"\@{6,}|\#{6,}|\${6,}|\^{6,}";
Regex regex = new Regex(pattern);

string[] tickets = Regex.Split(Console.ReadLine(), splitPattern);

for (int i = 0; i < tickets.Length; i++)
{
    if (tickets[i].Length == 20)
    {
        Match firstHalf = regex.Match(tickets[i].Substring(0, 10));
        Match secondHalf = regex.Match(tickets[i].Substring(10));
        int minLength = Math.Min(firstHalf.Length, secondHalf.Length);

        if (firstHalf.Success && secondHalf.Success)
        {
            string winFirstHalf = firstHalf.Value.Substring(0, minLength);
            string winSecondHalf = secondHalf.Value.Substring(0, minLength);

            if (winFirstHalf.Equals(winSecondHalf))
            {
                if (winFirstHalf.Length == 10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {minLength}{winFirstHalf.Substring(0,1)} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {minLength}{winFirstHalf.Substring(0,1)}");
                }
            }
            else
            {
                Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
            }
        }
        else
        {
            Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
        }
    }
    else
    {
        Console.WriteLine("invalid ticket");
    }
}
