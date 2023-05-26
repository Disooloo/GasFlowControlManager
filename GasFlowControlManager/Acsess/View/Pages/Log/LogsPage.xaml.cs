using ControlzEx.Standard;
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
using System.IO;
using GasFlowControlManager.Acsess.View.Pages.Log;

namespace GasFlowControlManager.Acsess.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogsPage.xaml
    /// </summary>
    public partial class LogsPage : Page
    {
        public LogsPage()
        {
            InitializeComponent();
            
            
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                DBGasFlowControlManagerEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DBlist.ItemsSource = DBGasFlowControlManagerEntities2.GetContext().StatesLogs.ToList();
            LogCount.Text = DBGasFlowControlManagerEntities2.GetContext().StatesLogs.Count().ToString();
        }

        private void Download_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SaveLogsToFile();
        }

        private void SaveLogsToFile()
        {
            string logs = string.Empty;

            // Получите логи из базы данных или другого источника
            List<StatesLogs> logsList = DBGasFlowControlManagerEntities2.GetContext().StatesLogs.ToList();

            // Сформируйте текстовое представление логов
            foreach (StatesLogs log in logsList)
            {
                logs += $"Id: {log.Id}, Id Агрегатора: {log.GasCompressorId}, " +
                    $"Наименование: {log.StateName}, Начало работы: " +
                    $"{log.StartDateTime}, Последние изменения: " +
                    $"{log.EndDateTime}, Исходная мощьность: " +
                    $"{log.CurrentPower}, Исходное давление: " +
                    $"{log.CurrentPressure}{Environment.NewLine}";
            }

            // Укажите путь и имя файла для сохранения
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = System.IO.Path.Combine(userProfilePath, @"Desktop\LogsAgr.txt");
            System.IO.File.WriteAllText(filePath, logs);

            // Сохраните логи в файл
            System.IO.File.WriteAllText(filePath, logs);
            

            MessageBox.Show("Файл логов сохранен | " + filePath);
        }

        private void LogUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new LogUserPage());
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new HomeListAgregats());
        }
    }
}
