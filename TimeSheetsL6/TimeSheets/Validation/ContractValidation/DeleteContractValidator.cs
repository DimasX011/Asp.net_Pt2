using FluentValidation;
using Timesheets.Requests;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.ContractValidation
{
    public interface IDeleteContractValidator : IValidationService<DeleteContractRequest>
    {

    }

    internal sealed class DeleteContractValidator : FluentValidationService<DeleteContractRequest>, IDeleteContractValidator
    {
        public DeleteContractValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-101.1");

            RuleFor(x => x.CustomerId)
                .GreaterThan(0)
                .WithErrorCode("BRL-101.2");
        }
    }
}
