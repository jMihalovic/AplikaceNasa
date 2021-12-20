using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using System.IO;

namespace AplikaceNasa
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static Rootobject AsteroidData;

        static Rootobject OfflineAsteroids;

        static API_Data info;

        public static ObservableCollection<Asteroid> AsteroidsOnline { get; set; }
        public static ObservableCollection<Asteroid> AsteroidFavs { get; set; }
        public static ObservableCollection<Asteroid> AsteroidsAll { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ZiskejOnlineData();
            while(info == null)
            {



            }

            string s;
            StreamReader sr = new StreamReader("Json.txt");
            s = sr.ReadToEnd();
            if (s != null && s != "")
            {
                OfflineAsteroids = JsonConvert.DeserializeObject<Rootobject>(s);
                AsteroidFavs = new ObservableCollection<Asteroid>(OfflineAsteroids.near_earth_objects.asteroids);
            }
            try
            {
                foreach (var x in AsteroidsOnline)
                {

                    AsteroidsAll.Add(x);

                }
            }
            catch { }
            try
            {
                foreach (var x in AsteroidFavs)
                {

                    AsteroidsAll.Add(x);

                }
                
            }
            catch { }
            Asteroid_List.ItemsSource = AsteroidsAll;
        }

        private async void ZiskejOnlineData()
        {
            string API_KEY = "6s4paFhcy981wiKvqPT2Awc1StRsc2ubhJsgE8pu";
            DateTime now = DateTime.Now;
            string odkaz = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={now.Year}-{now.Month}-{now.Day}&end_date={now.Year}-{now.Month}-{now.Day}&api_key={API_KEY}";

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {

                info = await Volani_API.Get(odkaz);

                if (info.Data != null && info.Data != "")
                {
                    Regex reg = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");
                    string database = reg.Replace(info.Data, "date", 1, 500);

                    AsteroidData = JsonConvert.DeserializeObject<Rootobject>(database);
                    AsteroidsOnline = new ObservableCollection<Asteroid>(AsteroidData.near_earth_objects.asteroids);
                }

            }


        }

        private void Asteroids_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Asteroid_List_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Informace inf = new Informace();
            inf.ShowDialog();
        }
    }
}
