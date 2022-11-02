﻿using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Discourse.Models;
using Microsoft.AspNet.Identity;

namespace Discourse.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext _context;

        public ProfileController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult _Banner()
        {
            var id = User.Identity.GetUserId();
            var pvm = new ProfileViewModel();

            pvm.UserProfile = _context.Profiles.Where(p => p.UserId == id).ToArray()[0];
            return View(pvm);
        }

        // GET: Profile
        [Authorize]
        public ActionResult Posts()
        {
            var post = new Post();
            var id = User.Identity.GetUserId();
            post.UserId = id;

            //Get posts of logged in user
            var userPosts = _context.Posts.Where(p => p.UserId == id).OrderByDescending(p => p.TimeStamp).ToList();

            //Get list of comments in db
            var comments = _context.Comments.OrderByDescending(c => c.TimeStamp).ToList();

            var pvm = new ProfileViewModel();
            pvm.User = _context.Users.Find(id);
            pvm.UserProfile = _context.Profiles.Where(p => p.UserId == id).ToArray()[0];
            pvm.UserPosts = userPosts;
            pvm.NewPost = post;
            pvm.Comments = comments;
            return View(pvm);
        }

        // POST: Profile


        [Authorize]
        public ActionResult Settings()
        {
            var id = User.Identity.GetUserId();
            var pvm = new ProfileViewModel();
            pvm.User = _context.Users.Find(id);
            pvm.UserProfile = _context.Profiles.Where(p => p.UserId == id).ToArray()[0];
            return View(pvm);
        }

        [Authorize]
        public ActionResult Likes()
        {
            var id = User.Identity.GetUserId();
            var pvm = new ProfileViewModel();
            pvm.User = _context.Users.Find(id);
            pvm.UserProfile = _context.Profiles.Where(p => p.UserId == id).ToArray()[0];
            return View(pvm);
        }

        [Authorize]
        public ActionResult Friends()
        {
            var id = User.Identity.GetUserId();
            var pvm = new ProfileViewModel();
            pvm.User = _context.Users.Find(id);
            pvm.UserProfile = _context.Profiles.Where(p => p.UserId == id).ToArray()[0];

            var friendsList = _context.Friends.Where(f => f.UserId == id).ToArray();
            foreach (var friend in friendsList)
            {
                var user = _context.Users.First(f => f.Id == friend.FriendUsersId);
                pvm.Friends.Add(user);
            }
            return View(pvm);
        }

        public ActionResult NewPost(ProfileViewModel model)
        {
            var timeStamp = DateTime.Now;

            // Enter new post in db
            var post = new Post();
            post.UserId = model.User.Id;
            post.Title = model.NewPost.Title;
            post.Body = model.NewPost.Body;
            post.TimeStamp = timeStamp;

            _context.Posts.Add(post);
            _context.SaveChanges();

            var pvm = model;

            // Refresh posts in model
            var userPosts = _context.Posts.Where(p => p.UserId == model.User.Id).OrderByDescending(p => p.TimeStamp).ToList();
            pvm.UserPosts = userPosts;

            return View("Posts", pvm);
        }

        // Delete Post
        public ActionResult DeletePost(int postId)
        {
            var post = _context.Posts.Find(postId);
            _context.Posts.Remove(post);
            _context.SaveChanges();

            return RedirectToAction("Posts");
        }

        public ActionResult NewComment(ProfileViewModel pvm, string userId, int postId)
        {
            var user = _context.Users.Find(userId);

            var comment = new Comment();
            comment.PostId = postId;
            comment.UserId = userId;
            comment.FirstName = user.FirstName;
            comment.LastName = user.LastName;
            comment.Body = pvm.NewComment.Body;
            comment.TimeStamp = DateTime.Now;

            if (comment.Body != null)
            {
                _context.Comments.Add(comment);
                _context.SaveChanges();
            }
            
            return RedirectToAction("Posts");
        }

        [HttpPost]
        public ActionResult ChangeProfile(ProfileViewModel model, HttpPostedFileBase BannerFile, HttpPostedFileBase IconFile)
        {
            var profile = _context.Profiles.First(p => p.Id == model.UserProfile.Id);
            var userId = profile.UserId;

            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            if (BannerFile != null)
            {
                var file = BannerFile.FileName;
                var ext = file.Substring(file.LastIndexOf('.') + 1).ToLower();

                if (ext == "png" || ext == "jpg" || ext == "jpg")
                {
                    var dirString = "/wwwroot/BannerPic";
                    var dir = Server.MapPath(Url.Content(dirString));
                    var path = Path.Combine(dir, userId + '.' + ext);

                    BannerFile.SaveAs(path);
                    profile.BannerPicUrl = dirString + '/' + userId + '.' + ext;
                }
            }

            if (IconFile != null)
            {
                var file = IconFile.FileName;
                var ext = file.Substring(file.LastIndexOf('.') + 1).ToLower();

                if (ext == "png" || ext == "jpg" || ext == "jpg")
                {
                    var dirString = "/wwwroot/ProfilePic";
                    var dir = Server.MapPath(Url.Content(dirString));
                    var path = Path.Combine(dir, userId + '.' + ext);

                    IconFile.SaveAs(path);
                    profile.ProfilePicUrl = dirString + '/' + userId + '.' + ext;
                }
            }

            profile.Bio = model.UserProfile.Bio;

            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return RedirectToAction("Settings");
        }

        public ActionResult ResetBanner()
        {
            var id = User.Identity.GetUserId();
            var profile = _context.Profiles.First(p => p.UserId == id);

            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            profile.BannerPicUrl = "/wwwroot/BannerPic/NoBanner.jpg";

            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return RedirectToAction("Settings");
        }

        public ActionResult ResetIcon()
        {
            var id = User.Identity.GetUserId();
            var profile = _context.Profiles.First(p => p.UserId == id);

            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            profile.ProfilePicUrl = "/wwwroot/ProfilePic/NoPic.jpg";

            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return RedirectToAction("Settings");
        }
    } 
}