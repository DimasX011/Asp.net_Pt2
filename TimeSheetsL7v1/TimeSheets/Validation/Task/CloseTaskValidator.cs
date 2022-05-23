using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Task;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.Requests.Task
{
    public interface ICloseTaskValidator : IValidationService<CloseTaskRequest>
    {

    }

    internal sealed class CloseTaskValidator : FluentValidationService<CloseTaskRequest>, ICloseTaskValidator
    {
        public CloseTaskValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-145.1");
        }
    }
}
