using Microsoft.AspNetCore.Mvc;
using WindowsInput;
using WindowsInput.Native;

namespace SlidesController.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly InputSimulator sim = new InputSimulator();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Previous()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.LEFT);
            return Ok();
        }

        public IActionResult Next()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
            return Ok();
        }
    }
}