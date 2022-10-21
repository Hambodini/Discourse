using System.Collections.Generic;

namespace Discourse.Models
{
    public class ProfileViewModel
    {
        public ApplicationUser User { get; set; }
        public Profile UserProfile { get; set; }
        public Post NewPost { get; set; }
        public List<Post> UserPosts { get; set; }
    }
}