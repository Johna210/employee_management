using EmployeeManagement.Core.EmployeeManagement.Domain.Common;

namespace EmployeeManagement.Core.EmployeeManagement.Domain;

public class Employee: BaseDomainEntity
{
    public Guid ParentId { get; set; }
}