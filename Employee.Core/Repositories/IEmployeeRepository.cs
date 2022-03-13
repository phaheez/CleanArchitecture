using Employee.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Entities.Employee>
    {
        //custom operations here
        Task<IEnumerable<Entities.Employee>> GetEmployeeByLastName(string lastname);
    }
}
