using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Marriage.Models;

namespace Marriage.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        MarriageexpDBContext DBContext = new MarriageexpDBContext();

        public ActionResult Index()
        {
            return View();
        }

    }
}
