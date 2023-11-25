string command;

List<Student> students = new List<Student>();

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();

    string firstName = arguments[0];
    string lastName = arguments[1];
    string age = arguments[2];
    string homeTown = arguments[3];

    Student student = new Student();

    student.FirstName = firstName;
    student.LastName = lastName;
    student.Age = age;
    student.HomeTown = homeTown;

    int index = ValidateStudent(firstName, lastName, students);

    if (index != -1)
    {
        students[index].Age = age;
        students[index].HomeTown = homeTown;
        continue;
    }

    //Student result = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

    //if (result is not null)
    //{
    //    students[index].Age = age;
    //    students[index].HomeTown = homeTown;
    //    continue;
    //}
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
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Age { get; set; }

    public string HomeTown { get; set; }
}
