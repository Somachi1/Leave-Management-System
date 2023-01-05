using leave_management_system.Contracts;
using leave_management_system.Data;
using System.Collections.Generic;
using System.Linq;

namespace leave_management_system.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            var leaveHistory = _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            var leaveHistory = _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var leaveHistories = _db.LeaveHistories.ToList();
            return leaveHistories;
        }

        public LeaveHistory FindById(int Id)
        {
            var leaveHistory = _db.LeaveHistories.Find(Id);
            return leaveHistory;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            var leaveHistories = _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
