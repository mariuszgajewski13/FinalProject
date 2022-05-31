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
    /// Interaction logic for all.xaml
    /// </summary>
    public partial class AllShows : Page
    {
        public AllShows()
        {
            InitializeComponent();
        }
        seriale_dbEntities dataEntities = new seriale_dbEntities();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from data in dataEntities.seriale
            select new { data.nazwa };

            all.ItemsSource = query.ToList();
        }

        public AllShows(object data) : this()
        {
            this.DataContext = data;
        }
    }
}