using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Wayfarer.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Wayfarer.ViewModels
{
    class FilterViewModel : BaseViewModel
    {
        public IList<Country> CountryList { get; set; }
        public IList<State> StateList { get; set; }
        public IList<City> CityList { get; set; }
        public FilterViewModel()
        {
            try
            {
                CountryList = new ObservableCollection<Country>();
                CountryList.Add(new Country { CountryId = 1, CountryName = "India" });
                CountryList.Add(new Country { CountryId = 2, CountryName = "Canada" });
                CountryList.Add(new Country { CountryId = 3, CountryName = "America" });
                CountryList.Add(new Country { CountryId = 4, CountryName = "UK" });
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            try
            {
                StateList = new ObservableCollection<State>();
                StateList.Add(new State { StateId = 1, StateName = "Gujarat" });
                StateList.Add(new State { StateId = 2, StateName = "Delhi" });
                StateList.Add(new State { StateId = 3, StateName = "Maharastra" });
                StateList.Add(new State { StateId = 4, StateName = "Rajasthan" });
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            try
            {
                CityList = new ObservableCollection<City>();
                CityList.Add(new City {CityId = 1, CityName = "Ahmedabad"});
                CityList.Add(new City { CityId = 2, CityName = "Vadodara" });
                CityList.Add(new City { CityId = 3, CityName = "Surat" });
                CityList.Add(new City { CityId = 4, CityName = "Mehsana" });
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            Title = "Search For Location";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.facebook.com"));
        }
        public ICommand OpenWebCommand { get; }
    }
}
