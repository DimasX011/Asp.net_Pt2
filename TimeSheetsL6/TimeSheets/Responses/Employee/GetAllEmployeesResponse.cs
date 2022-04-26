using System.Collections.Generic;

namespace Timesheets.Responses.Employee
{
    public class GetAllEmployeesResponse
    {
        public List<EmployeeDto> Employees { get; set; }
    }
}
