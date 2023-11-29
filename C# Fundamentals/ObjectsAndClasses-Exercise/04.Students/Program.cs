int studentsCount = int.Parse(Console.ReadLine());
List<Student> student = new List<Student>();

for (int i = 0; i < studentsCount; i++)
{
    string[] information = Console.ReadLine().Split();

    string firstName = information[0];
    string lastName = information[1];
    string grade = information[2];

    Student students = new Student();

    students.FirstName = information[0];
    students.LastName = information[1];
    students.Grade = information[2];

    student.Add(students);
}

List<Student> sortedStudents = student.OrderByDescending(student => student.Grade).ToList();

for (int i = 0; i < sortedStudents.Count; i++)
{
    Console.WriteLine(sortedStudents[i]);
}


class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Grade { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade}";
    }
}