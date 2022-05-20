namespace Timesheets.Requests.Task
{
    public class RemoveEmployeeFromTaskRequest
    {
        public long EmployeeId { get; set; }
        public long TaskId { get; set; }
    }
}
