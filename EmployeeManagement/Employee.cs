public abstract class Employee
{
    public string EmployeeId { get; set; }
    public string Name {get; set;}
    public Employee (string employeeId, string name)
    {
        EmployeeId = employeeId;
        Name = name;
    }   
    public abstract string EmployeeType { get; }
    public abstract decimal CalculateSalary();
}