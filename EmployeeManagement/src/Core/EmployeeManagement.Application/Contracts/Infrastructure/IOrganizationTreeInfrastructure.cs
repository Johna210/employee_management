using EmployeeManagement.Core.EmployeeManagement.Domain;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Infrastructure;

public interface IOrganizationTreeInfrastructure
{
    Task<List<Organization>> BuildEmployeeOrganizationTree(List<Employee> employees);
}