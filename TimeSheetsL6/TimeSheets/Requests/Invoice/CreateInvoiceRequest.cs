namespace Timesheets.Requests.Invoice
{
    public class CreateInvoiceRequest
    {
        public long ContractId { get; set; }

        public long TaskId { get; set; }
    }
}
