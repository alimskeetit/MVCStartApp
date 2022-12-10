using Microsoft.AspNetCore.Mvc;
using MVCStartApp2.Models;
using MVCStartApp2.Models.DataBase;
using System.Diagnostics;

namespace MVCStartApp2.Controllers
{
    public class FeedbackController: Controller
    {
        //Метод, возвращающий страницу с отзывами
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Метод для AJAX-запросов
        [HttpPost]
        public IActionResult Add(Feedback feedback)
        {
            return StatusCode(200, $"{feedback.From}, спасибо за отзыв!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
