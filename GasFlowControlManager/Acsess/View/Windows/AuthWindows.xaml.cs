using GasFlowControlManager.Acsess.DataBase;
using GasFlowControlManager.Acsess.View.Pages;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
        }

        private void loginEnter(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            string login = loginBox.Text;
            string pass = passwordBox.Password.ToString();

            Users authUser = null;

            using (DBGasFlowControlManagerEntities1 db = new DBGasFlowControlManagerEntities1())
            {
                authUser = db.Users.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();

                if (authUser != null && authUser.IsAdmin == true)
                {
                    MessageBox.Show(authUser.FullName.ToString() + ", Вы авторизовались под админкой");
                    // Update last login date
                    authUser.LastLoginDate = DateTime.Now;

                    // Создание записи в ParametersLogs
                    ParametersLogs parametersLog = new ParametersLogs();
                    parametersLog.UserId = authUser.Id;
                    parametersLog.UserName = authUser.FullName;
                    parametersLog.LoginDate = DateTime.Now;

                    // Добавление записи в ParametersLogs
                    try
                    {
                        db.ParametersLogs.Add(parametersLog);
                        db.SaveChanges();

                        mainWindow.Show();
                        this.Close();
                    }
                    catch (DbUpdateException ex)
                    {
                        // Обработка ошибки
                        MessageBox.Show("Ошибка при обновлении записей: " + ex.Message);
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show("Дополнительные сведения: " + ex.InnerException.Message);
                        }
                    }


                }
                else if (authUser != null && authUser.IsAdmin == false)
                {
                    MessageBox.Show("Добро пожаловать: " + authUser.FullName.ToString());

                    // Обновление даты последнего входа в Users
                    authUser.LastLoginDate = DateTime.Now;

                    // Создание записи в ParametersLogs
                    ParametersLogs parametersLog = new ParametersLogs();
                    parametersLog.UserId = authUser.Id;
                    parametersLog.UserName = authUser.FullName;
                    parametersLog.LoginDate = DateTime.Now;

                    // Добавление записи в ParametersLogs
                    db.ParametersLogs.Add(parametersLog);
                    db.SaveChanges();

                    mainWindow.Show();
                    this.Close();
                }

                else if (login == "" && pass == "" && authUser == null)
                    MessageBox.Show("Строка не может быть пустой");
              
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }



        private void dragme(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ClickMouseClosing_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
