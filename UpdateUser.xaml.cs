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
    /// Логика взаимодействия для UpdateUser.xaml
    /// </summary>
    public partial class UpdateUser : Page
    {
        User user = new User();
        public UpdateUser(User _user)
        {
            InitializeComponent();
            Gender.ItemsSource = ekzamenEntities.GetContext().Gender.Select(a => a).Distinct().ToList();
            user = _user;
            tbf.Text = user.FirstName;
            tbi.Text = user.MiddleName;
            Gender.SelectedItem = user.Gender;
        }

        private void Save_Click_1(object sender, RoutedEventArgs e)
        {
            user.FirstName = tbf.Text;
            user.MiddleName = tbi.Text;
            user.IdGender = (Gender.SelectedItem as Gender).IdGender;
            ekzamenEntities.GetContext().SaveChanges();
            ClassPage.MainFrame.Navigate(new UserPage(user));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.MainFrame.Navigate(new UserPage(user));
        }
    }
}
