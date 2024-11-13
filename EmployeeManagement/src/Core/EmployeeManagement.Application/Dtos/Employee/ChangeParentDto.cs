using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Common;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;

public class ChangeParentDto : BaseDto
{
    public Guid NewParentId { get; set; }
}