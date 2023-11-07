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
using занятие_1.appWimdows;

namespace занятие_1.appPages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void Bspisok_Click(object sender, RoutedEventArgs e)
        {
           
            MainFrame.Navigate(new User());

        }
        private void Bprof_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            //profileWindow.Show();
            profileWindow.ShowDialog();
        }
        private void Bexit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void Bmesage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pozor");
        }

        private void Bregister_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Register());
        }
    }
}
