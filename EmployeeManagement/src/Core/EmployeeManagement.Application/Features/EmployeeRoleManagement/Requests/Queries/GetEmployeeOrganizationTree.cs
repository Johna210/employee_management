using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Queries;

public class GetEmployeeOrganizationTree : IRequest<List<OrganizationDto>>
{
    
}