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
using KitaiskayaKuhnya.Model;

namespace KitaiskayaKuhnya.Pages
{
    /// <summary>
    /// Логика взаимодействия для DishesListPage.xaml
    /// </summary>
    public partial class DishesListPage : Page
    {
        public DishesListPage()
        {
            InitializeComponent();
            DGridDishes.ItemsSource = App.DB.Dish.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage(new Model.Dish()));
        }

        private void DGridDishes_Loaded(object sender, RoutedEventArgs e)
        {
            DGridDishes.ItemsSource = App.DB.Dish.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
