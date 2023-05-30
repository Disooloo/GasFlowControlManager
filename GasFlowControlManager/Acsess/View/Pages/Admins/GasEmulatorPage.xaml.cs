using GasFlowControlManager.Acsess.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для GasEmulatorPage.xaml
    /// </summary>
    public partial class GasEmulatorPage : Page
    {
        private GasCompressors _currentGas = new GasCompressors();

        public GasEmulatorPage(GasCompressors selectGas)
        {
            InitializeComponent();
            if (selectGas != null)
                _currentGas = selectGas;

            DataContext = _currentGas;
        }

        private void ClosingModel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void SaveAgr_Click(object sender, RoutedEventArgs e)
        {
            // Проверка наличия ошибок в введенных данных
            StringBuilder errors = new StringBuilder();

            if (_currentGas.MaxPressure <= 0)
                errors.AppendLine("Мощность не может быть пустым");
            if (_currentGas.MaxFlowRate <= 0)
                errors.AppendLine("Давление не может быть пустым");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            _currentGas.Power = Power.IsChecked ?? false;

            using (var context = new DBGasFlowControlManagerEntities2())
            {
                try
                {
                    // Создание или обновление записи GasCompressors
                    if (_currentGas.Id == 0)
                    {
                        context.GasCompressors.Add(_currentGas);
                    }
                    else
                    {
                        var existingGas = context.GasCompressors.Find(_currentGas.Id);
                        if (existingGas != null)
                        {
                            context.Entry(existingGas).CurrentValues.SetValues(_currentGas);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка: запись GasCompressors не найдена.");
                            return;
                        }
                    }

                    // Создание новой записи StatesLogs
                    var newLog = new StatesLogs
                    {
                        GasCompressorId = _currentGas.Id,
                        StateName = _currentGas.Name + " | Изменен | ",
                        EndDateTime = DateTime.Now,
                        StartDateTime = _currentGas.InstallationDate,
                        CurrentPower = _currentGas.CurrentFlowRate,
                        CurrentPressure = _currentGas.CurrentPressure
                    };

                    context.StatesLogs.Add(newLog);

                    // Сохранение изменений в базе данных
                    context.SaveChanges();

                    Manager.MainFrame.Navigate(new HomeListAgregats(null));
                    MessageBox.Show("Данные сохранены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }


    }
}
