public class FreelanceEmployee : Employee
{
    public decimal HourlyRate {get; set;}
    public decimal HourlyWorked {get; set;} 
    public FreelanceEmployee(string employeeId, string name, decimal hourlyRate, decimal hourlyWorked) : base (employeeId, name)
    { 
        HourlyRate = hourlyRate;
        HourlyWorked = hourlyWorked;
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * HourlyWorked;
    }

    public override string EmployeeType => "Freelance";
}