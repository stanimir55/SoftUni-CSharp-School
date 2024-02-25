string commands;
List<Student> students = new List<Student>();

while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();
    Student student = new Student(arguments[0], arguments[1], arguments[2], arguments[3]);

    int index = ValidateStudent(arguments[0], arguments[1], students);

    if (index != -1)
    {
        students[index].Age = arguments[2];
        students[index].HomeTown = arguments[3];
        continue;
    }

    students.Add(student);
}

string homeTownName = Console.ReadLine();

foreach (Student student in students)
{
    if (student.HomeTown == homeTownName)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}

static int ValidateStudent(string firstName, string lastName, List<Student> students)
{
    for (int i = 0; i < students.Count; i++)
    {
        if (students[i].FirstName == firstName && students[i].LastName == lastName)
        {
            return i;
        }
    }

    return -1;
}

class Student
{
    public Student(string firstName, string lastName, string age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Age { get; set; }

    public string HomeTown { get; set; }
}


