int studentsCount = int.Parse(Console.ReadLine());
List<Student> student = new List<Student>();

for (int i = 0; i < studentsCount; i++)
{
    string[] information = Console.ReadLine().Split();
    Student students = new Student(information[0], information[1], double.Parse(information[2]));
    student.Add(students);
}

List<Student> sortedStudents = student.OrderByDescending(student => student.Grade).ToList();

for (int i = 0; i < sortedStudents.Count; i++)
{
    Console.WriteLine(sortedStudents[i]);
}


class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}