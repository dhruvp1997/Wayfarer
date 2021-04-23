using System;
using System.Collections.Generic;
using System.Text;
using Wayfarer.Views;
using Xamarin.Forms;

namespace Wayfarer.ViewModels
{
    class VerificationViewModel : BaseViewModel
    
    {
        public Command VerificationCommand { get; }

        public VerificationViewModel ()
        {
            VerificationCommand = new Command(OnVerificationClicked);
        }

        private async void OnVerificationClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(FilterPage)}");
        }
    }
}
