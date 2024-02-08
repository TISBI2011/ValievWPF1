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

namespace KitaiskayaKuhnya.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string Login = TBlogin.Text;
            string Parol = TBparol.Text;


            var loggedUser = App.DB.User.FirstOrDefault(x => x.login == Login && x.parol == Parol);

            if (loggedUser == null)
            {
                MessageBox.Show("pole avtorizacii pustoe ili vvedini nevernie dannie");
                return;
            }

            App.LogedUser = loggedUser;
            NavigationService.Navigate(new DishesListPage());
        }
    }
}
