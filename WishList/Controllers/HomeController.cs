using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController
    {
        public Task<IActionResult> Index()
        {
            return Index();
        }

        public Task<IActionResult> Error()
        {
            return Error();
        }
    }


}
