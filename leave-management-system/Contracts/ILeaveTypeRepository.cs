using leave_management_system.Data;
using System.Collections.Generic;

namespace leave_management_system.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeeByLeaveType(int Id);
    }
}
