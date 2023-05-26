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
using System.IO;


namespace GasFlowControlManager.Acsess.View.Pages.Log
{
    /// <summary>
    /// Логика взаимодействия для LogUserPage.xaml
    /// </summary>
    public partial class LogUserPage : Page
    {
        public LogUserPage()
        {
            InitializeComponent();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                DBGasFlowControlManagerEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DBlist.ItemsSource = DBGasFlowControlManagerEntities2.GetContext().ParametersLogs.ToList();
            LogCount.Text = DBGasFlowControlManagerEntities2.GetContext().ParametersLogs.Count().ToString();
        }

        private void Download_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SaveLogsToFile();
        }

        private void logAgr_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new LogsPage());
        }

        private void SaveLogsToFile()
        {
            string logs = string.Empty;

            // Получите логи из базы данных или другого источника
            List<ParametersLogs> logsList = DBGasFlowControlManagerEntities2.GetContext().ParametersLogs.ToList();

            // Сформируйте текстовое представление логов
            foreach (ParametersLogs log in logsList)
            {
                logs += $"Id: {log.Id}, Id пользователя: {log.UserId}, " +
                    $"Имя: {log.UserName}, Последний вход: " +
                    $"{log.LoginDate}{Environment.NewLine}";
            }

            // Укажите путь и имя файла для сохранения
            //string filePath = @"D:\Project\Git\Gas Flow Control Manager\GasFlowControlManager\GasFlowControlManager\Acsess";
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = System.IO.Path.Combine(userProfilePath, @"Desktop\LogsUser.txt");
            System.IO.File.WriteAllText(filePath, logs);

            // Сохраните логи в файл
            System.IO.File.WriteAllText(filePath, logs);


            MessageBox.Show("Файл логов сохранен | " + filePath);
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
