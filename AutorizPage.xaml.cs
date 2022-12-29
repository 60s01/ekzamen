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

namespace ekzamen
{
    /// <summary>
    /// Логика взаимодействия для AutorizPage.xaml
    /// </summary>
    public partial class AutorizPage : Page
    {
        public AutorizPage()
        {
            InitializeComponent();
        }
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var i in ekzamenEntities.GetContext().User)
            {
                if ((tbId.Text == Convert.ToString(i.IdUser)) || (tbId.Text == "0000"))
                {
                    ClassPage.MainFrame.Navigate(new UserPage(i));
                }
            }
        }
    }
}
