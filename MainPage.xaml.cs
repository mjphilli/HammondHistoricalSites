
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace HammondHistoricalSites
{
    public partial class MainPage : ContentPage
    {
        Location location;
        MapSpan mapSpan;
        //Map map;

        public MainPage()
        {
            location = new Location(41.6050272966378, -87.50798346659012);
            mapSpan = new MapSpan(location, 0.01, 0.01);
            Map map = new Map(mapSpan);
            
            PinHelper pinHelper = new PinHelper();
            List<Pin> pins = pinHelper.GeneratePins();

            foreach (Pin pin in pins)
            {
                map.Pins.Add(pin);
            }

            Content = map;
        }
    }
}
