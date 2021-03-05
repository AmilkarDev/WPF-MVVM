using ManagementApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ManagementApp
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ManagementApp.MainWindow window = new MainWindow();
            DepartmentViewModel DVM = new DepartmentViewModel();
            window.DataContext = DVM;
            window.Show();
        }
    }
}
