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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {

		Hotel Hotel;
        public Admin()
        {
            InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = new Hotel();
			Stock.MainWindowDC = DataContext;
			Hotel = Stock.MainWindowDC as Hotel;
			Hotel.ChooseGuest();
		}

		private void InfoApartment(object sender, RoutedEventArgs e)
		{
			InfoRoomAdmin IRA = new InfoRoomAdmin();
			IRA.Show();
		}

		private void InfoRoom(object sender, RoutedEventArgs e)
		{
			InfoEnterRoomAdmin IERA = new InfoEnterRoomAdmin();
			IERA.Show();
		}

		private void InfoStaff(object sender, RoutedEventArgs e)
		{
			InfoStaffAdmin ISA = new InfoStaffAdmin();
			ISA.Show();
		}

		private void InfoHost(object sender, RoutedEventArgs e)
		{
			InfoGuestAdmin IGA = new InfoGuestAdmin();
			IGA.Show();
		}

		private void AddStaff(object sender, RoutedEventArgs e)
		{
			Hotel.NewStaff();
			CreateStaffAdmin CSA = new CreateStaffAdmin(1);
			CSA.Show();
		}

		private void ChangeStaff(object sender, RoutedEventArgs e)
		{
			CreateStaffAdmin CSA = new CreateStaffAdmin(0);
			CSA.Show();
		}

		private void ChangeHost(object sender, RoutedEventArgs e)
		{
			CreateHostAdmin CHA = new CreateHostAdmin();
			CHA.Show();
		}

		private void SaveAndExit(object sender, RoutedEventArgs e)
		{
			Hotel.SaveFile();
			Close();
		}

		private void ViewMenuPanel(object sender, RoutedEventArgs e)
		{
			if (Hotel.IsRoom.Name == "Bar" || Hotel.IsRoom.Name == "Restaurant")
			{
				Hotel.GoInEating();
				Menu menu = new Menu();
				menu.Show();
			}
			else
				MessageBox.Show("В данном помещении меню не предусмотрено!");
		}

		private void ServInRoom(object sender, RoutedEventArgs e)
		{
			ServiseRoom SR = new ServiseRoom();
			SR.Show();
		}

		private void ServInApart(object sender, RoutedEventArgs e)
		{
			ServiceApart SA = new ServiceApart();
			SA.Show();
		}
	}
}
