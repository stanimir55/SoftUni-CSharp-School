//От конзолата се четат два реда:
//Името на футболния отбор, за който водим статистика - текст
//Броя изиграни срещи през настоящия сезон - цяло число в интервала [0… 100]
//За всяка изиграна среща се прочита отделен ред:
//Резултатът от изиграната среща в един от горепосочените формати – символ с възможности 'W', 'D' и 'L'

//В зависимост от това дали отборът е играл мачове през настоящия сезон се извеждат два вида изход.
//Ако отборът не е изиграл нито един мач през настоящия сезон се извежда точно един ред в следния формат:
//"{името на отбора} hasn't played any games during this season."
//Ако отборът е изиграл един мач или повече се извеждат шест реда в следния формат:
//"{името на отбора} has won {брой спечелени точки} points during this season"
//"Total stats:"
//"## W: {брой спечелени игри}"
//"## D: {брой игри, завършили наравно}"
//"## L: {брой загубени игри}"
//"Win rate: {процент спечелени игри}%"
//Процентът спечелени игри трябва да бъде форматиран до втората цифра след десетичния знак.

string footballClub = Console.ReadLine();
int matchesSeason = int.Parse(Console.ReadLine());

int win = 0;
int draw = 0;
int lost = 0;

int totalPoints = win + draw;
//double winPercent = (double)win * matchesSeason / 100; //win * 1.0 / matchesSeason * 100; (double)win * matchesSeason / 100;

for (int i = 1; i <= matchesSeason; i++)
{
    string result = Console.ReadLine();
    if (result == "W")
    {
        win++;
        totalPoints += 3;
    }
    else if (result == "D")
    {
        draw++;
        totalPoints += 1;
    }
    else if (result == "L")
    {
        lost++;
    }
    if (matchesSeason <= 0)
    {
        Console.WriteLine($"{footballClub} hasn't played any games during this season.");
    }
    //if (matchesSeason >= 1)
    //{
    //    Console.WriteLine($"{footballClub} has won {totalPoints} points during this season");
    //    Console.WriteLine("Total stats:");
    //    Console.WriteLine($"## W: {win}");
    //    Console.WriteLine($"## D: {draw}");
    //    Console.WriteLine($"## L: {lost}");
    //    Console.WriteLine($"Win rate: {winPercent:F2}%");
    //}
}

double winPercent = win * 1.0 / matchesSeason * 100; //(double)win * matchesSeason / 100; 
//win * 1.0 / matchesSeason * 100;

if (matchesSeason >= 1)
{
    Console.WriteLine($"{footballClub} has won {totalPoints} points during this season");
    Console.WriteLine("Total stats:");
    Console.WriteLine($"## W: {win}");
    Console.WriteLine($"## D: {draw}");
    Console.WriteLine($"## L: {lost}");
    Console.WriteLine($"Win rate: {winPercent:F2}%");
}




























