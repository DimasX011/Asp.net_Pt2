using System.Collections.Generic;

namespace Timesheets.Responses.Customer
{
    public class CustomerDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<TimeSheets.Controllers.Models.Contract> Contracts { get; set; }
        public CustomerDto()
        {
            Contracts = new List<TimeSheets.Controllers.Models.Contract>();
        }
    }
}
