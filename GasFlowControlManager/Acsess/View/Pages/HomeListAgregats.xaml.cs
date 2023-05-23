using GasFlowControlManager.Acsess.DataBase;
using GasFlowControlManager.Acsess.Managers;
using System;
using System.Collections;
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
using static System.Net.Mime.MediaTypeNames;

namespace GasFlowControlManager.Acsess.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomeListAgregats.xaml
    /// </summary>
    public partial class HomeListAgregats : Page
    {
        public string CurrentEfficiencyValue { get; set; }

        public HomeListAgregats()
        {
            InitializeComponent();
            //listBox.ItemsSource = DBGasFlowControlManagerEntities.GetContext().GasCompressors.ToList();
            listBox.ItemsSource = DBGasFlowControlManagerEntities1.GetContext().GasCompressors.OrderByDescending(item => item.Id).ToList();
            TextBlock currentPressureTextBlock = FindName("currentPressure") as TextBlock;
            if (currentPressureTextBlock != null)
            {
                CurrentProsentAndColor(currentPressureTextBlock);
            }
        }

        private static void CurrentProsentAndColor(TextBlock textBlock)
        {
            using (var context = new DBGasFlowControlManagerEntities1())
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


    }
}
