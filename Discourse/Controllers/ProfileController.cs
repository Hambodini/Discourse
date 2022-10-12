﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Discourse.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        [Authorize]
        public ActionResult Profile()
        {
            return View();
        }

        [Authorize]
        public ActionResult Settings()
        {
            return View();
        }
    }
}