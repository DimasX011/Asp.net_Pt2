using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Requests.Task;


namespace TimeSheets.DAL.Interfaces
{
    public interface ITask
    {
        Task Create(CreateTaskRequest request);
        Task Delete(DeleteTaskRequest request);
        Task<List<Timesheets.Controllers.Models.Task>> GetAll();
        Task<Timesheets.Controllers.Models.Task> GetById(GetTaskByIdRequest request);
        Task AddEmployeeToTask(AddEmployeeToTaskRequest request);
        Task RemoveEmployeeFromTask(RemoveEmployeeFromTaskRequest request);
        Task CloseTask(CloseTaskRequest request);
    }
}
