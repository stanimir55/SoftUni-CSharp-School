using System.Text.RegularExpressions;

string splitPattern = @" *,{1} *";
string healthPattern = @"[^+\-*/.\d]";
string damagePattern = @"((|-)\d+\.\d+|(|-)\d+)";
string operationPattern = @"[\*\/]";

string[] demons = Regex.Split(Console.ReadLine(), splitPattern);

Regex healthRegex = new Regex(healthPattern);
Regex damageRegex = new Regex(damagePattern);

var demonData = new Dictionary<string, KeyValuePair<int, double>>(demons.Length - 1);

foreach (var demon in demons.OrderBy(x => x))
{
    int helth = 0;
    var sumChar = healthRegex.Matches(demon).ToArray();

    foreach (var ch in sumChar)
    {
        helth += char.Parse(ch.Value);
    }

    double damage = 0;
    var dmg = damageRegex.Matches(demon).ToArray();

    foreach (var number in dmg)
    {
        damage += double.Parse(number.Value);
    }

    var mathSymbols = Regex.Matches(demon, operationPattern).ToArray();

    foreach (var symbol in mathSymbols)
    {
        if (symbol.Value == "*")
        {
            damage *= 2;
        }
        else if (symbol.Value == "/")
        {
            damage /= 2;
        }
    }

    demonData[demon] = new KeyValuePair<int, double>(helth, damage);
}

foreach (var demon in demonData)
{
    Console.WriteLine($"{demon.Key} - {demon.Value.Key} health, {demon.Value.Value:F2} damage");
}
