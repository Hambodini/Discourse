using Discourse.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Discourse.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            //Display all reports
            NotImplementedException ex = new NotImplementedException();
            throw ex;
        }

        [HttpGet]
        public ActionResult AddReportedPost(int postId)
        {
            var reporterId = User.Identity.GetUserId();
            var dateReported = DateTime.Now;
            var post = _context.Posts.Find(postId);

            var reportedPost = new ReportedPost();
            reportedPost.ReporterUserId = reporterId;
            reportedPost.DateReported = dateReported;
            reportedPost.ReportedUserId = post.UserId;
            reportedPost.PostId = post.Id;
            reportedPost.FirstName = post.FirstName;
            reportedPost.LastName = post.LastName;
            reportedPost.Title = post.Title;
            reportedPost.Body = post.Body;
            reportedPost.TimeStamp = post.TimeStamp;

            return View(reportedPost);
        }

        [HttpPost]
        public ActionResult AddReportedPostConfirmed(ReportedPost reportedPost)
        {
            int i = 0;
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