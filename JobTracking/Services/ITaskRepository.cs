using JobTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JobTracking.Services
{
    interface ITaskRepository
    {
        List<Task> GetAllUsers();
        Task GetUser(int Id);
        Task AddUser(User u);
        Task UpdateUser(User u);
        string DeleteUser(int Id);
    }
}
