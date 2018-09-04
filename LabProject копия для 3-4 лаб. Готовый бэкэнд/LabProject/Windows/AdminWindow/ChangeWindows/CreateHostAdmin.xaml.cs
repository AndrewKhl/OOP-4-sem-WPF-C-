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
using System.Windows.Shapes;

namespace LabProject
{
    /// <summary>
    /// Логика взаимодействия для CreateHostAdmin.xaml
    /// </summary>
    public partial class CreateHostAdmin : Window
    {
        public CreateHostAdmin()
        {
            InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
		}

		private void ChangeGuest(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void Leave(object sender, RoutedEventArgs e)
		{
			(Stock.MainWindowDC as Hotel).LeaveHost();
			Close();
		}

		private void Delete(object sender, RoutedEventArgs e)
		{
			(Stock.MainWindowDC as Hotel).DeleteHost();
			Close();
		}
	}
}
