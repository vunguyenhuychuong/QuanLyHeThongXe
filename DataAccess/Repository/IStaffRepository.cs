using BusinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IStaffRepository
    {
        StaffAccount LoginByStaffAccount( String email, String password);

        IEnumerable<StaffAccount> GetStaffAccounts();
        StaffAccount GetStaffByID(String staffId);
        StaffAccount GetStaffByEmail(string email);
        void InsertStaff(StaffAccount staff);
        void DeleteStaff(string staffID);
        void UpdateStaff(StaffAccount staff);
        
    }
}
