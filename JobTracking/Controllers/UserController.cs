using JobTracking.Models;
using JobTracking.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.Controllers
{
    public class UserController : Controller
    {
        public IUserRepository _Repo { get; set; }
        public UserController(IUserRepository repo)
        {
            _Repo = repo;
        }
        public IActionResult Index()
        {
            List<User> users = _Repo.GetAllUsers();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User u)
        {
            _Repo.AddUser(u);
            return View("Index", _Repo.GetAllUsers());
        }

        public IActionResult Details(int Id)
        {
            User usr = _Repo.GetUser(Id);
            return View(usr);
        }

        public IActionResult Edit(int Id)
        {
            User usr = _Repo.GetUser(Id);
            return View(usr);
        }

        [HttpPost]
        public IActionResult Edit(User u)
        {
            _Repo.UpdateUser(u);
            return View("Details", _Repo.GetUser(u.UserID));
        }

        public IActionResult Delete(int Id)
        {
            _Repo.DeleteUser(Id);
            return View("Index", _Repo.GetAllUsers());
        }
        
        /*[HttpPost]*/
        /*public IActionResult Delete(int )
        {
            _Repo.DeleteUser(u);
            return View("Index", _Repo.GetAllUsers());
        }*/
    }
}
