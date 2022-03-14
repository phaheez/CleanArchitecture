using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Queries
{
    public record GetEmployeeByIdQuery(int EmployeeId) : IRequest<Core.Entities.Employee>;

    //public class GetEmployeeByIdQuery : IRequest<Core.Entities.Employee>
    //{
    //    public int EmployeeId { get; }

    //    public GetEmployeeByIdQuery(int employeeId)
    //    {
    //        EmployeeId = employeeId;
    //    }
    //}
}
