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
using System.Data.Entity.Core.Objects;

namespace FinalProject
{
    /// <summary>
    /// Logika interakcji dla klasy Watchlist.xaml
    /// </summary>
    public partial class End : Page
    {
        seriale_dbEntities dataEntities = new seriale_dbEntities();

        public End()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
           from data in dataEntities.koniec
           from data1 in dataEntities.seriale
           where data.id_serialu == data1.id_serialu
           select new { data1.nazwa };

            dataGrid.ItemsSource = query.ToList();
        }

        public End(object data) : this()
        {
            this.DataContext = data;
        }
    }
}