using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Queries;

public class GetEmployeeChildrenRequest : IRequest<List<EmployeeDto>>
{
    public Guid Id { get; set; }
}