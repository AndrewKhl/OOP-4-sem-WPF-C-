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
    /// Логика взаимодействия для InfoEnterRoomAdmin.xaml
    /// </summary>
    public partial class InfoEnterRoomAdmin : Window
    {
        public InfoEnterRoomAdmin()
        {
            InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
		}
    }
}
