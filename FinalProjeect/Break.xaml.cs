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
using System.Data.Entity.Core.Objects;

namespace FinalProject
{
    /// <summary>
    /// Logika interakcji dla klasy Watchlist.xaml
    /// </summary>
    public partial class Break : Page
    {
        seriale_dbEntities dataEntities = new seriale_dbEntities();
        Menu menu = new Menu();

        public Break()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
           from data1 in dataEntities.przerwa
           from data in dataEntities.seriale
           from stacja in dataEntities.stacje_tv
           from gatunki in dataEntities.gatunki
           let stacjaName = stacja.nazwa
           let gatunekName = gatunki.nazwa
           where data.id_serialu == data1.id_serialu
           where data.id_stacji == stacja.id_stacji
           where gatunki.id_gatunku == data.id_gatunku_1
           select new { data.id_serialu, data.nazwa, data.rok_rozpoczecia, data.rok_zakonczenia, stacjaName, gatunekName, data.ilosc_sezonow, data.ilosc_odcinkow, data.czas_trwania_odcinka };

            dataGrid.ItemsSource = query.ToList();
        }

        public Break(object data) : this()
        {
            this.DataContext = data;
        }

        public void All(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AllShows.xaml", UriKind.Relative));
            // menu.All();
        }

        private void Watchlist(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Watchlist.xaml", UriKind.Relative));
        }
        private void Current(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CurrentlyWatching.xaml", UriKind.Relative));
        }

        private void Ended(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/End.xaml", UriKind.Relative));
        }
        private void Genres(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Genres.xaml", UriKind.Relative));
        }
    }
}
