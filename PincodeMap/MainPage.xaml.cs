using Bing.Maps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PincodeMap
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        public class MyText
        {
            public string t1 { get; set; }
            public string t2 { get; set; }
        }

        private async void search_button_Click(object sender, RoutedEventArgs e)
        {
            map1.Credentials = "AutVzTJ62c1kL9L5ni3TBhm5nr1wGSSxL04Zrsw6DTTUeoTT7VqS1Vup4vFmSYaL";
            Uri geocodeRequest = new Uri(string.Format("https://data.gov.in/api/datastore/resource.json?resource_id=04cbe4b1-2f2b-4c39-a1d5-1c2e28bc0e32&api-key=89e479d24bcb37745046aa07c9a39f4b&filters[pincode]={0}", text_pin.Text)); // 89e479d24bcb37745046aa07c9a39f4b
            
            HttpClient client = new HttpClient();
            
            HttpResponseMessage response = await client.GetAsync(geocodeRequest);
            if (response.IsSuccessStatusCode == true)
            {
                var data = response.Content.ReadAsStringAsync();
                var mylist = JsonConvert.DeserializeObject<PincodeMap.Class1.RootObject>(data.Result);


                var mydataa = mylist.records;

                var record_data = mydataa[0];

                var mylati = record_data.latitude;
                var mylongi = record_data.longitude;
                

                
                

                MyText mt = new MyText();
                mt.t1 = record_data.Taluk;
                
                this.DataContext = mt;


                   

                    Location l = new Location();

                if(mylati.Length>2)
                {
                    l.Latitude = Convert.ToDouble(mylati);
                    l.Longitude = Convert.ToDouble(mylongi);
                    map1.SetView(l, 15);
                    MapLayer.SetPosition(pp, l);
                }
                else
                {
                    var msd = new MessageDialog("No Latitude and Longitude values").ShowAsync();
                }
                    
                
            }
        }
    }
}
