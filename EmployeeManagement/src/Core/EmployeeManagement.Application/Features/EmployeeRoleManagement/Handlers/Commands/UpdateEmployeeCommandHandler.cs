using AutoMapper;
using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;
using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee.Validators;
using EmployeeManagement.Core.EmployeeManagement.Application.Exceptions;
using EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Requests.Commands;
using EmployeeManagement.Core.EmployeeManagement.Domain;
using MediatR;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Features.EmployeeRoleManagement.Handlers.Commands;

public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, Unit>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }
    
    public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateEmployeeDtoValidator(_employeeRepository);
        var validationResult = await validator.ValidateAsync(request.UpdateEmployeeDto, cancellationToken);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult);
        }
        
        var employee = await _employeeRepository.Get(request.Id);
        
        if (employee == null)
            throw new NotFoundException(nameof(Employee), request.Id);

        if (request.UpdateEmployeeDto != null)
        {
            _mapper.Map(request.UpdateEmployeeDto, employee);
            
            await _employeeRepository.Update(employee);
        } else if (request.ChangeParentDto != null)
        {
            await _employeeRepository.ChangeEmployeeParent(request.Id, request.ChangeParentDto.NewParentId);
        }
        
        return Unit.Value;
    }
}