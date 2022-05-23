using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Employee;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.EmployeeValidator
{
    public interface ICreateEmployeeValidator : IValidationService<CreateEmployeeRequest>
    {

    }

    internal sealed class CreateEmployeeValidator : FluentValidationService<CreateEmployeeRequest>, ICreateEmployeeValidator
    {
        public CreateEmployeeValidator()
        {
            RuleFor(x => x.Name)
                .Length(3, 20)
                .WithErrorCode("BRL-120.1");
        }
    }
}
