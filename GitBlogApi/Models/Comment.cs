// Filename: Comment.cs

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitBlogApi.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }
        public virtual Post Post { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
