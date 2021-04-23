using System;
using System.Collections.Generic;
using System.Text;
using Wayfarer.Views;
using Xamarin.Forms;

namespace Wayfarer.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignupCommand { get; }
        public Command ForgotCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            SignupCommand = new Command(OnSignupClicked);
            ForgotCommand = new Command(OnForgotClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(FilterPage)}");
        }
        private async void OnSignupClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(SignupPage)}");
        }
        private async void OnForgotClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ForgotPage)}");
        }
    }
}
