using System.Linq;
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

        // GET: Profile
        [Authorize]
        public ActionResult Profile()
        {
            var id = User.Identity.GetUserId();
            var pvm = new ProfileViewModel();
            pvm.User = _context.Users.Find(id);
            pvm.UserProfile = _context.Profiles.Where(p => p.UserId == id).ToArray()[0];
            return View(pvm);
        }

        [Authorize]
        public ActionResult Settings()
        {
            var id = User.Identity.GetUserId();
            var pvm = new ProfileViewModel();
            pvm.User = _context.Users.Find(id);
            pvm.UserProfile = _context.Profiles.Where(p => p.UserId == id).ToArray()[0];
            return View(pvm);
        }
    }
}