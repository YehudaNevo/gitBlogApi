// Filename: Post.cs

using System;
using System.Collections.Generic;

namespace GitBlogApi.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
