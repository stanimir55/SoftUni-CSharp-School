string commands;
List<Student> students = new List<Student>();

while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();
    Student student = new Student(arguments[0], arguments[1], arguments[2], arguments[3]);
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

