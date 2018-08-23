using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YuruyenMerdivenIO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<SelectListItem> derece = new List<SelectListItem>();
            for(int i=0; i<=7; i ++)
            {
                derece.Add(new SelectListItem { Text = (i * 5).ToString(), Value = i.ToString() });
            }
            ViewBag.Derece = derece;
            //derece.Add(new SelectListItem { Text = "0", Value = "0" });
            return View();
        }
    }
}