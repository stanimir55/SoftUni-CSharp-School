var coursesMap = new Dictionary<string, Course>();

string commands;
while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split(" : ");

    if (!coursesMap.ContainsKey(arguments[0]))
    {
        Course newCourse = new Course(arguments[0]);
        coursesMap.Add(newCourse.Name, newCourse);
    }

    coursesMap[arguments[0]].StudentNames.Add(arguments[1]);
}

foreach (Course course in coursesMap.Values)
{
    Console.WriteLine(course);
}

class Course
{
    public Course(string name)
    {
        Name = name;
        StudentNames = new List<string>();
    }

    public string Name { get; set; }

    public List<string> StudentNames { get; set; }

    public override string ToString()
    {
        string result = $"{Name}: {StudentNames.Count}\n";

        for (int i = 0; i < StudentNames.Count; i++)
        {
            result += $"-- {StudentNames[i]}\n";
        }
        return result.Trim();
    }
}

