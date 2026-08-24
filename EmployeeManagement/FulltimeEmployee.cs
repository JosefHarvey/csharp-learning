public class FulltimeEmployee : Employee
{
    public FulltimeEmployee(string employeeId, string name) : base(employeeId, name)
    {
    }

    public override decimal CalculateSalary()
    {
       return 1000000m; 
    }
    public override string EmployeeType => "Full-time";
}