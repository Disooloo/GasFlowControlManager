using GasFlowControlManager.Acsess.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GasFlowControlManager.Acsess.View.Pages.Admins
{
    /// <summary>
    /// Логика взаимодействия для UsersListPage.xaml
    /// </summary>
    public partial class UsersListPage : Page
    {
        private Users _currentTeams = new Users();

        public UsersListPage(Users selectTeams)
        {
            InitializeComponent();

            if (selectTeams != null)
                _currentTeams = selectTeams;

            DataContext = _currentTeams;

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                DBGasFlowControlManagerEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DBlist.ItemsSource = DBGasFlowControlManagerEntities2.GetContext().Users.OrderByDescending(item => item.Id).ToList();

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new HomeListAgregats(null));
        }

        private void passAddGen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            password.Text = GeneratePassword();
        }

        private void UserStore_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentTeams.FullName))
                errors.AppendLine("Имя не может быть пустым");
            if (string.IsNullOrWhiteSpace(_currentTeams.Position))
                errors.AppendLine("Должность не может быть пустым");
            if (string.IsNullOrWhiteSpace(_currentTeams.Login))
                errors.AppendLine("Логин не может быть пустым");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentTeams.Id == 0)
                DBGasFlowControlManagerEntities2.GetContext().Users.Add(_currentTeams);

            // Добавьте код для сохранения значения Password и IsAdmin
            _currentTeams.Password = password.Text; // предполагается, что у вас есть элемент управления passwordBox
            _currentTeams.IsAdmin = IsAdmin.IsChecked ?? false; // предполагается, что у вас есть элемент управления IsAdmin типа CheckBox
            _currentTeams.RegistrationDate = DateTime.Now;

            try
            {
                DBGasFlowControlManagerEntities2.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private string GeneratePassword()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                int randomIndex = random.Next(0, validChars.Length);
                password.Append(validChars[randomIndex]);
            }

            return password.ToString();
        }

        private void UserShow_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new UserShowPage((sender as System.Windows.Controls.Button).DataContext as Users));
        }

       
    }
}
