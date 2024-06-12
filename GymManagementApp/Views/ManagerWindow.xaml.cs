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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        GymManagementSystemEntities systemEntities = new GymManagementSystemEntities();
        public ManagerWindow()
        {
            InitializeComponent();
            ClientGrid.ItemsSource = systemEntities.Clients.ToList();
            TrainerGrid.ItemsSource = systemEntities.Trainers.ToList();
            ApparatusGrid.ItemsSource = systemEntities.Apparatus.ToList();
        }
        ReportGenerator reportGenerator = new ReportGenerator();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            reportGenerator.GenerateReport();
            MessageBox.Show("Отчет сгенерирован!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void AbonementButton_Click(object sender, RoutedEventArgs e)
        {
            var q = ClientGrid.SelectedItem as Clients;
            q.stateAbonement = 3;
            systemEntities.SaveChanges();
            ClientGrid.ItemsSource = systemEntities.Clients.ToList();
        }
    }
}
