using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Employee;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.EmployeeValidator
{
    public interface IGetEmployeeByIdValidator : IValidationService<GetEmployeeByIdRequest>
    {

    }

    internal sealed class GetEmployeeByIdValidator : FluentValidationService<GetEmployeeByIdRequest>, IGetEmployeeByIdValidator
    {
        public GetEmployeeByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-122.1");
        }
    }
}
