using FluentValidation;
using Timesheets.Requests;
using Timesheets.Validation.ServicesValidator;
using Timesheets.Requests.Customer;

namespace Timesheets.Validation.CustomerValidation
{
    public interface ICreateCustomerValidator : IValidationService<CreateCustomerRequest>
    {

    }

    internal sealed class CreateCustomerValidator : FluentValidationService<CreateCustomerRequest>, ICreateCustomerValidator
    {
        public CreateCustomerValidator()
        {
            RuleFor(x => x.Name)
                .Length(3, 20)
                .WithErrorCode("BRL-110.1");
        }
    }
}
