using System.Collections.Generic;

namespace Timesheets.Responses.Contract
{
    public class GetAllContractsResponse
    {
        public List<ContractDto> Contracts { get; set; }
    }
}
