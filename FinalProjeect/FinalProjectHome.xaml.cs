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

namespace FinalProject
{
    /// <summary>
    /// Logika interakcji dla klasy FinalrojeectHome.xaml
    /// </summary>
    public partial class FinalProjectHome : Page
    {
        public FinalProjectHome()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            //Watchlist Watchlist = new Watchlist(this.listNamesBox.SelectedItem);
            //AllShows allShows = new AllShows(this.listNamesBox.SelectedItem); 

            //this.NavigationService.Navigate(allShows);
            //switch (this.listNamesBox.SelectedItem)
            //{
            //    case "Watchlist":
            //        this.NavigationService.Navigate(Watchlist);
            //        break;

            //    default:
            //        this.NavigationService.Navigate(this);
            //        break;

            //}
            //var item = listNamesBox.Items[listNamesBox.SelectedIndex];
            //switch (item)
            //{
            //    case '1':
            //        NavigationService.Navigate(new Uri("/Watchlist.xaml", UriKind.Relative));
            //        break;
            //    default:
            //        NavigationService.Navigate(new Uri("/AllShows.xaml", UriKind.Relative));
            //        break ;
            //}
            
        }

        private void All(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AllShows.xaml", UriKind.Relative));
        }
        
        private void Watchlist(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Watchlist.xaml", UriKind.Relative));
        }
        private void Current(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CurrentlyWatching.xaml", UriKind.Relative));
        }
    }
}
