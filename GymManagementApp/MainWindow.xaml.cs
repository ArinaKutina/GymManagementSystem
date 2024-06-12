using GymManagementApp.DB;
using GymManagementApp.Views;
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

namespace GymManagementApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GymManagementSystemEntities systemEntities = new GymManagementSystemEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EntButton_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text != "" && Password.Password != "")
            {
                try
                {
                    var id = systemEntities.Users.Where(p => p.login == Login.Text && p.pass == Password.Password).Select(p => new { p.idUser, p.idRole }).Single();
                    if (id.idRole == 1)
                    {
                        AdminWindow adminWin = new AdminWindow();
                        Close();
                        adminWin.Show();
                    }
                    else if (id.idRole == 2)
                    {
                        ManagerWindow manageWindow = new ManagerWindow();
                        Close();
                        manageWindow.Show();
                    }
                    else if (id.idRole == 3)
                    {
                        var v = systemEntities.Trainers.Where(o => o.idUser == id.idUser).Single();
                        TrainerWindow trainWindow = new TrainerWindow(v.idTrainer);
                        Close();
                        trainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неккоректные данные");
                    }
                }
                catch
                {
                    MessageBox.Show("Вы ввели неккоректные данные");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!!!");
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
