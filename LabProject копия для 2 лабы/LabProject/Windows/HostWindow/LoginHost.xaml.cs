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
	/// Логика взаимодействия для LoginHost.xaml
	/// </summary>
	public partial class LoginHost : Window
	{
		public LoginHost()
		{
			InitializeComponent();
			WindowStyle = WindowStyle.None;
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
		}

		private void LoginSystem(object sender, RoutedEventArgs e)
		{
			int num = 0;
			bool ok = true;

			try
			{
				num = Convert.ToInt32(Number.Text.ToString());
			}

			catch(Exception)
			{
				ok = false;
				MessageBox.Show("Неверный номер комнаты!");
			}


			if (ok && (Stock.MainWindowDC as Hotel).FindHost(Name.Text.ToString(),num))
			{
				ApartInfo Apr = new ApartInfo(0);
				Apr.Show();
				Close();
			}
			else
			if (ok)
			{
				MessageBox.Show("Такого пользователя не существует!");
			}
		}
	}
}
