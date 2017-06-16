using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MiniBlog2.Infrastructure.Repositories;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniBlog2.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUserRepository _userRepository;

        public BaseController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
