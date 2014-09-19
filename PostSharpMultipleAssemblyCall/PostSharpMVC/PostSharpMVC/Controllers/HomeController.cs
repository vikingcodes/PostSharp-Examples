using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostSharpMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            //Code for test aspect start from here
            
            ClassProject2.UseAspect useAspect=new ClassProject2.UseAspect();
            useAspect.TestingAspect();

            return View();
        }
 
 
    }
}
