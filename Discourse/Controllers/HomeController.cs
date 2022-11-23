using Discourse.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Discourse.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            var postList = _context.Posts.OrderByDescending(p => p.TimeStamp).ToList();
            var feedList = new List<Post>();
            var friendList = _context.Friends.Where(f => f.UserId == id).ToList();
            var comments = _context.Comments.OrderByDescending(c => c.TimeStamp).ToList();
            var friendId = "";

            foreach (var post in postList)
            {
                for (int i = 0; i < friendList.Count; i++)
                {
                    friendId = friendList[i].FriendUsersId;

                    if (post.UserId == friendId)
                    {
                        feedList.Add(post);
                    }
                }

            }

            var pvm = new ProfileViewModel();
            pvm.UserPosts = feedList;
            pvm.Comments = comments;
            pvm.User = _context.Users.Find(id);

            return View(pvm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}