﻿using leave_management_system.Contracts;
using leave_management_system.Data;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

namespace leave_management_system.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();
            return leaveTypes;
        }

        public LeaveType FindById(int Id)
        {
            var leaveType = _db.LeaveTypes.Find(Id);
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeeByLeaveType(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;   
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
