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
    /// Логика взаимодействия для GasShowPage.xaml
    /// </summary>
    public partial class GasShowPage : Page
    {
        private GasCompressors _currentGas = new GasCompressors();
        public GasShowPage(GasCompressors selectGas)
        {
            InitializeComponent();

            if (selectGas != null)
                _currentGas = selectGas;

            DataContext = _currentGas;
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
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
                // Скопировал из класс с ShowUser, не хватает времени закинуть в отдельный класс. 
                int userIdToDelete = _currentGas.Id; // Идентификатор пользователя для удаления

                using (var context = new DBGasFlowControlManagerEntities2())
                {
                    // Найти запись для удаления по его идентификатору
                    var userToDelete = context.Users.FirstOrDefault(u => u.Id == userIdToDelete);

                    if (userToDelete != null)
                    {
                        //Удалить пользователя из базы данных
                        context.Users.Remove(userToDelete);
                        context.SaveChanges();
                        MessageBox.Show("Данные успешно удалены.");
                        Manager.MainFrame.GoBack();
                    }
                    else
                    {
                        MessageBox.Show("Возникла ошибка в удалении.");
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
