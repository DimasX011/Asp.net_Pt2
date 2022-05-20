using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Employee;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.EmployeeValidator
{
    public interface IDeleteEmployeeValidator : IValidationService<DeleteEmployeeRequest>
    {

    }

    internal sealed class DeleteEmployeeValidator : FluentValidationService<DeleteEmployeeRequest>, IDeleteEmployeeValidator
    {
        public DeleteEmployeeValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-121.1");
        }
    }
}
