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

namespace LabProject
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			WindowStyle = WindowStyle.None;
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
		}

		private void ViewUser(object sender, RoutedEventArgs e)
		{
			User UserWindow = new User();
			UserWindow.Show();
			Close();
		}

		private void ViewClient(object sender, RoutedEventArgs e)
		{
			ClientForm ClientWindow= new ClientForm();
			ClientWindow.Show();
			Close();
		}

		private void ViewAdmin(object sender, RoutedEventArgs e)
		{
			LoginAdmin AdminWindow = new LoginAdmin();
			AdminWindow.Show();
			Close();
		}
	}
}
