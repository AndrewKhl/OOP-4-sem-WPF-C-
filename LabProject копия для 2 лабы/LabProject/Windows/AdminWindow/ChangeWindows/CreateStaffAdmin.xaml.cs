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
    /// Логика взаимодействия для CreateStaffAdmin.xaml
    /// </summary>
    public partial class CreateStaffAdmin : Window
    {
		int add = 0;

        public CreateStaffAdmin(int x)
        {
            InitializeComponent();
			add = x;
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
		}

		private void Add_Staff(object sender, RoutedEventArgs e)
		{
			if (add == 1)
				(Stock.MainWindowDC as Hotel).AddStaff();
			Close();
		}
	}
}
