using GasFlowControlManager.Acsess.View.Pages;
using GasFlowControlManager.Acsess.View.Pages.Auth;
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
    /// Логика взаимодействия для AuthWindows.xaml
    /// </summary>
    public partial class AuthWindows : Window
    {
        public AuthWindows()
        {
            InitializeComponent();
            //AuthFrame.Navigate(new LoginPage());
            //Manager.MainFrame = AuthFrame;
        }
    }
}
