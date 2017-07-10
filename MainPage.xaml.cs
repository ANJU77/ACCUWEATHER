using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Storage;
using Windows.UI.Popups;
using System.Collections.ObjectModel;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public ObservableCollection<Forecasts> Forecasts = new ObservableCollection<Forecasts>();

        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override async void OnNavigatedTo (NavigationEventArgs e)
        {

            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            if (localSettings.Values.ContainsKey("LocationConsent"))
            {


            }
            else
            var dialog = new MessageDialog(" Please enter your current location");
            dialog.Title = " Please ";
            dialog.Commands.Add(new UICommand { Label = " ok ",  res = 0 });
            dialog.Commands.Add(new UICommand { Label = " cancel ", res = 1 });
            var result = await dialog.ShowAsync();

            if((int)result.res == 0)

            { localSettings.Values["LocationConsent"] = true;

            }
             
            else
            {
                localSettings.Values["LocationConsent"] = false ;

            }
        }

        Tuple<string , string > pos = await GetLocAsync():


            public aysnc Task<Tuple< string , string>> GetLocAsync()
        {


        }


        private void Open(object sender, RoutedEventArgs e)
        {
            
 
        }
    }
}
