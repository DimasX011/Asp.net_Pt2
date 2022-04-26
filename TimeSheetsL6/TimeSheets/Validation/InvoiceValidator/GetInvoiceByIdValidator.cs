using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Invoice;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.EnvoiceValidator
{
    public interface IGetInvoiceByIdValidator : IValidationService<GetInvoiceByIdRequest>
    {

    }

    internal sealed class GetInvoiceByIdValidator : FluentValidationService<GetInvoiceByIdRequest>, IGetInvoiceByIdValidator
    {
        public GetInvoiceByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-122.1");
        }
    }
}
