using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Task;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.Requests.Task
{
    public interface IRemoveEmployeeFromTaskValidator : IValidationService<RemoveEmployeeFromTaskRequest>
    {

    }

    internal sealed class RemoveEmployeeFromTaskValidator : FluentValidationService<RemoveEmployeeFromTaskRequest>, IRemoveEmployeeFromTaskValidator
    {
        public RemoveEmployeeFromTaskValidator()
        {
            RuleFor(x => x.TaskId)
                .GreaterThan(0)
                .WithErrorCode("BRL-144.1");

            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithErrorCode("BRL-144.2");
        }
    }
}
