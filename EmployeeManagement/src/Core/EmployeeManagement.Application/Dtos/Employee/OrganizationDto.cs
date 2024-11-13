using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Common;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;

public class OrganizationDto : BaseDto, IEmployeeDto
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Description { get; set; }
    
    public List<OrganizationDto> Children { get; set; }
}