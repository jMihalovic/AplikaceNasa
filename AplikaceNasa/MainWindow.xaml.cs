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

namespace AplikaceNasa
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient client = new HttpClient();
        public MainWindow()
        {
            string API_KEY = "6s4paFhcy981wiKvqPT2Awc1StRsc2ubhJsgE8pu";
            DateTime now = DateTime.Now;
            string odkaz = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={now.Year}-{now.Month}-{now.Day}&end_date={now.Year}-{now.Month}-{now.Day}&api_key={API_KEY}";

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)               
            { 
            


            }
            else 
            {
            
            

            }


            InitializeComponent();
        }

        private void Asteroids_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Asteroids_MouseDoubleClick(object sender, SelectionChangedEventArgs e)
        {
            Informace inf = new Informace();
            inf.ShowDialog();
        }
    }
}
