using BookStore.BasicProject.Application.Contracts.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore.BasicProject.Web
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserAppService _userAppService;
        public HomeController(ILogger<HomeController> logger,IUserAppService userAppService)
        {
            _logger = logger; 
            _userAppService = userAppService;
        }
        public IActionResult Index()
        {
            var user = _userAppService.GetUserAsync(123);
            System.Console.WriteLine(user.Result.UserName);
            return new JsonResult(user.Result);
        }
    }
}
