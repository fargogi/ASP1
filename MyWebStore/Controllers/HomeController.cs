using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebStore.Models;

namespace MyWebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                ID = 1,
                FirstName = "Иван",
                Patronymic="Иванович",
                SurName="Иванов",
                Age=44

            },
             new EmployeeView
            {
                ID = 2,
                FirstName = "Петр",
                Patronymic="Петрович",
                SurName="Петров",
                Age=57

            }
        };


        public IActionResult Index()
        {
            return View(_employees);
        }
    }
}