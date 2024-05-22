int linesCount = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

for (int i = 0; i < linesCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string studentName = arguments[0];
    decimal studentGrade = decimal.Parse(arguments[1]);

    if (!studentsGrades.ContainsKey(studentName))
    {
        studentsGrades[studentName] = new List<decimal>();
    }

    studentsGrades[studentName].Add(studentGrade);
}

foreach (var kvp in studentsGrades)
{
    Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(g => g
    .ToString("F2")))} (avg: {kvp.Value.Average():F2})");
}