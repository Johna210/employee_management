using AutoMapper;
using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Infrastructure;
using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;
using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Queries;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Handlers.Commands;

public class GetEmployeeOrganizationTreeHandler : IRequestHandler<GetEmployeeOrganizationTree, List<OrganizationDto>>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly IOrganizationTreeInfrastructure _organizationTreeInfrastructure;

    public GetEmployeeOrganizationTreeHandler(IEmployeeRepository employeeRepository, IMapper mapper, IOrganizationTreeInfrastructure organizationTreeInfrastructure)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
        _organizationTreeInfrastructure = organizationTreeInfrastructure;
    }
    
    public async Task<List<OrganizationDto>> Handle(GetEmployeeOrganizationTree request, CancellationToken cancellationToken)
    {
        var employees = await _employeeRepository.GetEmployeesWithDetails();
        
        var employeeTree = _organizationTreeInfrastructure.BuildEmployeeOrganizationTree(employees);
        
        return _mapper.Map<List<OrganizationDto>>(employeeTree);
    }
}