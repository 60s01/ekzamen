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
    /// Логика взаимодействия для CreateEventPage.xaml
    /// </summary>
    public partial class CreateEventPage : Page
    {
        Event _event = new Event();
        public CreateEventPage()
        {
            InitializeComponent();
            City.ItemsSource = ekzamenEntities.GetContext().City.Select(a => a).Distinct().ToList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _event.Title = tbTitle.Text;
            _event.DataTime = tbDate.Text;
            _event.Days = Convert.ToInt32(tbDays.Text);
            _event.IdCity = (City.SelectedItem as City).IdCity;
            if (_event.IdEvent == 0)
            {
                ekzamenEntities.GetContext().Event.Add(_event);
            }
            try
            {
                ekzamenEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }
    }
}
