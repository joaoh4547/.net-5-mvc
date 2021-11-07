using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<User> {
                new User{ Id=1,FirstName="João Ferreira",LastName="da Silva",Email="joao.ferreira@gmail.com",BirthDate=new DateTime(1997,12,05)}
            };
            return View(users);
        }
    }
}
