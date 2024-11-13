using EmployeeManagement.Core.EmployeeManagement.Domain.Common;

namespace EmployeeManagement.Core.EmployeeManagement.Domain;

public class Organization : BaseDomainEntity
{
    public List<Organization> Children { get; set; } = new List<Organization>();
}