using GymManagementApp.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для EditClientsWindow.xaml
    /// </summary>
    public partial class EditClientsWindow : Window
    {
        GymManagementSystemEntities systemEntities = new GymManagementSystemEntities();
        public EditClientsWindow()
        {
            InitializeComponent();
            ClientGrid.ItemsSource = systemEntities.Clients.ToList();
        }

        public void Update()
        {
            ClientGrid.ItemsSource = systemEntities.Clients.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients()
            {
                surnameClient = SurnameBox.Text,
                nameClient = NameBox.Text,
                patronimicClients = PatonimicBox.Text,
                telephoneNum = Convert.ToInt64(TelephoneBox.Text),
                stateAbonement = 2
            };
            systemEntities.Clients.Add(clients);
            systemEntities.SaveChanges();
            Update();

            var g = systemEntities.Clients.Where(p => p.surnameClient == SurnameBox.Text && p.nameClient == NameBox.Text && p.patronimicClients == PatonimicBox.Text).Single();
            Attendence attendence = new Attendence()
            {
                idClient = g.idClient,
                countTrainings = 1
            };
            systemEntities.Attendence.Add(attendence);
            systemEntities.SaveChanges();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var p = ClientGrid.SelectedItem as Clients; 

            p.surnameClient = SurnameBox.Text;
            p.nameClient = NameBox.Text;
            p.patronimicClients = PatonimicBox.Text;
            p.telephoneNum = Convert.ToInt64(TelephoneBox.Text);

            systemEntities.SaveChanges();
            Update();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var v = ClientGrid.SelectedItem as Clients;
                systemEntities.Clients.Remove(v);
                systemEntities.SaveChanges();
                Update();
            }
            catch { }
        }
        private void ClientGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                var b = ClientGrid.SelectedItem as Clients;

                SurnameBox.Text = b.surnameClient;
                NameBox.Text = b.nameClient;
                PatonimicBox.Text = b.patronimicClients;
                TelephoneBox.Text = b.telephoneNum.ToString();
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
