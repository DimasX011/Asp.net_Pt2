using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Customer;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.CustomerValidation
{
    public interface IGetCustomerByIdValidator : IValidationService<GetCustomerByIdRequest>
    {

    }

    internal sealed class GetCustomerByIdValidator : FluentValidationService<GetCustomerByIdRequest>, IGetCustomerByIdValidator
    {
        public GetCustomerByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-112.1");
        }
    }
}
