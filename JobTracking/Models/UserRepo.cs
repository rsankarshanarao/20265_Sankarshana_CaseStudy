using JobTracking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.Models
{
    public class UserRepo : IUserRepository
    {
        static List<User> _UserList { get; set; }
        public UserRepo()
        {
            _UserList = new List<User>()
            {
                new User()
                {
                    UserID = 1,
                    Username = "sankarshana.rao",
                    Email = "sankarshana.rao@sonata-software.com",
                    FirstName = "Sankarshana",
                    LastName = "Rao R",
                    ContactNumber = "9066774590",
                    Role = "Admin",
                    DOB = DateTime.Now,
                    CreatedOn = DateTime.Today,
                    IsActive = true
                }
            };
        }

        public List<User> GetAllUsers()
        {
            return _UserList;
        }

        public User GetUser(int Id)
        {
            User usr = _UserList.SingleOrDefault(u => u.UserID == Id);
            return usr;
        }

        public User AddUser(User u)
        {
            _UserList.Add(u);
            return u;
        }

        public User UpdateUser(User u)
        {
            User usr = _UserList.FirstOrDefault(u => u.UserID == u.UserID);
            if (usr != null)
            {
                usr.Email = u.Email;
                usr.FirstName = u.FirstName;
                usr.LastName = u.LastName;
                usr.ContactNumber = u.ContactNumber;
                usr.Role = u.Role;
                usr.DOB = u.DOB;
                usr.IsActive = u.IsActive;
            }
            return usr;
        }

        public string DeleteUser(int Id)
        {
            User u = _UserList.Where(usr => usr.UserID == Id).SingleOrDefault();
            if (u != null)
            {
                _UserList.Remove(u);
            }
            return "Deleted";
        }
    }
}
        
