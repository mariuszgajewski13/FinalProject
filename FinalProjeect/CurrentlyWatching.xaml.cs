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
            where data.id_serialu == data1.id_serialu
            select new { data1.nazwa } ;

            current.ItemsSource = query.ToList();
        }

        public CurrentlyWatching(object data) : this()
        {
            this.DataContext = data;
        }
    }
}
