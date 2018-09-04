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
	/// Логика взаимодействия для AddNewHost.xaml
	/// </summary>
	public partial class AddNewHost : Window
	{
		public AddNewHost()
		{
			InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
			(Stock.MainWindowDC as Hotel).ViewFreeRooms();
		}

		private void InfoAboutApartment(object sender, RoutedEventArgs e)
		{
			if ((Stock.MainWindowDC as Hotel).IsApartament != null)
			{
				ApartInfo Apr = new ApartInfo(1);
				Apr.Show();
			}
		}
	}
}
