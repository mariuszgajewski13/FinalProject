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
            from stacja in dataEntities.stacje_tv
            from gatunki in dataEntities.gatunki
            let stacjaName = stacja.nazwa
            let gatunekName = gatunki.nazwa
            where data.id_stacji == stacja.id_stacji
            where gatunki.id_gatunku == data.id_gatunku_1
            //where gatunki.id_gatunku == data.id_gatunku_2
            //where gatunki.id_gatunku == data.id_gatunku_3
            select new { data.id_serialu, data.nazwa, data.rok_rozpoczecia, data.rok_zakonczenia, stacjaName, gatunekName, data.ilosc_sezonow, data.ilosc_odcinkow, data.czas_trwania_odcinka };
            
            all.ItemsSource = query.ToList();
        }

        public AllShows(object data) : this()
        {
            this.DataContext = data;
        }
    }
}
