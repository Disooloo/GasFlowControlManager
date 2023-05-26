using GasFlowControlManager.Acsess.View.Pages;
using GasFlowControlManager.Acsess.View.Pages.Admins;
using GasFlowControlManager.Acsess.View.Windows;
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

namespace GasFlowControlManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new HomeListAgregats());
            Manager.MainFrame = MainFrame;
        }

        private void Emulator_MouseDown(object sender, MouseButtonEventArgs e)
        {
            

        }

        private void Log_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new LogsPage());
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AuthWindows authWindows = new AuthWindows();
            authWindows.Show();
            this.Close();
        }

        private void Users_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new UsersListPage(null));
        }
    }
}
