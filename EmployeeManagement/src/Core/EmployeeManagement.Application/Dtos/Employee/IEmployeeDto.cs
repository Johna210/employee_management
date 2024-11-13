namespace EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;

public interface IEmployeeDto
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Description { get; set; }
}