using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController
    {
        public IActionResult Index()
        {
            return Index();
        }

        public IActionResult Error()
        {
            return Error();
        }

        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }
    }


}
