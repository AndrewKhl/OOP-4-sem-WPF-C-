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
	/// Логика взаимодействия для ClientForm.xaml
	/// </summary>
	public partial class ClientForm : Window
	{
		public ClientForm()
		{
			InitializeComponent();
			WindowStyle = WindowStyle.None;
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = new Hotel();
			Stock.MainWindowDC = DataContext;
		}

		private void MyRoom(object sender, RoutedEventArgs e)
		{
			LoginHost Login = new LoginHost();
			Login.Show();
			Close();
		}

		private void AddHost(object sender, RoutedEventArgs e)
		{
			AddNewHost AddHost = new AddNewHost();
			AddHost.Show();
			Close();
		}
	}
}
