using EmployeeManagement.Core.EmployeeManagement.Application.Contracts.Persistence;
using FluentValidation;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee.Validators;

public class CreateEmployeeDtoValidator : AbstractValidator<CreateEmployeeDto>
{
    public CreateEmployeeDtoValidator(IEmployeeRepository employeeRepository)
    {
        Include(new IEmployeeDtoValidator(employeeRepository));
    }
}