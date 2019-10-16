using FutureWords.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureWords.Shared.Services
{
    public interface IPostService
    {
        Post GetPost();
        List<Post> GetPosts();
    }
}
