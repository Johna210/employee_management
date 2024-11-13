using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Exceptions;

public class ValidationException : ApplicationException
{
    public List<string> Errors { get; } = new List<string>();

    public ValidationException(ValidationResult validationResult)
    {
        foreach (var error in validationResult.Errors)
        {
            Errors.Add(error.ErrorMessage);
        }
    }
}