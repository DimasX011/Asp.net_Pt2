using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Task;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.Requests.Task
{
    public interface IDeleteTaskValidator : IValidationService<DeleteTaskRequest>
    {

    }

    internal sealed class DeleteTaskValidator : FluentValidationService<DeleteTaskRequest>, IDeleteTaskValidator
    {
        public DeleteTaskValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-141.1");
        }
    }
}
