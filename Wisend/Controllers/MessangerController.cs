using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wisend.Controllers
{
    public class MessangerController : Controller
    {
        public ActionResult Chats()
        {
            ViewBag.Message = "Данил и Влад, здесь будет наш чат";

            return View();
        }
    }
}