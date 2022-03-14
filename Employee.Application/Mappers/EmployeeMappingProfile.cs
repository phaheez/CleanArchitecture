using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
            CreateMap<Core.Entities.Employee, UpdateEmployeeCommand>().ReverseMap();
        }
    }
}
