using Employee.Application.Queries;
using Employee.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Handlers.QueryHandlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Core.Entities.Employee>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public GetEmployeeByIdHandler(IEmployeeRepository employeeRepository) => _employeeRepo = employeeRepository;

        public async Task<Core.Entities.Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken) => await _employeeRepo.GetByIdAsync(request.EmployeeId);
    }
}
