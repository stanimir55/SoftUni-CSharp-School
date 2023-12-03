string command;
var courses = new Dictionary<string, Course>();

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command
        .Split(" : ")
        .ToArray();

    string courseName = arguments[0];
    string studentName = arguments[1];

    if (!courses.ContainsKey(courseName))
    {
        Course course = new Course(courseName);
        courses.Add(course.Name, course);
    }

    courses[courseName].StudentsNames.Add(studentName);
}

foreach (KeyValuePair<string,Course> kvp in courses)
{
    Console.WriteLine(kvp.Value);
}


class Course
{
    public string Name { get; set; }

    public List<string> StudentsNames { get; set; }

    public Course(string name)
    {
        Name = name;
        StudentsNames = new List<string>();
    }

    public override string ToString()
    {
        string result = $"{Name}: {StudentsNames.Count}\n";

        for (int i = 0; i < StudentsNames.Count; i++)
        {
            result += $"-- {StudentsNames[i]}\n";
        }

        return result.Trim();
    }
}