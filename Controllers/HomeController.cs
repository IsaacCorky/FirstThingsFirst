using FirstThingsFirst.Models;
using FirstThingsFirst.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstThingsFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TaskListContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, TaskListContext con)
        {
            _logger = logger;
            context = con;
        }

        public IActionResult Index()
        {
            return View(new QuadrantViewModel
            {
                Quadrant1 = context.Tasks
                    .Where(x => x.TaskUrgent == true && x.TaskImportant == true),
                Quadrant2 = context.Tasks
                    .Where(x => x.TaskUrgent == false && x.TaskImportant == true),
                Quadrant3 = context.Tasks
                    .Where(x => x.TaskUrgent == true && x.TaskImportant == false),
                Quadrant4 = context.Tasks
                    .Where(x => x.TaskUrgent == false && x.TaskImportant == false)
            });
        }

        [HttpGet]
        public IActionResult EnterTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterTask(TaskItem t)
        {
            if (ModelState.IsValid)
            {
                // Update DB
                context.Tasks.Add(t);
                context.SaveChanges();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
