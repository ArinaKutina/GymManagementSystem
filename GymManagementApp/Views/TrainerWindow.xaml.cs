using GymManagementApp.DB;
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

namespace GymManagementApp.Views
{
    /// <summary>
    /// Логика взаимодействия для TrainerWindow.xaml
    /// </summary>
    public partial class TrainerWindow : Window
    {
        int IdTrainer { get; set; }
        GymManagementSystemEntities systemEntities = new GymManagementSystemEntities();
        public TrainerWindow(int idTrainer)
        {
            InitializeComponent();
            ClientGrid.ItemsSource = systemEntities.Attendence.Where(p => p.Clients.idTrainer == idTrainer).ToList();
            IdTrainer = idTrainer;
        }

        private void IsHereButton_Click(object sender, RoutedEventArgs e)
        {
            var x = ClientGrid.SelectedItem as Attendence;
            try
            {
                var r = systemEntities.Attendence.Where(y => y.idClient == x.idClient).Single();
                r.countTrainings++;
            }
            catch
            {
            }
            systemEntities.SaveChanges();
            ClientGrid.ItemsSource = systemEntities.Attendence.Where(p => p.Clients.idTrainer == IdTrainer).ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
