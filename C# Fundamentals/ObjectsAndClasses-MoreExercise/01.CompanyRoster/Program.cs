int number = int.Parse(Console.ReadLine());

List<Employee> employees1 = new List<Employee>();
List<string> departmens = new List<string>();

for (int i = 0; i < number; i++)
{
    string[] employees = Console.ReadLine()
        .Split()
        .ToArray();

    Employee employee = new Employee();

    string name = employees[0];
    double salary = double.Parse(employees[1]);
    string department = employees[2];

    employee.Name = name;
    employee.Salary = salary;
    employee.Department = department;

    employees1.Add(employee);
    departmens.Add(department);
}

employees1 = employees1.OrderBy(x => x.Department).ToList();
departmens = departmens.Distinct().ToList();

string departmentHighestAve = "";
double highestAveSalary = double.MinValue;

foreach (string department in departmens)
{
    double aveSolary = employees1.Where(e => e.Department == department).Select(e => e.Salary).Average();

    if (aveSolary > highestAveSalary)
    {
        departmentHighestAve = department;
        highestAveSalary = aveSolary;
    }
}

Console.WriteLine($"Highest Average Salary: {departmentHighestAve}");

foreach (var employee in employees1.Where(e => e.Department == departmentHighestAve).OrderByDescending(e => e.Salary))
{
    Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
}


class Employee
{
    public string Name { get; set; }

    public double Salary { get; set; }

    public string Department { get; set; }
}
