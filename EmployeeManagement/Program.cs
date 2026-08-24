var employee1 = new FulltimeEmployee("EMP001", "Josef");
var employee2 = new FreelanceEmployee("EMP002", "Budi", 50m, 100);
var employee3 = new InternEmployee("EMP003", "Andi");

Employee[] employees =
{
    employee1,
    employee2,
    employee3
};

foreach (Employee employee in employees)
{
    Console.WriteLine(
        $"{employee.Name} - {employee.EmployeeType} -{employee.CalculateSalary()}"
    );
}
