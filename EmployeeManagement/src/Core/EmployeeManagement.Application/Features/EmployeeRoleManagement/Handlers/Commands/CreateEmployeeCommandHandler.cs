using AutoMapper;
using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;
using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee.Validators;
using EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Commands;
using EmployeeManagement.Core.EmployeeManagement.Domain;
using FluentValidation;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Handlers.Commands;

public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Guid>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }
    
    public async Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateEmployeeDtoValidator(_employeeRepository);
        var validationResult = await validator.ValidateAsync(request.CreateEmployeeDto, cancellationToken);
        
        if (validationResult.IsValid == false)
            throw new ValidationException(validationResult.Errors);
        
        var employee = _mapper.Map<Employee>(request.CreateEmployeeDto);
        employee = await _employeeRepository.Add(employee);
        
        return employee.Id;
    }
}