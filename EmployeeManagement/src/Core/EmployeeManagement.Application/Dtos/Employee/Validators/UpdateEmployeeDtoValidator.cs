using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;
using FluentValidation;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee.Validators;

public class UpdateEmployeeDtoValidator : AbstractValidator<UpdateEmployeeDto>
{
    public UpdateEmployeeDtoValidator(IEmployeeRepository employeeRepository)
    {
        Include(new IEmployeeDtoValidator(employeeRepository));
        
        RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} cannot be empty");
    }
}