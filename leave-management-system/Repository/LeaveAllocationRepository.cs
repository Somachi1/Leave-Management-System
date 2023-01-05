using leave_management_system.Contracts;
using leave_management_system.Data;
using System.Collections.Generic;
using System.Linq;

namespace leave_management_system.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveAllocation entity)
        {
            var leaveAllocation = _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            var leaveAllocation = _db.LeaveAllocations.Remove(entity);
            return Save(); ;
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            var leaveAllocations = _db.LeaveAllocations.ToList();
            return leaveAllocations;
        }

        public LeaveAllocation FindById(int Id)
        {
            var leaveAllocation = _db.LeaveAllocations.Find(Id);
            return leaveAllocation;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
