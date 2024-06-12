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
    /// Логика взаимодействия для EditTrainersWindow.xaml
    /// </summary>
    public partial class EditTrainersWindow : Window
    {
        GymManagementSystemEntities systemEntities = new GymManagementSystemEntities();
        public EditTrainersWindow()
        {
            InitializeComponent();
            TrainersGrid.ItemsSource = systemEntities.Trainers.ToList();
        }

        public void Update()
        {
            TrainersGrid.ItemsSource = systemEntities.Trainers.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users()
            {
                login = LoginBox.Text,
                pass = PasswordBox.Password,
                idRole = 3
            };
            systemEntities.Users.Add(users);
            systemEntities.SaveChanges();

            var v = systemEntities.Users.Where(p => p.login == LoginBox.Text && p.pass == PasswordBox.Password).Single();
            Trainers trainers = new Trainers()
            {
                idUser = v.idUser,
                surnameTrainer = SurnameBox.Text, 
                nameTrainer = NameBox.Text,
                patronimicTrainer = PatonimicBox.Text
            };
            systemEntities.Trainers.Add(trainers);
            systemEntities.SaveChanges();
            Update();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var p = TrainersGrid.SelectedItem as Trainers;

            p.surnameTrainer = SurnameBox.Text;
            p.nameTrainer = NameBox.Text;
            p.patronimicTrainer = PatonimicBox.Text; 

            systemEntities.SaveChanges();
            Update();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var g = TrainersGrid.SelectedItem as Trainers;
                systemEntities.Trainers.Remove(g);
                systemEntities.SaveChanges();
                Update();
            }
            catch { }
        }

        private void TrainersGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                var b = TrainersGrid.SelectedItem as Trainers;

                SurnameBox.Text = b.surnameTrainer;
                NameBox.Text = b.nameTrainer;
                PatonimicBox.Text = b.patronimicTrainer;
            }
            catch { }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();
        }
    }
}
