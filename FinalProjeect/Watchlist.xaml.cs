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
    public partial class Watchlist : Page
    {
        seriale_dbEntities dataEntities = new seriale_dbEntities();
       
        public Watchlist()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from data in dataEntities.do_obejrzenia
            select new { data.nazwa};

            dataGrid.ItemsSource = query.ToList();
        }

        public Watchlist(object data) : this(){
            this.DataContext = data;
        }
    }
}
