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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }

        private void EditClientsButton_Click(object sender, RoutedEventArgs e)
        {
            EditClientsWindow editClientsWindow = new EditClientsWindow();
            editClientsWindow.Show();
            Close();
        }

        private void EditTrainersButton_Click(object sender, RoutedEventArgs e)
        {
            EditTrainersWindow editTrainersWindow = new EditTrainersWindow();
            editTrainersWindow.Show();
            Close();
        }

        private void EditApparatusButton_Click(object sender, RoutedEventArgs e)
        {
            EditApparatusWindow editApparatusWindow = new EditApparatusWindow();
            editApparatusWindow.Show();
            Close();
        }
    }
}
