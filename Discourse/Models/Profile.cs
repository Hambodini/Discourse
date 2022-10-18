using System;
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
        public string ProfilePicUrl { get; set; }
        public string BannerPicUrl { get; set; }

        public Profile()
        {
            ProfilePicUrl = "~/wwwroot/ProfilePic/NoPic.jpg";
            BannerPicUrl = "~/wwwroot/BannerPic/NoBanner.jpg";
        }

        public Profile(string profilePicName, string bannerPicName)
        {
            ProfilePicUrl = "~/wwwroot/ProfilePic/" + profilePicName;
            BannerPicUrl = "~/wwwroot/BannerPic/" + bannerPicName;
        }
    }
}