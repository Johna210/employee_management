namespace EmployeeManagement.Core.EmployeeManagement.Domain;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public string Description { get; set; }
    public List<Guid> ChildrenIds { get; set; }
    public Guid ParentId { get; set; }
}