using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Discourse.Models
{
    public class ProfileViewModel
    {
        public ApplicationUser User { get; set; }
        public Profile UserProfile { get; set; }
        public Post NewPost { get; set; }
        public Comment NewComment { get; set; }
        public List<Post> UserPosts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Post> LikedPosts { get; set; }
        public List<ApplicationUser> Friends { get; set; }

        [DataType(DataType.Upload)]
        public string BannerFile { get; set; }

        [DataType(DataType.Upload)]
        public string IconFile { get; set; }
    }
}