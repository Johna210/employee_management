using AutoMapper;
using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;
using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Queries;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Handlers.Commands;

public class GetEmployeeDetailRequestHandler : IRequestHandler<GetEmployeeDetailRequest, EmployeeDto>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public GetEmployeeDetailRequestHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }
    
    public async Task<EmployeeDto> Handle(GetEmployeeDetailRequest request, CancellationToken cancellationToken)
    {
        var employee = await _employeeRepository.GetEmployeeWithDetails(request.Id);
        return _mapper.Map<EmployeeDto>(employee);
    }
}