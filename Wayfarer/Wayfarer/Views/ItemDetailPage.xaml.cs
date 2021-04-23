using System.ComponentModel;
using Wayfarer.ViewModels;
using Xamarin.Forms;

namespace Wayfarer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}