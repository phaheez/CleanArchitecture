using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Queries
{
    public record GetAllEmployeeQuery() : IRequest<List<Core.Entities.Employee>>;
}
