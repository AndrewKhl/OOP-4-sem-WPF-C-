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
    /// Логика взаимодействия для LoginAdmin.xaml
    /// </summary>
    public partial class LoginAdmin : Window
    {
        public LoginAdmin()
        {
            InitializeComponent();
			WindowStyle = WindowStyle.None;
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
		}

		private void LoginSystem(object sender, RoutedEventArgs e)
		{
			Login.Text = "admin";
			Password.Password = "123";

			if (Login.Text.ToLower() == "admin" && Password.Password == "123")
			{
				Admin MyAdmin = new Admin();
				MyAdmin.Show();
				Close();
			}
			else
			{
				MessageBox.Show("Неверный логин или пароль");
			}
		}
	}
}
