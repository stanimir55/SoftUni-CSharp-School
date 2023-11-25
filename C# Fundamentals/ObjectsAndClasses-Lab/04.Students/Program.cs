string command;

List<Student> city = new List<Student>();

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();

    string firstName = arguments[0];
    string lastName = arguments[1];
    string age = arguments[2];
    string homeTown = arguments[3];

    Student student = new Student(firstName, lastName, age, homeTown);

    city.Add(student);
}

string homeTownName = Console.ReadLine();

foreach (Student student in city)
{
    if (student.HomeTown == homeTownName)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}


class Student
{
    public Student(string firstName, string lastName, string age, string city)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.HomeTown = city;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Age { get; set; }

    public string HomeTown { get; set; }
}