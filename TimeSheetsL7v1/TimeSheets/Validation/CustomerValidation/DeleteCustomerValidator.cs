using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Customer;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.CustomerValidation
{
    public interface IDeleteCustomerValidator : IValidationService<DeleteCustomerRequest>
    {

    }

    internal sealed class DeleteCustomerValidator : FluentValidationService<DeleteCustomerRequest>, IDeleteCustomerValidator
    {
        public DeleteCustomerValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-111.1");
        }
    }
}
