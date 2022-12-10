using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCStartApp2.Models.DataBase;
using System.Threading.Tasks;

namespace MVCStartApp2.Controllers
{
    public class LogsController : Controller
    {
        private readonly IRequestRepository _repo;

        public LogsController(IRequestRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Logs()
        {
            return View(await _repo.GetRequests());
        }
    }
}
