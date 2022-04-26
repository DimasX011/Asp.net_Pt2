using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Task;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.Requests.Task
{
    public interface ICreateTaskValidator : IValidationService<CreateTaskRequest>
    {

    }

    internal sealed class CreateTaskValidator : FluentValidationService<CreateTaskRequest>, ICreateTaskValidator
    {
        public CreateTaskValidator()
        {
            RuleFor(x => x.PricePerHour)
                .GreaterThan(0)
                .WithErrorCode("BRL-140.1");
        }
    }
}
