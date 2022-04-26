using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Invoice;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.EnvoiceValidator
{
    public interface IDeleteInvoiceValidator : IValidationService<DeleteInvoiceRequest>
    {

    }

    internal sealed class DeleteInvoiceValidator : FluentValidationService<DeleteInvoiceRequest>, IDeleteInvoiceValidator
    {
        public DeleteInvoiceValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-131.1");
        }
    }
}
