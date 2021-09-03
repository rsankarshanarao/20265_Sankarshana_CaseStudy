using JobTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.Services
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUser(int Id);
        User AddUser(User u);
        User UpdateUser(User u);
        string DeleteUser(int Id);
    }
}
