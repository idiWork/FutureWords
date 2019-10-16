using FutureWords.Shared.Services;
using FutureWords.Shared.Views;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FutureWords.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        MainViewModel viewModel;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            viewModel = new MainViewModel(new PostMockService());
        }
    }
}
