using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
//using Map = Microsoft.Maui.Controls.Maps.Map;


namespace HammondHistoricalSites
{
    public partial class PinHelper : ContentPage
    {
        
        public  List<Pin> GeneratePins ()
        {
            List<Pin> pins = new List<Pin> ();
            
            Pin pin = new Pin
            {
                Location = new Location(41.60592964993884, -87.50962858933096),
                Label = "high school",
                Address = "hammond high",
                Type = PinType.Place
            };
            pin.InfoWindowClicked += async (s, args) =>
            {
                //event is getting triggered successfully
                //args.HideInfoWindow = true;
                string pinName = ((Pin)s).Label;
                await DisplayAlert("Pin Clicked", $"{pinName} was clicked.", "Ok");
            };
            pins.Add(pin);

            pin = new Pin
            {
                Location = new Location(41.6050272966378, -87.50798346659012),
                Label = "Hammond City Hall",
                Address = "The city hall of Hammond",
                Type = PinType.Place
            };
            //pin.InfoWindowClicked += OnInfoWindowClickedAsync;
            pins.Add(pin);

            pin = new Pin
            {
                Location = new Location(41.60972103145713, -87.52161796689008),
                Label = "Turner House Media",
                Address = "Helping to preserve the history of Hammond and nearby areas",
                Type = PinType.Place
            };
            pins.Add(pin);

            return pins;
        }

        async void OnMarkerClickedAsync(object sender, PinClickedEventArgs e)
        {
            e.HideInfoWindow = true;
            string pinName = ((Pin)sender).Label;
            await DisplayAlert("Pin Clicked", $"{pinName} was clicked.", "Ok");
        }

        async void OnInfoWindowClickedAsync(object sender, PinClickedEventArgs e)
        {
            string pinName = ((Pin)sender).Label;
            await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pinName}.", "Ok");
        }
    }
}