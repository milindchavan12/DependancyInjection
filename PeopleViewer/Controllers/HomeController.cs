using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleViewer.Models;
using PeopleViewer.Presentation;
using SharedObjects;

namespace PeopleViewer.Controllers
{
    public class HomeController : Controller
    {
        PeopleViewModel vieweModel;

        public HomeController(IPersonReader personReader)
        {
            vieweModel = new PeopleViewModel(personReader);
        }

        public IActionResult Index()
        {
            return View(vieweModel.GetPeople());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
