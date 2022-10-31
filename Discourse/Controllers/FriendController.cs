using Discourse.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Discourse.Controllers
{
    public class FriendController : Controller
    {
        private ApplicationDbContext _context;

        public FriendController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Friend
        public ActionResult Index()
        {
            var userList = _context.Profiles.ToList();

            return View(userList);
        }

        public ActionResult AddFriend(string friendId)
        {
            var id = User.Identity.GetUserId();

            var friends = new Friend();
            friends.UserId = id;
            friends.FriendUsersId = friendId;

            _context.Friends.Add(friends);
            _context.SaveChanges();

            return RedirectToAction("Index"); 
        }
    }
}