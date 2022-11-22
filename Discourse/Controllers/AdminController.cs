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
            var reportedList = _context.ReportedPosts.OrderBy(p => p.DateReported).ToList();
            
            if (User.IsInRole("Admin"))
            {
                return View(reportedList);
            }

            return HttpNotFound();
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
            _context.ReportedPosts.Add(reportedPost);
            _context.SaveChanges();

            return RedirectToAction("ProfileFeed", "Profile");
        }

        public ActionResult ReportedPost(int reportId)
        {
            if (User.IsInRole("Admin"))
            {
                var reportedPost = _context.ReportedPosts.SingleOrDefault(p => p.Id == reportId);

                return View(reportedPost);
            }
            return HttpNotFound();
        }

        public ActionResult DeleteReport(int reportId)
        {
            if (User.IsInRole("Admin"))
            {
                var reportedPost = _context.ReportedPosts.SingleOrDefault(p => p.Id == reportId);
                _context.ReportedPosts.Remove(reportedPost);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        public ActionResult DeletePost(int reportId)
        {
            if (User.IsInRole("Admin"))
            {
                var reportedPost = _context.ReportedPosts.SingleOrDefault(p => p.Id == reportId);
                var post = _context.Posts.SingleOrDefault(p => p.Id == reportedPost.PostId);
                _context.Posts.Remove(post);
                _context.ReportedPosts.Remove(reportedPost);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        public ActionResult DeleteBan(int bannedDayAmount, int reportId)
        {
            if (User.IsInRole("Admin"))
            {
                //Ban user for specified # of days
                var reportedPost = _context.ReportedPosts.SingleOrDefault(p => p.Id == reportId);
                var user = _context.Users.Find(reportedPost.ReportedUserId);
                var currentDate = DateTime.Now;
                var endDate = currentDate.AddDays(bannedDayAmount);
                user.LockoutEndDateUtc = endDate;

                //Delete report and post
                var reportedPostId = reportedPost.PostId;
                var post = _context.Posts.SingleOrDefault(p => p.Id == reportedPostId);

                _context.Posts.Remove(post);
                _context.ReportedPosts.Remove(reportedPost);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }
    }
}