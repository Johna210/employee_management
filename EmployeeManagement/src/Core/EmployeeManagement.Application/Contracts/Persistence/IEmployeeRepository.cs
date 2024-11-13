using EmployeeManagement.Core.EmployeeManagement.Domain;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;

public interface IEmployeeRepository : IGenericRepository<Employee>
{
    Task<Employee> GetEmployeeWithDetails(Guid id);
    Task<List<Employee>> GetEmployeesWithDetails();
    Task<List<Employee>> GetEmployeesByRoleWithDetails(string role);
    Task ChangeEmployeeParent(Guid id, Guid newParentId);
    Task<bool> IsEmployeeRoot(string role);
}