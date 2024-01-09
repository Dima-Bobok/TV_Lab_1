using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using TV_Lab_1.Models;
using static TV_Lab_1.Controllers.HomeController;

namespace TV_Lab_1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            ViewData["Text"] = "Лабораторная работа 2";
            ViewData["Textt"] = "Форма";
            ViewData["Lst"] = new SelectList(_listDemo, "ListItemValue", "ListItemText");
            return View();
        }

        //Опишите класс
        //+++++
        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }

        //В контроллере Home опишите переменную, содержащую список объектов класса listDemo:
        private List<ListDemo> _listDemo;

        // Создайте конструктор класса HomeController.В конструкторе
        //выполните заполнение коллекции _listDemo двумя-тремя объектами:
        public HomeController()
        {
            _listDemo = new List<ListDemo>
            {
                new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
                new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
                new ListDemo { ListItemValue = 3, ListItemText = "Item 3" }
            };
        }

    }

}