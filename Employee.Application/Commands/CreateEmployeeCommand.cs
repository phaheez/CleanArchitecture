using Employee.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Commands
{
    //public record CreateEmployeeCommand(
    //    string FirstName,
    //    string LastName,
    //    DateTime DateOfBirth,
    //    string PhoneNumber,
    //    string Email) : IRequest<EmployeeResponse>;

    public class CreateEmployeeCommand : IRequest<EmployeeResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
