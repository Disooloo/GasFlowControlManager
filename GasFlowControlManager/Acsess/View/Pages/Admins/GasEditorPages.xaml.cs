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
    /// Логика взаимодействия для GasEditorPages.xaml
    /// </summary>
    public partial class GasEditorPages : Page
    {
        private GasCompressors _currentGas = new GasCompressors();
        public GasEditorPages(GasCompressors selectGas)
        {
            InitializeComponent();

            if (selectGas != null)
                _currentGas = selectGas;

            DataContext = _currentGas;
        }

        private void SaveAgr_Click(object sender, RoutedEventArgs e)
        {
            // Проверка наличия ошибок в введенных данных
            StringBuilder errors = new StringBuilder();

            if (_currentGas.MaxPressure <= 0)
                errors.AppendLine("Максимальное давление не может быть пустым");
            if (_currentGas.MaxFlowRate <= 0)
                errors.AppendLine("Максимальный расход не может быть пустым");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            using (var context = new DBGasFlowControlManagerEntities2())
            {
                // Создание новой записи GasCompressors
                if (_currentGas.Id == 0)
                    context.GasCompressors.Add(_currentGas);

                // Создание новой записи StatesLogs
                var newLog = new StatesLogs
                {
                    GasCompressorId = _currentGas.Id,
                    StateName = _currentGas.Name + " | Обновлен | ",
                    EndDateTime = DateTime.Now,
                    StartDateTime = _currentGas.InstallationDate ?? DateTime.Now, // Используем сегодняшнюю дату, если InstallationDate равна null
                    CurrentPower = _currentGas.CurrentFlowRate,
                    CurrentPressure = _currentGas.CurrentPressure
                };

                context.StatesLogs.Add(newLog);

                try
                {
                    context.SaveChanges();
                    Manager.MainFrame.GoBack();
                    MessageBox.Show("Данные обновлены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void ClosingModel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new HomeListAgregats(null));
        }
    }
}
