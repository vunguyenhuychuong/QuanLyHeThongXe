using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StaffDAO
    {   
        CarRentalSystemDBContext dBContext = new CarRentalSystemDBContext();
        List<StaffAccount> staffAccounts = new List<StaffAccount>();

        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();

        private StaffDAO() { }

        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }

        public StaffAccount LoginByStaffAccount(string email, string password)
        {
            StaffAccount staffAccount = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                staffAccount = context.StaffAccounts.SingleOrDefault(c => c.Email == email && c.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffAccount;
        }

        public StaffAccount GetStaffById(String staffID)
        {
            StaffAccount staff = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                staff = context.StaffAccounts.SingleOrDefault(c => c.StaffId == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staff;
        }

        public IEnumerable<StaffAccount> GetList()
        {
            List<StaffAccount> staffAccounts;
            try
            {
                var db = new CarRentalSystemDBContext();
                staffAccounts = db.StaffAccounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return staffAccounts;
        }



        public StaffAccount GetStaffByID(string staffId)
        {
            StaffAccount staff = dBContext.StaffAccounts.SingleOrDefault(p => p.StaffId == staffId);
            return staff;
        }

        public void DeleteStaff(string staffID)
        {
            if (GetStaffByID(staffID) != null)
            {
                dBContext.Remove(dBContext.StaffAccounts.First<StaffAccount>(p => p.StaffId == staffID));
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Invalid ID");
            }
        }

        public void InsertStaff(StaffAccount staff)
        {
            if (GetStaffByID(staff.StaffId) == null)
            {
                dBContext.StaffAccounts.Add(staff);
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Staff ID is already exists.");

            }
        }

        public void UpdateStaff(StaffAccount staff)
        {
            var staffAcc = (from u in dBContext.StaffAccounts where u.StaffId == staff.StaffId select u).SingleOrDefault();
            if (staffAcc != null)
            {
                staffAcc.StaffId = staff.StaffId;
                staffAcc.Email = staff.Email;
                staffAcc.FullName = staff.FullName;
                staffAcc.Role = staff.Role;
                staffAcc.Password = staff.Password;
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Staff does not exitst");
            }
        }

        public StaffAccount GetStaffByEmail(string email)
        {
            StaffAccount staffAccount = dBContext.StaffAccounts.SingleOrDefault(p => p.Email == email);
            return staffAccount;
        }
    }
}
