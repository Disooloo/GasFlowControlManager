using GasFlowControlManager.Acsess.DataBase;
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

namespace GasFlowControlManager.Acsess.View.Pages.Admins
{
    /// <summary>
    /// Логика взаимодействия для UserShowPage.xaml
    /// </summary>
    public partial class UserShowPage : Page
    {
        private Users _currentTeam = new Users();
        public UserShowPage(Users selectTeam)
        {

            InitializeComponent();

            if (selectTeam != null)
                _currentTeam = selectTeam;

            DataContext = _currentTeam;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new HomeListAgregats(null));
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new UsersListPage((sender as Button).DataContext as Users));
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                int userIdToDelete = _currentTeam.Id; // Идентификатор пользователя для удаления

                using (var context = new DBGasFlowControlManagerEntities2())
                {
                    // Найти пользователя для удаления по его идентификатору
                    var userToDelete = context.Users.FirstOrDefault(u => u.Id == userIdToDelete);

                    if (userToDelete != null)
                    {
                        //Удалить пользователя из базы данных
                        context.Users.Remove(userToDelete);
                        context.SaveChanges();
                        MessageBox.Show("Пользователь успешно удален.");
                        Manager.MainFrame.GoBack();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден.");
                    }
                }
            }
            else
            {
                // Пользователь отменил удаление или закрыл диалоговое окно
            }
        }
    }
}
