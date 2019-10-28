using System;

namespace FutureWords.Shared.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        //public string Image { get; set; }
        public string Link { get; set; }
        public DateTime? PublicationDate { get; set; }
        
    }
}
