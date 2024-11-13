using EmployeeManagement.Core.EmployeeManagement.Application.Dtos.Employee;
using EmployeeManagement.Core.EmployeeManagement.Domain;

namespace EmployeeManagement.Core.EmployeeManagement.Application.Profile;

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<Employee, CreateEmployeeDto>().ReverseMap();
        CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();
    }
}