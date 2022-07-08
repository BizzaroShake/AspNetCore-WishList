using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController
    {
        public ActionResult Index()
        {
            return Index();
        }

        public ActionResult Error()
        {
            return Error();
        }

        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }
    }


}
