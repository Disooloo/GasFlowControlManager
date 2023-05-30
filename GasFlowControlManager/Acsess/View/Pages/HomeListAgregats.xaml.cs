using ControlzEx.Standard;
using GasFlowControlManager.Acsess.DataBase;
using GasFlowControlManager.Acsess.Managers;
using GasFlowControlManager.Acsess.View.Pages.Admins;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
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
using static System.Net.Mime.MediaTypeNames;

namespace GasFlowControlManager.Acsess.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomeListAgregats.xaml
    /// </summary>
    public partial class HomeListAgregats : Page
    {

        private GasCompressors _currentGas = new GasCompressors();

        public HomeListAgregats(GasCompressors selectGas)
        {
            InitializeComponent();

            if (selectGas != null)
                _currentGas = selectGas;

            DataContext = _currentGas;

            TextBlock currentPressureTextBlock = FindName("currentPressure") as TextBlock;
            if (currentPressureTextBlock != null)
            {
                CurrentProsentAndColor(currentPressureTextBlock);
            }
            convertPower();
        }


        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                var context = DBGasFlowControlManagerEntities2.GetContext();
                foreach (var entry in context.ChangeTracker.Entries())
                {
                    if (entry.State != EntityState.Added)
                    {
                        entry.Reload();
                    }
                }

                listBox.ItemsSource = context.GasCompressors.OrderByDescending(item => item.Id).ToList();
                coutAgr.Text = context.GasCompressors.Count().ToString();
            }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool power)
            {
                return power ? 1.0 : 0.5;
            }

            return 1.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private static void CurrentProsentAndColor(TextBlock textBlock)
        {
            using (var context = new DBGasFlowControlManagerEntities2())
            {
                var entity = context.GasCompressors.FirstOrDefault();

                if (entity != null)
                {
                    decimal currentFlowRate = (decimal)entity.CurrentPressure;
                    decimal maxPressure = (decimal)entity.MaxPressure;

                    Brush brush;
                    if (currentFlowRate > maxPressure)
                    {
                        brush = new SolidColorBrush(Colors.Red);
                    }
                    else if (currentFlowRate == maxPressure)
                    {
                        brush = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        brush = new SolidColorBrush(Colors.Green);
                    }

                    string res = textBlock.Text = currentFlowRate.ToString();
                    textBlock.Foreground = brush;

                    Console.WriteLine(res);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            var currentCompany = DBGasFlowControlManagerEntities2.GetContext().GasCompressors.ToList();

            currentCompany = currentCompany.Where(p =>
                p.Name.ToLower().Contains(TBox_search.Text.ToLower())
                || p.Id.ToString().Contains(TBox_search.Text.ToLower())).ToList();

            listBox.ItemsSource = currentCompany.ToList();
        }
        
        private void convertPower()
        {
            using (var context = new DBGasFlowControlManagerEntities2())
            {
                var listBoxItem = (ListBoxItem)listBox.ItemContainerGenerator.ContainerFromItem(listBox.SelectedItem);
                var powerStockIcon = listBoxItem?.FindName("powerStock") as PackIcon;

                if (powerStockIcon != null)
                {
                    // Установка нового значения Foreground
                    powerStockIcon.Foreground = new SolidColorBrush(Colors.Red);
                }

            }

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ManufacturerBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Max_PressureBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Max_Flow_Rate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SaveAgr_Click(object sender, RoutedEventArgs e)
        {
            // Проверка наличия ошибок в введенных данных
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentGas.Name))
                errors.AppendLine("Имя не может быть пустым");
            if (string.IsNullOrWhiteSpace(_currentGas.Manufacturer))
                errors.AppendLine("Поставщик не может быть пустым");
            if (_currentGas.MaxPressure <= 0)
                errors.AppendLine("Максимальная мощность не может быть пустым");
            if (_currentGas.MaxFlowRate <= 0)
                errors.AppendLine("Максимальное давление не может быть пустым");

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
                    StateName = _currentGas.Name + " | Добавлен | ",
                    StartDateTime = DateTime.Now,
                    CurrentPower = 0,
                    CurrentPressure = 0

                };

                context.StatesLogs.Add(newLog);

                try
                {
                    context.SaveChanges();
                    Manager.MainFrame.Navigate(new HomeListAgregats(null));
                    MessageBox.Show("Данные сохранены");
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

        private void OpenModelWindowAddAgr_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModelWindows.Visibility = Visibility.Visible;

        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Manager.MainFrame.Navigate(new GasShowPage((sender as System.Windows.Controls.ListBox).DataContext as GasCompressors));
            var selectedGasCompressor = (sender as System.Windows.Controls.ListBox)?.SelectedItem as GasCompressors;
            if (selectedGasCompressor != null)
            {
                Manager.MainFrame.Navigate(new GasShowPage(selectedGasCompressor));
            }
        }
    }
}
