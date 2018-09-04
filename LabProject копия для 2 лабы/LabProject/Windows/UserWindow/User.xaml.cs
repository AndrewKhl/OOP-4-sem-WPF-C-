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
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
        {
            InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = new Hotel();
			Stock.MainWindowDC = DataContext;
		}

		private void Click(object sender, RoutedEventArgs e)
		{
			string str = (sender as Button).Name.ToString();
			(Stock.MainWindowDC as Hotel).ThisIsRoom(str);
			RoomInfo RoomWindow = new RoomInfo();
			RoomWindow.Show();
		}
	}
}
