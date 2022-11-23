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
            var userList = _context.Users.ToList();

            return View(userList);
        }

        public ActionResult SearchPeople(string searchText)
        {
            string[] name = searchText.Split(' ');
            string firstName = name[0];
            string lastName = name[1];

            var searchList = _context.Users.Where(p => p.FirstName == firstName).Where(p => p.LastName == lastName).OrderBy(p => p.LastName).ToList();

            return View("Index", searchList);
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

        public ActionResult FriendsList()
        {
            var friends = new List<ApplicationUser>();
            var id = User.Identity.GetUserId();
            var friendsList = _context.Friends.Where(f => f.UserId == id).ToList();

            foreach (var friend in friendsList)
            {
                var user = _context.Users.First(f => f.Id == friend.FriendUsersId);
                friends.Add(user);
            }

            return View(friends);
        }
    }
}