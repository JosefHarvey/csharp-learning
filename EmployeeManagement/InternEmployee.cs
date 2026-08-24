public class InternEmployee : Employee
{
    public InternEmployee(string employeeId, string name) : base(employeeId, name)
    {
    }

    public override decimal CalculateSalary()
    {
        return 500000m;
    }

    public override string EmployeeType => "Intern";
}
