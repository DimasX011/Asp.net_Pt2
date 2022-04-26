using System.Collections.Generic;
using Timesheets.Requests;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Model = Timesheets.Controllers.Models;
using System;
using TimeSheets.DAL.Repositories.DataBase;
using Timesheets.Requests.Task;
using TimeSheets.DAL.Interfaces;
using Microsoft.Extensions.Logging;

namespace Timesheets.Repositories
{
  
    public class TaskRepository : ITask
    {
        UserDbContext _context;
        private readonly ILogger<TaskRepository> _logger;

        public TaskRepository(UserDbContext context, ILogger<TaskRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task AddEmployeeToTask(AddEmployeeToTaskRequest request)
        {
            try
            {
                var item = await _context
                    .Tasks
                    .Where(x => x.Id == request.TaskId)
                    .SingleOrDefaultAsync();

                item.AddEmployee(request.EmployeeId);
                await _context.SaveChangesAsync();
            }
            catch (Exception except)
            {
                _logger.LogError(except.Message);
            }
        }

        public async Task CloseTask(CloseTaskRequest request)
        {
            try
            {
                var item = await _context
                    .Tasks
                    .Where(x => x.Id == request.Id)
                    .SingleOrDefaultAsync();

                item.Close(new Model.SystemTime());
                await _context.SaveChangesAsync();
            }
            catch (Exception except)
            {
                _logger.LogError(except.Message);
            }
        }

        public async Task Create(CreateTaskRequest request)
        {
            try
            {
                var lastItem = await _context
                    .Tasks
                    .OrderBy(x => x.Id)
                    .LastOrDefaultAsync();
                var id = lastItem != null ? lastItem.Id + 1 : 1;
                var factory = new Model.TaskFactory();
                var item = factory.Create(id, request.PricePerHour, new Model.SystemTime());

                await _context.Tasks.AddAsync(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }
        }

        public async Task Delete(DeleteTaskRequest request)
        {
            try
            {
                var item = await _context
                    .Tasks
                    .Where(x => x.Id == request.Id)
                    .SingleOrDefaultAsync();

                _context.Tasks.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }
        }

        public async Task<List<Model.Task>> GetAll()
        {
            try
            {
                return await _context.Tasks.ToListAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }

            return null;
        }

        public async Task<Model.Task> GetById(GetTaskByIdRequest request)
        {
            try
            {
                return await _context
                    .Tasks
                    .Where(x => x.Id == request.Id)
                    .SingleOrDefaultAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }

            return null;
        }

        public async Task RemoveEmployeeFromTask(RemoveEmployeeFromTaskRequest request)
        {
            try
            {
                var item = await _context
                    .Tasks
                    .Where(x => x.Id == request.TaskId)
                    .SingleOrDefaultAsync();

                item.RemoveEmployee(request.EmployeeId);
                await _context.SaveChangesAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }
        }
    }
}
