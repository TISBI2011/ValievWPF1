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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        Dish contextDish;
        public AddPage(Dish dish)
        {
            InitializeComponent();
            CBTypeDish.ItemsSource = App.DB.TypeDish.ToList();
            contextDish = dish;
            DataContext = dish;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (contextDish.id == 0)
                App.DB.Dish.Add(contextDish);
            App.DB.SaveChanges();
            MessageBox.Show("Udar!!! Bludo dobavleno");
            NavigationService.GoBack();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
