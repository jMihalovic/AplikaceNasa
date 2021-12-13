using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace AplikaceNasa
{
    class Asteroids
    {
        public Asteroids()
        {



        }



        public static ObservableCollection<Asteroids> AsteroidsAll { get; set; } = new ObservableCollection<Asteroids>();

        public static ObservableCollection<Asteroids> AsteroidsFavs { get; set; } = new ObservableCollection<Asteroids>();
    }
}
