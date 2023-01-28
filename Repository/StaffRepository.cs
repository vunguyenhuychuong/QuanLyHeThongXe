using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StaffRepository : IStaffRepository
    {
        public void DeleteStaff(string staffID) => StaffDAO.Instance.DeleteStaff(staffID);
        public IEnumerable<StaffAccount> GetStaffAccounts() => StaffDAO.Instance.GetList();

        public StaffAccount GetStaffByEmail(string email) => StaffDAO.Instance.GetStaffByEmail(email);
       
        public StaffAccount GetStaffByID(string staffId) => StaffDAO.Instance.GetStaffByID(staffId);

        public void InsertStaff(StaffAccount staff) => StaffDAO.Instance.InsertStaff(staff);

        public StaffAccount LoginByStaffAccount(string email, string password) => StaffDAO.Instance.LoginByStaffAccount(email, password);
        public void UpdateStaff(StaffAccount staff) => StaffDAO.Instance.UpdateStaff(staff);

    }
}
