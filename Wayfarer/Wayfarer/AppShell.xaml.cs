using System;
using System.Collections.Generic;
using Wayfarer.ViewModels;
using Wayfarer.Views;
using Xamarin.Forms;

namespace Wayfarer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            

        }

    }
}
