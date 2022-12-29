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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        User user = new User();
        public UserPage(User _user)
        {
            InitializeComponent();
            CreateEvent.Visibility = Visibility.Hidden;
            user = _user;
            FIO.Text = user.FirstName + " " + user.MiddleName + " " + user.LastName;
            if (user.IdGrade == 2)
            {
                CreateEvent.Visibility = Visibility.Visible;
            }
        }

        private void CreateEvent_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.MainFrame.Navigate(new CreateEventPage());
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.MainFrame.Navigate(new UpdateUser(user));
        }
    }
}
