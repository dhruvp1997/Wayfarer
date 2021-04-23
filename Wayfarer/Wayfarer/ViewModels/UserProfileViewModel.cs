using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Wayfarer.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        public UserProfileViewModel()
        {
            Title = "UserProfile";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.facebook.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}