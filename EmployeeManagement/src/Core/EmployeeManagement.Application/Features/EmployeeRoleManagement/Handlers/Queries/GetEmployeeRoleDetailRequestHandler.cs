using AutoMapper;
using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;
using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Queries;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Handlers.Commands;

public class GetEmployeeRoleDetailRequestHandler : IRequestHandler<GetEmployeeRoleDetailRequest, List<EmployeeDto>>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public GetEmployeeRoleDetailRequestHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }
    
    public async Task<List<EmployeeDto>> Handle(GetEmployeeRoleDetailRequest request, CancellationToken cancellationToken)
    {
        var employees = await _employeeRepository.GetEmployeesByRoleWithDetails(request.Role);
        return _mapper.Map<List<EmployeeDto>>(employees);
    }
}