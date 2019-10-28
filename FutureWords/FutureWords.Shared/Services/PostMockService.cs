using FutureWords.Shared.Models;
using System;
using System.Collections.Generic;

namespace FutureWords.Shared.Services
{
    public class PostMockService : IPostService
    {
        public List<Post> GetPosts()
        {
            return new List<Post>
            {
                new Post { Title = "Title", Category = "XR", Content = "Content", PublicationDate = DateTime.Now },
                new Post { Title = "Title 2", Category = "XR", Content = "Content 2", PublicationDate = DateTime.Now }
            };
        }
    }
}
