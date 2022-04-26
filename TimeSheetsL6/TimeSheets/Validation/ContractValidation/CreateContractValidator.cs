using FluentValidation;
using Timesheets.Requests;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.ContractValidation
{
    public interface ICreateContractValidator : IValidationService<CreateContractRequest>
    {

    }

    internal sealed class CreateContractValidator : FluentValidationService<CreateContractRequest>, ICreateContractValidator
    {
        public CreateContractValidator()
        {
            RuleFor(x => x.CustomerId)
                .GreaterThan(0)
                .WithErrorCode("BRL-100.1");

            RuleFor(x => x.Name)
                .Length(3, 20)
                .WithErrorCode("BRL-100.2");
        }
    }
}
