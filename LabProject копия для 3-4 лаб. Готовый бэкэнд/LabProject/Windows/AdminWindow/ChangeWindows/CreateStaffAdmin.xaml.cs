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
		string job = "";
		Hotel Hotel;

        public CreateStaffAdmin(int x)
        {
            InitializeComponent();
			add = x;
			job = "";
			Hotel = Stock.MainWindowDC as Hotel;
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
			if (add == 0)
				PushFlag();
		}

		private void PushFlag()
		{
			job = Hotel.IsPerson.Job;
			var RadioBut = (RadioButton)FindName(job);

			if (RadioBut != null)
			{
				RadioBut.IsChecked = true;
			}

			if (Hotel.IsPerson.IsMain == true)
			{
				IsMain.IsChecked = true;
			}

			try
			{
				Hotel.Entertaiment_Room[job].Staff.Remove(Hotel.IsPerson);
				if (Hotel.IsPerson.IsMain == true)
					Hotel.Entertaiment_Room[job].Main = null;
			}
			catch (Exception) { }
		}

		private void Add_Staff(object sender, RoutedEventArgs e)
		{
			if (Name.Text.ToString() != "" && job != "")
			{
				if (add == 1)
					Hotel.AddStaff();
				Hotel.IsPerson.Job = job;
				if (IsMain.IsChecked == true && job != "")
				{
					Hotel.ClearMain(job);
					Hotel.IsPerson.IsMain = true;
					Hotel.Entertaiment_Room[Hotel.IsPerson.Job].Main = Hotel.IsPerson;
				}
				if (IsMain.IsChecked == false)
				{
					Hotel.IsPerson.IsMain = false;
					if (Hotel.Entertaiment_Room[job].Main == Hotel.IsPerson)
					{
						Hotel.Entertaiment_Room[job].Main = null;
					}
				}

				Hotel.Entertaiment_Room[job].Staff.Add(Hotel.IsPerson);
				Close();
			}
			else
				MessageBox.Show("Заполните поля имя и работа");
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			job = (sender as RadioButton).Content.ToString();
		}

		private void IsMain_Checked(object sender, RoutedEventArgs e)
		{
			if ((sender as CheckBox).IsChecked == false)
			{
				Hotel.IsPerson.IsMain = false;
				Hotel.Entertaiment_Room[job].Main = null;
			}
		}

		private void Dismiss(object sender, RoutedEventArgs e)
		{
			Hotel.DismissStaff();
			Close();
		}
	}
}
