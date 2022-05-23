using FluentValidation;
using Timesheets.Requests;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.ContractValidation
{
    public interface IGetAllContractsValidator : IValidationService<GetAllContractsRequest>
    {

    }

    internal sealed class GetAllContractsValidator : FluentValidationService<GetAllContractsRequest>, IGetAllContractsValidator
    {
        public GetAllContractsValidator()
        {
            RuleFor(x => x.CustomerId)
                .GreaterThan(0)
                .WithErrorCode("BRL-102.1");
        }
    }
}
