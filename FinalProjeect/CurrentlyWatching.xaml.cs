﻿using System;
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
    /// Interaction logic for CurrentlyWattching.xaml
    /// </summary>
    public partial class CurrentlyWatching : Page
    {
        public CurrentlyWatching()
        {
            InitializeComponent();
        }

        seriale_dbEntities dataEntities = new seriale_dbEntities();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from data in dataEntities.na_biezaco
            from data1 in dataEntities.seriale
            from stacja in dataEntities.stacje_tv
            from gatunki in dataEntities.gatunki
            where data.id_serialu == data1.id_serialu
            let stacjaName = stacja.nazwa
            let gatunekName = gatunki.nazwa
            where data1.id_stacji == stacja.id_stacji
            where gatunki.id_gatunku == data1.id_gatunku_1
            select new { data.id_serialu, data1.nazwa, data1.rok_rozpoczecia, data1.rok_zakonczenia, stacjaName, gatunekName, data1.ilosc_sezonow, data1.ilosc_odcinkow, data1.czas_trwania_odcinka };

            current.ItemsSource = query.ToList();
        }

        public CurrentlyWatching(object data) : this()
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
        private void Genre(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Genres.xaml", UriKind.Relative));
        }
        private void OnBreak(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Break.xaml", UriKind.Relative));
        }
        private void Stations(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TV_Stations.xaml", UriKind.Relative));
        }
    }
}
