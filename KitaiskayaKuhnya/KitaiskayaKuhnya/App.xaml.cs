using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KitaiskayaKuhnya.Model;

namespace KitaiskayaKuhnya
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Pr1ValievEntities DB = new Pr1ValievEntities();
        public static User LogedUser;
    }
}
