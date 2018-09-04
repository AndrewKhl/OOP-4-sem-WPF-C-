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
    /// Логика взаимодействия для ServiceApart.xaml
    /// </summary>
    public partial class ServiceApart : Window
    {
		Hotel Hotel;
        public ServiceApart()
        {
            InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
			Hotel = Stock.MainWindowDC as Hotel;
		}

		private void Add(object sender, RoutedEventArgs e)
		{
			if (Serv.Text != "")
				Hotel.IsApartament.Service.Add(Serv.Text.ToString());
			Serv.Text = "";
		}

		private void Delete(object sender, RoutedEventArgs e)
		{
			Hotel.IsApartament.Service.Remove(Hotel.Serv);
		}
	}
}
