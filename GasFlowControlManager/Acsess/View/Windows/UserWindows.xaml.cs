using GasFlowControlManager.Acsess.Managers;
using GasFlowControlManager.Acsess.View.Pages;
using GasFlowControlManager.Acsess.View.Pages.UserPagesLink;
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

namespace GasFlowControlManager.Acsess.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserWindows.xaml
    /// </summary>
    public partial class UserWindows : Window
    {
        public UserWindows()
        {
            InitializeComponent();
            UserFrame.Navigate(new UserHomePage());
            Manager.MainFrame = UserFrame;
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AuthWindows authWindows = new AuthWindows();    
            authWindows.Show();
            this.Close();   
        }
    }
}
