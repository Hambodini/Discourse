﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Discourse.Models
{
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public string Status { get; set; }
        public string Bio { get; set; }
        public int MyProperty { get; set; }
        public string ProfilePicUrl { get; set; }
        public string BannerPicUrl { get; set; }

        public Profile()
        {
            ProfilePicUrl = "~/wwwroot/ProfilePic/NoPic.jpg";

            //Need no banner default picture still
            BannerPicUrl = "~/wwwroot/ProfilePic/NoBanner.jpg";
        }
    }
}