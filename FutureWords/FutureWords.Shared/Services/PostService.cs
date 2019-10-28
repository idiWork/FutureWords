using FutureWords.Shared.Models;
using System;
using System.Collections.Generic;

namespace FutureWords.Shared.Services
{
    public class PostService : IPostService
    {
        private readonly FeedReader _feedReader;

        public PostService()
        {
            _feedReader = new FeedReader();
        }

        public List<Post> GetPosts()
        {
            return _feedReader.GetPostsFromFeed();
        }
    }
}
