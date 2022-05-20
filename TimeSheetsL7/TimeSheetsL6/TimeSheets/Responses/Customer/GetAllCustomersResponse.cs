using System.Collections.Generic;

namespace Timesheets.Responses.Customer
{
    public class GetAllCustomersResponse
    {
        public List<CustomerDto> Customers { get; set; }
    }
}
