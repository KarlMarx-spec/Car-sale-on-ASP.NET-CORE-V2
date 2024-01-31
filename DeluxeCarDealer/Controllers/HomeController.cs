using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using Data;
using Data.Services;
using Data.Models;
using Data.ViewModels;

namespace DeluxeCarDealer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IService _service;
        //[HttpPost]
        //public string GetData(RoleModel role)
        //{
        //    return role.login + role.password;
        //}
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetRole(RoleModel model)
        {
            var result = _service.Login(model);
            if (result == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (result.role == "admin")
            {

            }
            else if (result.role == "client")
            {
                TempData["login"] = model.login;
                return RedirectToAction("CatalogPage", "Home");
            }
            else if (result.role == "manager")
            {
                TempData["login"] = model.login;
                return RedirectToAction("ManagerPage", "Home");
            }
            
            return RedirectToAction("Login", "Home");
        }

        public HomeController(ILogger<HomeController> logger, IService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult CatalogPage()
        {
            string login = "";
            login += (string)TempData["login"];
            var models = _service.FillTable();
            var model = new CatalogViewModel
            {
                user_login = login,
                catalogModels = models
            };

            return View(model);
        }

        public IActionResult CarPage(int CarId)
        {
            var model = _service.ShowCar(CarId);

            return View(model);
        }

        public IActionResult ContactPage()
        {
            return View();
        }

        public IActionResult StartPage()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ManagerPage()
        {
            string login = "";
            login += (string)TempData["login"];
            var models = _service.FillTable();
            var model = new CatalogViewModel
            {
                user_login = login,
                catalogModels = models
            };

            return View(model);
        }

        public IActionResult ManagerReportPage()
        {
            var models = _service.GetReportData();
            var model = new ReportViewModel
            {
                SellModels = models,
            };
            return View(model);
        }

        public IActionResult DeleteCar(int CarId)
        {
            _service.DeleteCar(CarId);

            return RedirectToAction("ManagerPage", "Home");
        }

        public IActionResult AddCarPage()
        {
            return View();
        }

        public IActionResult AddCar(CarModel model)
        {
            var result = _service.AddCar(model);
            if (result)
            {
                return RedirectToAction("ManagerPage", "Home");
            }
            else
            {

            }

            return View();
        }

        public IActionResult SellingPage(int CarId)
        {
            return View(CarId);
        }

        public IActionResult SellingPage2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SellProcess(SellModel2 model)
        {
            _service.SellProcess(model.FIO, model.Phone, model.CarId);
            return RedirectToAction("SellingPage2", "Home");
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
