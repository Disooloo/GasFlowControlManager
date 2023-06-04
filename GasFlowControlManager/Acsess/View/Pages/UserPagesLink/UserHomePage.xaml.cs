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

namespace GasFlowControlManager.Acsess.View.Pages.UserPagesLink
{
    /// <summary>
    /// Логика взаимодействия для UserHomePage.xaml
    /// </summary>
    public partial class UserHomePage : Page
    {
        public UserHomePage()
        {
            InitializeComponent();
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

    }
}
