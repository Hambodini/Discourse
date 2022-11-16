using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Discourse.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult Index()
        {
            //Display all reports
            NotImplementedException ex = new NotImplementedException();
            throw ex;
        }

        public ActionResult ReportedPost()
        {
            //Display a reported post 
            NotImplementedException ex = new NotImplementedException();
            throw ex;
        }

        [HttpGet]
        public ActionResult BanUser()
        {
            //ban user input page
            NotImplementedException ex = new NotImplementedException();
            throw ex;
        }

        [HttpPost]
        public ActionResult BanUser(string parameter)
        {
            //ban user success page
            NotImplementedException ex = new NotImplementedException();
            throw ex;
        }

    }
}