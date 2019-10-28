using FutureWords.Shared.Models;
using System.Collections.Generic;

namespace FutureWords.Shared.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();
    }
}
