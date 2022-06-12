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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for AddShow.xaml
    /// </summary>
    public partial class AddShow : Window
    {
        public AddShow()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            using(seriale_dbEntities db = new seriale_dbEntities())
            {
                seriale serialeDB = new seriale();
                serialeDB.nazwa = showName.Text;
                serialeDB.rok_rozpoczecia = int.Parse(beginYear.Text);
                serialeDB.rok_zakonczenia = int.Parse(endYear.Text);
                serialeDB.id_gatunku_1 = int.Parse(genres1.Text.ElementAt(0).ToString());
                serialeDB.id_gatunku_2 = int.Parse(genres1.Text.ElementAt(0).ToString());
                serialeDB.id_gatunku_3 = int.Parse(genres1.Text.ElementAt(0).ToString());
                serialeDB.id_stacji = int.Parse(genres1.Text.ElementAt(0).ToString());
                serialeDB.ilosc_sezonow = int.Parse(seasons.Text);
                serialeDB.ilosc_odcinkow = int.Parse(episodes.Text);
                serialeDB.czas_trwania_odcinka = int.Parse(episodeLength.Text);
                db.seriale.Add(serialeDB);
                db.SaveChanges();
                MessageBox.Show("Data inserted succcessfully");
            }
        }
    }
}
