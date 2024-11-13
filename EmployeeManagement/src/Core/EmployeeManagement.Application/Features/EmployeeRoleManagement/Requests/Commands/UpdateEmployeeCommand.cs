using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Commands;

public class UpdateEmployeeCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public UpdateEmployeeDto UpdateEmployeeDto { get; set; }
    public ChangeParentDto ChangeParentDto { get; set; }
}