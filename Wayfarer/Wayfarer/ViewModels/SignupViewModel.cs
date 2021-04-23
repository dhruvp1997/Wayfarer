using System;
using System.Collections.Generic;
using System.Text;
using Wayfarer.Views;
using Xamarin.Forms;

namespace Wayfarer.ViewModels
{
    class SignupViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignupCommand { get; }
        public Command ForgotCommand { get; }

        public SignupViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            SignupCommand = new Command(OnSignupClicked);
            
        }
        private async void OnSignupClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(VerificationPage)}");
        }
        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        
       
    }
}
