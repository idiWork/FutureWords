using FutureWords.Shared.Models;
using FutureWords.Shared.Services;
using System.Collections.ObjectModel;

namespace FutureWords.Shared.Views
{
    public class MainViewModel
    {
        private readonly IPostService _postService;

        public MainViewModel(IPostService postService)
        {
            _postService = postService;

            Posts = new ObservableCollection<Post>(_postService.GetPosts());
        }

        public ObservableCollection<Post> Posts { get; set; }
    }
}
