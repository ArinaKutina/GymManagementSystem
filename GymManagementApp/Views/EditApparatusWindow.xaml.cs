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
    /// Логика взаимодействия для EditApparatusWindow.xaml
    /// </summary>
    public partial class EditApparatusWindow : Window
    {
        GymManagementSystemEntities systemEntities = new GymManagementSystemEntities();
        public EditApparatusWindow()
        {
            InitializeComponent();
            ApparatusGrid.ItemsSource = systemEntities.Apparatus.ToList();
        }
        public void Update()
        {
            ApparatusGrid.ItemsSource = systemEntities.Apparatus.ToList();
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Apparatus apparatus = new Apparatus()
            {
                nameApparatus = nameBox.Text
            };
            systemEntities.Apparatus.Add(apparatus);
            systemEntities.SaveChanges();
            Update();
        }
        private void ApparatusGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                var b = ApparatusGrid.SelectedItem as Apparatus;

                nameBox.Text = b.nameApparatus;
                
            }
            catch { }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var p = ApparatusGrid.SelectedItem as Apparatus;

            p.nameApparatus = nameBox.Text;
            systemEntities.SaveChanges();
            Update();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var v = ApparatusGrid.SelectedItem as Apparatus;
                systemEntities.Apparatus.Remove(v);
                systemEntities.SaveChanges();
                Update();
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
