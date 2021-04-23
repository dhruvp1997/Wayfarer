using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wayfarer.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wayfarer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerificationPage : ContentPage
    {
        public VerificationPage()
        {
            InitializeComponent();
            this.BindingContext = new VerificationViewModel();
        }
    }
}