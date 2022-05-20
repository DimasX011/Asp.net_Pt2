using FluentValidation;
using Timesheets.Requests;
using Timesheets.Requests.Task;
using Timesheets.Validation.ServicesValidator;

namespace Timesheets.Validation.Requests.Task
{
    public interface IGetTaskByIdValidator : IValidationService<GetTaskByIdRequest>
    {

    }

    internal sealed class GetTaskByIdValidator : FluentValidationService<GetTaskByIdRequest>, IGetTaskByIdValidator
    {
        public GetTaskByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-142.1");
        }
    }
}
