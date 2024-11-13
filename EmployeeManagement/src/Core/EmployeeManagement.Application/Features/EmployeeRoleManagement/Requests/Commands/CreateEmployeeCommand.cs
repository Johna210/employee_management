using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Commands;

public class CreateEmployeeCommand : IRequest<Guid>
{
    public CreateEmployeeDto CreateEmployeeDto { get; set; }
}